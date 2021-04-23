using System;

namespace Chess
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Board: \n");

            Board board = new();

            board.StartBoard();
            board.Draw();
        }
    }
}
