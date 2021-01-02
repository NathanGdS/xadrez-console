using System;
using tabuleiro;
namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            this.Tab = new Tabuleiro(8, 8);
            this.Turno = 1;
            this.JogadorAtual = Cor.White;
            this.Terminada = false;
            colocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQntDeMovimentos();
            Tab.RetirarPeca(destino);
            Peca PecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);

        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            this.Turno++;
            MudaJogador();
        }

        public void ValidarPosicaoDeOrigem(Posicao pos)
        {
            if (Tab.peca(pos) == null) {
                throw new TabuleiroException("Nao existe uma peca nesta posicao!");
            }

            if (JogadorAtual != Tab.peca(pos).Cor) {
                throw new TabuleiroException("A peca de origem escolhida nao e sua!");
            }

            if (!Tab.peca(pos).ExisteMovimentosPossiveis()) {
                throw new TabuleiroException("Nao existem movimentos possiveis para esta peca de origem!");
            }

        }

        private void MudaJogador()
        {
            if (this.JogadorAtual == Cor.White) {
                this.JogadorAtual = Cor.Black;
            } else {
                this.JogadorAtual = Cor.White;
            }
        }

        private void colocarPecas()
        {
            this.Tab.ColocarPeca(new Rei(Cor.White, this.Tab), new PosicaoXadrez('c', 1).ToPosicao());
            this.Tab.ColocarPeca(new Torre(Cor.White, this.Tab), new PosicaoXadrez('c', 2).ToPosicao());
            this.Tab.ColocarPeca(new Torre(Cor.White, this.Tab), new PosicaoXadrez('b', 1).ToPosicao());
            this.Tab.ColocarPeca(new Torre(Cor.White, this.Tab), new PosicaoXadrez('b', 2).ToPosicao());
            this.Tab.ColocarPeca(new Torre(Cor.White, this.Tab), new PosicaoXadrez('d', 1).ToPosicao());
            this.Tab.ColocarPeca(new Torre(Cor.White, this.Tab), new PosicaoXadrez('d', 2).ToPosicao());

            this.Tab.ColocarPeca(new Rei(Cor.Black, this.Tab), new PosicaoXadrez('c', 8).ToPosicao());
        }

    }
}
