using System;

namespace Chess
{
    class Program
    {
        static Piece pawn;
        static Piece king;
        static Piece whiteKing;
        static void Main()
        {
            Console.WriteLine("Board: \n");

            Board board = new();

            board.StartBoard();
            board.Draw();
        }
    }
}
