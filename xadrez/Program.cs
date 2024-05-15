using System;
using System.Globalization;
using xadrez.tabuleiro;
using xadrez.jogoXadrez;

namespace xadrez {
    class Program {
        static void Main(string[] args) {
            PartidaXadrez partida = new PartidaXadrez();

            

            Tela.ImprimirTabuleiro(partida.tab);


            Console.ReadLine();
        }
    }
}