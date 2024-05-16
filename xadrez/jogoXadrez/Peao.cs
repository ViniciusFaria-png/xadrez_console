using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez.tabuleiro;

namespace xadrez.jogoXadrez {
    internal class Peao : Peca {

        private PartidaXadrez partida;
        public Peao(Tabuleiro tab, Cor cor, PartidaXadrez partida) : base(tab, cor) {
            this.partida = partida;
        }
        public override string ToString() {
            return "P";
        }

        private bool existeInimigo(Posicao pos) {
            Peca p = Tab.peca(pos);
            return p != null && p.Cor != Cor;
        }

        private bool livre(Posicao pos) {
            return Tab.peca(pos) == null;

        }


        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[Tab.linhas, Tab.colunas];

            Posicao pos = new Posicao(0, 0);

            if (Cor == Cor.Branca) {
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
                if (Tab.posicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha - 2, Posicao.Coluna);
                if (Tab.posicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna-1);
                if (Tab.posicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna+1);
                if (Tab.posicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                //# jogadaespecial en passant

                if(Posicao.Linha == 3) {
                    Posicao esquerda = new Posicao(pos.Linha, Posicao.Coluna - 1);
                    if(Tab.posicaoValida(esquerda)&& existeInimigo(esquerda) && Tab.peca(esquerda) == partida.vulneravelEnPassant) {
                        mat[esquerda.Linha, esquerda.Coluna] = true;
                    }
                    Posicao direita = new Posicao(pos.Linha, Posicao.Coluna + 1);
                    if (Tab.posicaoValida(direita) && existeInimigo(direita) && Tab.peca(direita) == partida.vulneravelEnPassant) {
                        mat[direita.Linha, direita.Coluna] = true;
                    }
                }
                
            }
            else {
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tab.posicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha + 2, Posicao.Coluna);
                if (Tab.posicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tab.posicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tab.posicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                if (Posicao.Linha == 4) {
                    Posicao esquerda = new Posicao(pos.Linha, Posicao.Coluna - 1);
                    if (Tab.posicaoValida(esquerda) && existeInimigo(esquerda) && Tab.peca(esquerda) == partida.vulneravelEnPassant) {
                        mat[esquerda.Linha, esquerda.Coluna] = true;
                    }
                    Posicao direita = new Posicao(pos.Linha, Posicao.Coluna + 1);
                    if (Tab.posicaoValida(direita) && existeInimigo(direita) && Tab.peca(direita) == partida.vulneravelEnPassant) {
                        mat[direita.Linha, direita.Coluna] = true;
                    }
                }
            }
            return mat;

        }
    }
}
