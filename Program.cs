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
            pawn = new Piece();
            king = new Piece(PieceType.King);
            whiteKing = new Piece(PieceType.King, true);

            PrintPieces();

            bool a = pawn.Move(1, 0);
            bool b = king.Move(5, 3);
            bool c = whiteKing.Move(2, 9);

            Console.WriteLine($"{a} {b} {c}");
            PrintPieces();

            Console.WriteLine("Board: \n");

            Board board = new();

            board.StartBoard();
            board.Draw();
        }

        static void PrintPieces()
        {
            Console.WriteLine($"{pawn}\n{king}\n{whiteKing}");
        }
    }
}
