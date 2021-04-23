using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Chess
{
    class Board
    {
        const int size = 8;
        List<Piece> pieces;

        public Board()
        {
            pieces = new();
        }

        public void StartBoard()
        {
            int[] pattern = { 1, 2, 3, 4, 5, 3, 2, 1 };
            int iter = 0;
            do
            {
                for (int i = 0; i < size; i++)
                {
                    Piece piece = new((PieceType)pattern[i], iter > 0);
                    piece.Position = new Vector2(i,iter > 0 ? 7 : 0);
                    pieces.Add(piece);
                    Piece pawn = new(PieceType.Pawn, iter > 0);
                    pawn.Position = new Vector2(i, iter > 0 ? 6 : 1);
                    pieces.Add(pawn);
                }
                iter++;
            }
            while (iter < 2);
        }

        public Piece GetPieceAt(int x, int y)
        {
            Vector2 pos = new(x, y);
            return pieces.FirstOrDefault(x => x.Position == pos);
        }

        public void Draw()
        {
            int spaces = (int)Math.Pow(size, 2);
            int row = 0;
            for (int i = 0; i < spaces; i++)
            {
                if (i % size == 0 && i > 7)
                {
                    row++;
                    Console.Write("\n");
                }
                var piece = GetPieceAt(i % size, row);
                if (piece == null)
                {
                    Console.Write(" ");
                    continue;
                }

                Console.Write(GetPieceAt(i % size, row).GetRenderChar()+" ");
            }
        }

    }
}
