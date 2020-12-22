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

            tab.ColocarPeca(new Torre(Cor.Black, tab), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(Cor.Black, tab), new Posicao(0, 7));
            tab.ColocarPeca(new Rei(Cor.Black, tab), new Posicao(0, 4));

            Tela.imprimirTabuleiro(tab);



            Console.ReadLine();
        }
    }
}
