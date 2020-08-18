using System;
using System.Data;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez Partida = new PartidaDeXadrez();
                
                while (!Partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(Partida.Tab);

                    Console.WriteLine();
                    Console.WriteLine("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.WriteLine("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                    Partida.ExecutarMovimento(origem, destino);

                }
                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


            
        }
    }
}
