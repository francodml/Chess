using System;
using System.Collections.Generic;
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
                for (int i = 0; i < 8; i++)
                {
                    Piece piece = new((PieceType)pattern[i], iter > 0);
                    piece.Position = new Vector2(iter > 0 ? 7 : 0, i);
                    pieces.Add(piece);
                }
                iter++;
            }
            while (iter < 2);
        }

        public Piece GetPieceAt(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            foreach (Piece p in pieces)
            {
                Console.WriteLine(p);
            }
        }

    }
}
