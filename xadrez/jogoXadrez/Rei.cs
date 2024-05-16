using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using xadrez.tabuleiro;

namespace xadrez.jogoXadrez {
    internal class Rei : Peca{

        private PartidaXadrez partida;
        public Rei(Tabuleiro tab, Cor cor, PartidaXadrez partida): base(tab, cor) {
            this.partida = partida;
        }
        public override string ToString() {
            return "R";
        }

        private bool podeMover(Posicao pos) {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != this.Cor;
        }

        private bool testeTorreParaRoque(Posicao pos) {
            Peca p = Tab.peca(pos);
            return p != null && p is Torre && p.Cor == Cor && p.QteMovimentos == 0;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[Tab.linhas, Tab.colunas];

            Posicao pos = new Posicao(0, 0);

            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            if(Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna -1);
            if (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.definirValores(Posicao.Linha , Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(Posicao.Linha -1, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //# jogada especial roque pequeno
            if(QteMovimentos == 0 && partida.xeque) {

                Posicao posT1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
                if (testeTorreParaRoque(posT1)) {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);
                    if(Tab.peca(p1)==null&& Tab.peca(p2) == null) {
                        mat[Posicao.Linha, Posicao.Coluna] = true;
                    }
                }

                //# jogada especial roque grande
                Posicao posT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
                if (testeTorreParaRoque(posT2)) {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);
                    if (Tab.peca(p1) == null && Tab.peca(p2) == null && Tab.peca(p3) == null) {
                        mat[Posicao.Linha, Posicao.Coluna - 2] = true;
                    }
                }
            }
            

                


            return mat;

        }
    }
}
