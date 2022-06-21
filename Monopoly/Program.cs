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
            //hoi
            List<Player> list = new List<Player>();
            Player player1 = new Player(1, "Joes", "Groen");
            Player player2 = new Player(2, "Hassan", "Blauw");
            Player player3 = new Player(3, "Lotte", "Rood");
            list.Add(player1);
            list.Add(player2);
            list.Add(player3);
            Game game = new Game(0, "nieuw spel", list);

            Console.WriteLine($"De eerste speler is {game.CurrentPlayer.Name}");
            Console.WriteLine($"Er zijn {game.Board.Deck.Count()} kaarten in het deck.");

            game.HandleTurn();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< Updated upstream
            Application.Run(new frmMain());
=======
            Application.Run(new Form1());

            
>>>>>>> Stashed changes
        }

        //ERRORS ARE AVOIDED WITH ADDCLASS METHOD
    }
}
