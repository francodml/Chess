using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public static class Movetypes
    {
        //TODO: Add move types
        public static Action<bool> GetMoveType(PieceType pieceType)
        {
            throw new NotImplementedException();
        }
    }
    public enum PieceType
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
        Queen,
        King
    }
}
