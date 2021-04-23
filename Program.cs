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

            board.GetPieceAt(1, 0)?.Move(2,2);
            board.Draw();
        }
    }
}
