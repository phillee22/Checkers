using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersLib
{
    public class GameOfCheckers
    {

        GameManager _mgr;

        public GameOfCheckers()
        {
            // all we need is a game manager.
            _mgr = new GameManager();
        }

        public bool ExecuteCommand(string CommandText)
        {
           return _mgr.ExecuteCommand(CommandText);
        }

        public Player GetNextPlayer()
        {
            return _mgr.GetNextPlayer();
        }

        public GameBoard InitializeBoard()
        {
            return _mgr.InitializeBoard();
        }

        public void RegisterPlayers(string Player1Name, string Player2Name)
        {
            // need two players
            _mgr.RegisterPlayers(Player1Name, Player2Name);
        }
    }
}
