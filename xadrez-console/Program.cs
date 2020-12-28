using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Black, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Rei(Cor.White, tab), new Posicao(7, 4));
                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) {

                Console.WriteLine(e.Message);
            }
               
            Console.ReadLine();

        }
    }
}
