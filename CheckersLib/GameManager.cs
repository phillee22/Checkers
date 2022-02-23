using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersLib
{
    internal class GameManager
    {
        Player _p1;
        Player _p2;

        Player _next;

        GameBoard _b;

        internal GameManager()
        {
            // need a board
            _b = new GameBoard();
        }

        internal bool ExecuteCommand(string CommandText)
        {
            bool ret = false;

            CheckerCommand cmd = CommandParser.Parse(CommandText);
            if (ValidCommand(cmd))
            {
                if (cmd.Type == CommandType.Move)
                {
                    MovePiece(cmd);
                }
                else if (cmd.Type == CommandType.Jump)
                {
                    JumpPiece(cmd);
                }
                else if (cmd.Type == CommandType.Quit)
                {
                    // do whatever to quit the game...
                    ret = true;
                }

                SetNextPlayer();

            }
            else
            {
                throw new Exception("Invalid command:  you can't make that move...");
            }

            return ret;
        }

        internal Player GetNextPlayer()
        {
            return _next;
        }

        internal GameBoard InitializeBoard()
        {
            _b = new GameBoard();
            return _b;
        }

        void JumpPiece(CheckerCommand cmd)
        {
            throw new NotImplementedException("Can't jump yet...");
        }

        void MovePiece(CheckerCommand cmd)
        {
            //throw new NotImplementedException("Can't move yet...");
        }

        void SetNextPlayer()
        {
            // when the command executes, the expectation is that _next is pointing to the
            // player whose command is being executed.  then, after successful execution of
            // the command, this funtion is called set the next player...
            if (_next.Name == _p1.Name)
            {
                _next = _p2;
            }
            else
            {
                _next = _p1;
            }
        }

        internal void RegisterPlayers(string Player1Name, string Player2Name)
        {
            _p1 = new Player(Player1Name, CheckerColor.Red);
            _p2 = new Player(Player2Name, CheckerColor.Black);
            _next = _p1;
        }

        bool ValidCommand(CheckerCommand cmd)
        {
            // BUG - figure this out...
            bool ret = true;
            return ret;
        }
    }
}
