using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez.tabuleiro;

namespace xadrez.jogoXadrez {
    internal class Peao : Peca {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor) { }
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
            }
            return mat;

        }
    }
}
