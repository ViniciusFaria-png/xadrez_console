using System;
using System.Globalization;
using xadrez.tabuleiro;
using xadrez.jogoXadrez;

namespace xadrez {
    class Program {
        static void Main(string[] args) {
            PartidaXadrez partida = new PartidaXadrez();

            while (!partida.terminada) {
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.tab);

                Console.WriteLine();
                Console.Write("Origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                Console.Write("Destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                partida.executaMovimento(origem, destino);

            }


            Console.ReadLine();
        }
    }
}