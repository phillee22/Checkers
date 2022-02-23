using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersLib
{
    public class BoardSquare
    {
        CheckerPiece _piece = null;

        internal void SetPiece(CheckerPiece Piece)
        {
            // BUG - should we check if _piece is null before setting to an actual piece?
            //     Piece could be validly null if the player moves a piece out of is square...

            _piece = Piece;
        }

        public CheckerPiece Piece
        {
            get { return _piece; }
        }
    }
}
