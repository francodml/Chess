using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Chess
{
    public class Piece
    {
        static readonly string[] RenderChars = { "P", "R", "H", "B", "Q", "K" };
        public PieceType Type { get; init; }
        public bool Colour { get; init; } // 0 = Black, 1 = White, because I can't care enough to make an enum for this.
        public Vector2 Position { get; set; } = new Vector2(0, 0);

        public Piece()
        {
            Type = PieceType.Pawn;
            Colour = false;
        }

        public Piece(PieceType pieceType)
        {
            Type = pieceType;
            Colour = false;
        }

        public Piece(PieceType pieceType, bool pieceColour)
        {
            Type = pieceType;
            Colour = pieceColour;
        }

        public string GetRenderChar()
        {
            return RenderChars[(int)Type];
        }

        public string GetColour()
        {
            return Colour ? "White" : "Black";
        }

        public bool Move(int x, int y)
        {
            Console.WriteLine($"Attempting to move {this} to {x},{y}");
            if (x > 8 | y > 8)
                return false;
            Position = new Vector2(x, y);
            return true;
        }

        public override string ToString()
        {
            return $"{GetColour()} {Type} (X:{Position.X}, Y:{Position.Y})";
        }

    }
}
