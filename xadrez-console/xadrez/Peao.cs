using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        public Peao(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != this.Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(pos.Linha - 1, pos.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //nordeste
            pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //direita
            pos.DefinirValores(pos.Linha, pos.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudeste
            pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo
            pos.DefinirValores(pos.Linha + 1, pos.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudoeste
            pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //esquerda
            pos.DefinirValores(pos.Linha, pos.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //noroeste
            pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }
        public override string ToString()
        {
            return "P";
        }
    }
}
