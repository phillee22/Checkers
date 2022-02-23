using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersLib
{
    public class CheckerPiece
    {
        CheckerColor _color;
        PieceType _type = PieceType.Regular;

        internal CheckerPiece(CheckerColor Color)
        {
            _color = Color;
        }

        public CheckerColor Color
        {
            get { return _color;  }
        }

        public PieceType Type
        {
            get { return _type; }
        }
    }
}
