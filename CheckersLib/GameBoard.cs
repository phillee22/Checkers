using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersLib
{
    public class GameBoard
    {
        protected BoardSquare[,] _squares;
        public const int MAX_ROW = 8;
        public const int MAX_COL = 8;

        internal GameBoard()
        {
            _squares = new BoardSquare[MAX_ROW,MAX_COL];
            for(int i = 0; i < MAX_ROW; i++)
            {
                for (int j = 0; j < MAX_COL; j++)
                {
                    _squares[i, j] = new BoardSquare();
                }
            }
        }

        public BoardSquare[,] Squares
        {
            get { return _squares; }
        }
    }
}
