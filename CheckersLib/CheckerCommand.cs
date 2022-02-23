using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersLib
{
    internal class CheckerCommand
    {
        internal CheckerCommand(CommandType Type, string From, string To)
        {
            this.Type = Type;
            this.From = From;
            this.To = To;
        }

        public readonly string From;
        public readonly string To;
        public readonly CommandType Type;
    }
}
