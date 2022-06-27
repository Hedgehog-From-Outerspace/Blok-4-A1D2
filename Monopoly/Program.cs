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
            List<Player> list = new List<Player>();
            list.Add(new Player(1, "Joes", "Groen"));
            list.Add(new Player(2, "Hassan", "Rood"));
            list.Add(new Player(3, "Lotte", "Geel"));

            //test main while loop
            PlayGame(list);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmMain());
        }

        private static void PlayGame(List<Player> list)
        {
            Category category = new Category();
            Game game = new Game(0, list, category);
            bool endGame = false;
            while (endGame == false)
            {
                game.HandleTurn();
                //determine endGame
                endGame = game.CheckIfBankrupt(list);
            }
            game.DetermineWinner();
        }

        //ERRORS ARE AVOIDED WITH ADDCLASS METHOD
    }
}
