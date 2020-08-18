using System;
using System.Collections.Generic;
using System.Text;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro (Tabuleiro tab)
        {
            for(int i= 0; i<tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for(int j= 0; j<tab.Colunas; j++)
                {
                    if(tab.peca(i, j)== null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Tela.ImpimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("  a b c d e f g h");

        }
        public static void ImpimirPeca(Peca peca)
        {
            if(peca.Cor == Cor.Branco)
            {
                Console.Write(peca);

            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
