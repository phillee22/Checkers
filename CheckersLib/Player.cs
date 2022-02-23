using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersLib
{
    public class Player
    {
        string _name;
        CheckerColor _color;
        internal List<CheckerPiece> _pieces;

        public Player(string Name, CheckerColor Color)
        {
            _name = Name;
            _color = Color;
            _pieces = new List<CheckerPiece>();
            for(int i = 0; i < 12; i++)
            {
                _pieces.Add(new CheckerPiece(_color));
            }
        }

        public CheckerColor Color
        { get { return _color;  } }

        public string Name
        { get { return _name; } }


    }
}
