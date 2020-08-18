using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }
        public Peca peca(int linhas, int colunas)
        {
            return Pecas[linhas, colunas];
        }
    }
}
