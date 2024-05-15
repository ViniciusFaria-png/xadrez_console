using System;
using System.Globalization;
using xadrez.jogoXadrez;
using xadrez.tabuleiro;

namespace xadrez {
    class Program {
        static void Main(string[] args) {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());


            Console.ReadLine();
        }
    }
}