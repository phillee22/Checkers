using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersLib
{
    internal class CommandParser
    {
        internal static CheckerCommand Parse(string CmdText)
        {
            CheckerCommand ret = null;

            string[] segments = CmdText.Split(' ');
            switch (segments[0].ToLower())
            {
                case "m":
                case "move":
                    if (segments.Length > 3)
                    {
                        throw new Exception("Invalid command structure...");
                    }
                    else if (IsValidSquare(segments))
                    {
                        ret = new CheckerCommand(CommandType.Move, segments[1], segments[2]);
                    }
                    break;

                case "j":
                case "jump":
                    if (segments.Length > 3)
                    {
                        throw new Exception("Invalid command structure...");
                    }
                    if (IsValidSquare(segments))
                    {
                        ret = new CheckerCommand(CommandType.Jump, segments[1], segments[2]);
                    }
                    break;

                case "q":
                case "quit":
                    ret = new CheckerCommand(CommandType.Quit, string.Empty, string.Empty);
                    break;

                default:
                    throw new Exception("Unknown command (" + segments[0] + ")");
            }
            return ret;
        }

        static bool IsValidSquare(string[] CmdText)
        {
            // BUG - probably could make this much easier (and better) with a RE...

            char[] validchars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'};
            char[] validnums = { '0', '1', '2', '3', '4', '5', '6', '7' };

            if ( (CmdText[1].Length != 2) || 
                 !(CmdText[1].ToLower().IndexOfAny(validchars) == 0) ||
                 !(CmdText[1].ToLower().IndexOfAny(validnums) == 1) )
            {
                throw new Exception("Invalid square specification (" + CmdText[1] + ")");
            }

            if ((CmdText[2].Length != 2) ||
                !(CmdText[2].ToLower().IndexOfAny(validchars) == 0) ||
                !(CmdText[2].ToLower().IndexOfAny(validnums) == 1) )
            {
                throw new Exception("Invalid square specification (" + CmdText[2] + ")");
            }

            return true;
        }
    }
}
