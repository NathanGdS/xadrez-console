namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            this.Pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return this.Pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return this.Pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return this.peca(pos) != null;
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos)) {
                throw new TabuleiroException("Ja existe uma peca nesta posicao!");
            } else {
                Pecas[pos.Linha, pos.Coluna] = p;
                p.Posicao = pos;
            }
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if(peca(pos) == null) {
                return null;
            } else {
                Peca aux = peca(pos);
                aux.Posicao = null;
                Pecas[pos.Linha, pos.Coluna] = null;
                return aux;
            }
        }

        public bool PosicaoValida(Posicao pos)
        {
            if(pos.Linha <0 || pos.Linha >= this.Linhas || pos.Coluna<0 || pos.Coluna >= this.Colunas) {
                return false;
            } else {
                return true;
            }
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos)) {
                throw new TabuleiroException("Posicao Invalida!");
            }
        }
    }
}
