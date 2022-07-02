using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class frmBoard : Form
    {
        public Game game;
        public frmBoard(Game _Game)
        {
            game = _Game;
            InitializeComponent();
        }

        private void frmBoard_Load(object sender, EventArgs e)
        {
            txtbConsole.ReadOnly = true;
            txtbConsole.Text = "Test\r\nDit is een test!";

            if (game.Players.Count == 2)
            {
                lblPlayer1.Text = game.Players[0].Name;
                labelP1Money.Text = game.Players[0].Money.ToString();
                lblPlayer2.Text = game.Players[1].Name;
                labelP2Money.Text = game.Players[1].Money.ToString();

            }
            else if (game.Players.Count == 3)
            {
                lblPlayer1.Text = game.Players[0].Name;
                labelP1Money.Text = game.Players[0].Money.ToString();
                lblPlayer2.Text = game.Players[1].Name;
                labelP2Money.Text = game.Players[1].Money.ToString();
                lblPlayer3.Text = game.Players[2].Name;
                labelP3Money.Text = game.Players[2].Money.ToString();
            }
            else if (game.Players.Count == 4)
            {
                lblPlayer1.Text = game.Players[0].Name;
                labelP1Money.Text = game.Players[0].Money.ToString();
                lblPlayer2.Text = game.Players[1].Name;
                labelP2Money.Text = game.Players[1].Money.ToString();
                lblPlayer3.Text = game.Players[2].Name;
                labelP3Money.Text = game.Players[2].Money.ToString();
                lblPlayer4.Text = game.Players[3].Name;
                labelP4Money.Text = game.Players[3].Money.ToString();
            }
            else
            {
                MessageBox.Show("Je hebt een ongeldig aantal spelers!");
                this.Close();
            }
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
