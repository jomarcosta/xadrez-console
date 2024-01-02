using tabuleiro;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Console.WriteLine("Teste de instaciação do Tabuleiro.");
            Console.ReadLine();
        }
    }
}
