using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez.tabuleiro;

namespace xadrez.jogoXadrez {
    internal class Dama : Peca {

        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor) { }
        public override string ToString() {
            return "D";
        }

        private bool podeMover(Posicao pos) {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != this.Cor;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[Tab.linhas, Tab.colunas];

            Posicao pos = new Posicao(0, 0);

            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor) {
                    break;
                }
                pos.definirValores(pos.Linha, pos.Coluna - 1);
            }

            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor) {
                    break;
                }
                pos.definirValores(pos.Linha, pos.Coluna + 1);
            }

            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor) {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna);
            }

            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor) {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna);
            }

            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor) {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor) {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor) {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna - 1);
            }
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor) {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna + 1);
            }
            return mat;

        }
    }
}
