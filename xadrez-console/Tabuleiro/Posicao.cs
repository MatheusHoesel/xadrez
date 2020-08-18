using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace xadrez_console.tabuleiro
{
    class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return "Linha: " + Linha
                + ", Coluna: " + Coluna;
        }
    }
}
