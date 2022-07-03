using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class frmBoard : Form
    {
        public Game game;
        private int ticks;
        public frmBoard(Game _Game)
        {
            game = _Game;
            InitializeComponent();
            game.Initialize();
        }

        private void frmBoard_Load(object sender, EventArgs e)
        {
            //Dit kan veel beter, maar nu lazy manier
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
            game.Initialize();
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HandleTurn(Game game)
        {
            //Is dit te veel logica voor de UI?

            game.Turn += 1;
            txtbConsole.Text = $"Het is beurt {game.Turn}.";
            txtbConsole.Text += $"\r\n{game.CurrentPlayer.Name} is de huidige speler.";

            game.MovePlayer();
            txtbConsole.Text += $"\r\n{game.CurrentPlayer.Name} heeft de dobbelsteen gerold.";
            txtbConsole.Text += $"\r\n{game.CurrentPlayer.Name} staat op vakje {game.Board.Plots.IndexOf(game.CurrentPlayer.OccupiedPlot) + 1}.";

            if (game.CurrentPlayer.OccupiedPlot.PlotType.Contains("House"))
            {
                game.EncounterHouse();                                                      
                txtbConsole.Text += $"\r\nJe bent op een huis terecht gekomen.";
            }
            else if (game.CurrentPlayer.OccupiedPlot.PlotType.Contains("Card"))
            {
                Card card = game.EncounterCard();                                           
                txtbConsole.Text += $"\r\nJe hebt een kaart geraapt.";
                txtbConsole.Text += $"\r\n{card.CardText}.";

            }
            else if (game.CurrentPlayer.OccupiedPlot.PlotType.Contains("Jail"))
            {
                game.EncounterJail();                                                       
                txtbConsole.Text += $"\r\nJe bent in de gevangenis terecht gekomen.";
            }

            if (game.CheckIfBankrupt(game.Players))
            {
                game.DetermineWinner();
            }
            game.GetNextPlayer();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            HandleTurn(game);
            btnStartGame.Text = "Verder";

        }
    }
}
