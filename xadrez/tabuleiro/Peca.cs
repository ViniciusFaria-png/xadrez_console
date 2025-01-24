﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez.tabuleiro {
    abstract class Peca {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QteMovimentos = 0;
        }
        
        public void incrementarQteMovimentos() {
            QteMovimentos++;
        }

        public void decrementarQteMovimentos() {
            QteMovimentos--;
        }

        public bool existeMovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i<Tab.linhas; i++) {
                for(int j = 0; j < Tab.colunas; j++) {
                    if (mat[i, j]) {
                        return true;
                    }

                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos) {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }
        public abstract bool[,] movimentosPossiveis();
    }
}
