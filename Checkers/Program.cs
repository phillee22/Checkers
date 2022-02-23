using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Program
    {
        static CheckersLib.GameOfCheckers game;
        static GameBoardUI _bui;

        static void Main(string[] args)
        {

            InitializeGame();
            PlayGame();

        }

        static void GetPlayers()
        {
            Console.WriteLine();
            Console.Write("What's the name of Player 1? >> ");
            string p1name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What's the name of Player 2? >> ");
            string p2name = Console.ReadLine();

            game.RegisterPlayers(p1name, p2name);

        }

        static void InitializeGame()
        {
            // intro to the user...
            IntroductionUI();

            // create the game on the backend...
            game = new CheckersLib.GameOfCheckers();
            GetPlayers();

            // initialize the board on the backend and create the board's frontend...
            CheckersLib.GameBoard b = game.InitializeBoard();
            _bui = new GameBoardUI(b);

            Console.WriteLine();
            Console.WriteLine("The board is set and ready:");
            _bui.Print();
        }

        static void IntroductionUI()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Checkers!!  First let's get the names of the players...");

            // BUG - probably should say something about the available commands...

        }

        static void PlayGame()
        {
            bool quit = false;

            Console.WriteLine();
            Console.WriteLine("Lets play the game.  ");
            do
            {
                Console.WriteLine();
                Console.Write(game.GetNextPlayer().Name + " its your turn.  Enter a command to make your move:  >> ");
                string cmd = Console.ReadLine();

                // what about command text that's related to the execution of the game?  Ex:  help with
                // commands - what can I put?  we need to parse for a few command texts to enable this
                // functionality.  Or, the game object needs to return something useful that we can output to the user...

                try
                {
                    quit = game.ExecuteCommand(cmd);
                }
                catch (Exception e)
                {
                    Console.WriteLine(" !!! Uh oh :: " + e.Message);
                }

                _bui.Print();

            } while (!quit);

            Console.WriteLine("Bye bye now...");
        }
    }
}
