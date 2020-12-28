using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);


            tab.ColocarPeca(new Rei(Cor.Black, tab), new Posicao(0, 4));
            tab.ColocarPeca(new Rainha(Cor.Black, tab), new Posicao(0, 3));

            tab.ColocarPeca(new Torre(Cor.Black, tab), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(Cor.Black, tab), new Posicao(0, 7));

            tab.ColocarPeca(new Bispo(Cor.Black, tab), new Posicao(0, 1));
            tab.ColocarPeca(new Bispo(Cor.Black, tab), new Posicao(0, 6));

            tab.ColocarPeca(new Cavalo(Cor.Black, tab), new Posicao(0, 2));
            tab.ColocarPeca(new Cavalo(Cor.Black, tab), new Posicao(0, 5));

            for (int i = 0; i < tab.Colunas; i++) {
                tab.ColocarPeca(new Peao(Cor.Black, tab), new Posicao(1, i));
                tab.ColocarPeca(new Peao(Cor.White, tab), new Posicao(6, i));
            }

            Tela.imprimirTabuleiro(tab);



            Console.ReadLine();
        }
    }
}
