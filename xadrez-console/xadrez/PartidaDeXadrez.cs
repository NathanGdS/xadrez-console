using System;
using tabuleiro;
namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno { get; set; }
        private Cor JogadorAtual { get; set; }
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            this.Tab = new Tabuleiro(8,8);
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

        private void colocarPecas()
        {
            this.Tab.ColocarPeca(new Rei(Cor.White, this.Tab), new PosicaoXadrez('c',1).ToPosicao());
            this.Tab.ColocarPeca(new Torre(Cor.White, this.Tab), new PosicaoXadrez('c', 2).ToPosicao());

            this.Tab.ColocarPeca(new Rei(Cor.Black, this.Tab), new PosicaoXadrez('c', 8).ToPosicao());
        }

    }
}
