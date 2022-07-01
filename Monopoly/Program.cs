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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmMain());
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
