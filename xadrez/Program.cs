using System;
using System.Globalization;
using xadrez.tabuleiro;

namespace xadrez {
    class Program {
        static void Main(string[] args) {
            Posicao P = new Posicao(3, 4);

            Console.WriteLine("Posicao: " + P);
            Console.ReadLine();
        }
    }
}