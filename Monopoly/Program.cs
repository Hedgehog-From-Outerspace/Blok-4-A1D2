using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Game game = new Game(0);
            Board board = new Board(0);
            Category category = new Category(0, "Test", "Een test ykno"); 
            List<Player> Players = new List<Player>();
            Players.Add(new Player(0, "Hassan"));
            Players.Add(new Player(1, "Joes"));
            Players.Add(new Player(2, "Lotte"));
            game.AddPlayers(Players);
            game.AddBoard(board);
            \
            game.AddCategory(category);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmBoard(game));
        }

        private static void PlayGame(List<Player> list)
        {
            Category category = new Category();
            Game game = new Game(0);
            bool endGame = false;
            while (endGame == false)
            {
                game.HandleTurn();
                //determine endGame
                endGame = game.CheckIfBankrupt(list);
            }
            game.DetermineWinner();
        }
    }
}
