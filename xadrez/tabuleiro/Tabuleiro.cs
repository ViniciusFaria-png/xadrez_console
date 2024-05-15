using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez.tabuleiro {
    internal class Tabuleiro {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro() {

        }

        public Tabuleiro(int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos) {
            return pecas[pos.Linha, pos.Coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) {
            if (existePeca(pos)) {
                throw new TabuleiroException("Ja existe uma peca nessa posicao!");
            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public Peca retirarPeca(Posicao pos) {
            if(peca(pos) == null){
                return null;
            }
            Peca aux = peca(pos);
            aux.Posicao = null;
            pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public bool existePeca(Posicao pos) {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public bool posicaoValida(Posicao pos) {
            if (pos.Linha < 0 || pos.Linha >= linhas || pos.Coluna < 0 || pos.Coluna >= colunas) {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos) {
            if (!posicaoValida(pos)) {
                throw new TabuleiroException("Posicao Inválida!");
            }
        }
    }
}
