using System;
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
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.ColocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preto), new Posicao(2, 4));
                tab.ColocarPeca(new Torre(tab, Cor.Branco), new Posicao(1, 5));


                Tela.ImprimirTabuleiro(tab);
                Console.WriteLine();
                PosicaoXadrez pos = new PosicaoXadrez('a', 1);
                Console.WriteLine(pos);

                Console.WriteLine(pos.ToPosicao());
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


            
        }
    }
}
