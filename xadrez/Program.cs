using System;
using System.Globalization;
using xadrez.tabuleiro;
using xadrez.jogoXadrez;

namespace xadrez {
    class Program {
        static void Main(string[] args) {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 1));
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 2));
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(5, 2));

            Tela.ImprimirTabuleiro(tab);


            Console.ReadLine();
        }
    }
}