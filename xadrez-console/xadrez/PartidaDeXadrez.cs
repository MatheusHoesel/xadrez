using System;
using System.Collections.Generic;
using System.Text;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branco;
            Terminada = false;
            ColocarPecas();
        }
        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQtdMovimentos();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
            
        }
        public void RealizaJodada(Posicao origem, Posicao destino)
        {
            ExecutarMovimento(origem, destino);
            Turno++;
            Mudajogador();
        }
        public void ValidarPosicaoDeOrigem(Posicao pos)
        {
            if(Tab.peca(pos)== null){
                throw new TabuleiroException("Não existe peça na posição de origem escolhida");
            }
            if(JogadorAtual != Tab.peca(pos).Cor){
                throw new TabuleiroException("A peça de origem não é sua");
            }
            if (!Tab.peca(pos).ExisteMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimntos possiveis para a peça de origem escolhida");
            }
        }
        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!Tab.peca(origem).PodeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida");
            }
        }
        private void Mudajogador()
        {
            if(JogadorAtual == Cor.Branco)
            {
                JogadorAtual = Cor.Preto;
            }
            else
            {
                JogadorAtual = Cor.Branco;
            }

        }
        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Tab, Cor.Branco), new PosicaoXadrez('c', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preto), new PosicaoXadrez('c', 8).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Branco), new PosicaoXadrez('d', 1).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Preto), new PosicaoXadrez('d', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branco), new PosicaoXadrez('b', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branco), new PosicaoXadrez('e', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branco), new PosicaoXadrez('d', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branco), new PosicaoXadrez('c', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branco), new PosicaoXadrez('e', 2).ToPosicao());



        }
    }
}
