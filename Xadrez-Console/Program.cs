﻿using tabuleiro;
using xadrex;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
        }
    }
}
