using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class GameBoardUI
    {
        CheckersLib.GameBoard _gb;
        const int MAX_ROW = 8;
        const int MAX_COL = 8;

        public GameBoardUI(CheckersLib.GameBoard gameBoard)
        {
            _gb = gameBoard;
        }

        ConsoleColor ColorConverter(CheckersLib.CheckerColor checkerColor)
        {
            ConsoleColor ret = ConsoleColor.Gray;

            if (checkerColor == CheckersLib.CheckerColor.Red)
            {
                ret = ConsoleColor.Red;
            }

            return ret;
        }

        public void Print()
        {
            Console.WriteLine();
            ConsoleColor currentFG = Console.ForegroundColor;

            // Print the top row's top edge.
            Console.WriteLine("    _______________________________________");

            // Print all the values of each row's squares - starting with the index of row.
            for (int y = (MAX_ROW - 1); y >= 0; y--)
            {
                Console.Write(" {0} ", y);
                for (int x = 0; x < MAX_COL; x++)
                {
                    Console.Write("|");
                    Console.Write("_");
                    if (_gb.Squares[x, y].Piece == null)
                    {
                        Console.Write("___");
                    }
                    else
                    {
                        Console.Write("_");
                        Console.ForegroundColor = ColorConverter(_gb.Squares[x, y].Piece.Color);
                        Console.Write("X");
                        Console.ForegroundColor = currentFG;
                        Console.Write("_");
                    }
                }
                Console.WriteLine("|");
            }

            // Print the indices of the columns.
            Console.Write("    ");  // add a little left margin...
            for (int x = 0; x < MAX_COL; x++)
            {
                Console.Write("  {0}  ", x);
            }
            Console.WriteLine();
        }
    }
}
