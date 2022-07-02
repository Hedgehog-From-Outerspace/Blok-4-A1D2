using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class frmPlayerOverview : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        private Game game;
        private Player player;

        public frmPlayerOverview(Game game)
        {
            this.game = game;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void lblCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmPlayerOverview_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }
        private void frmPlayerOverview_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void frmPlayerOverview_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void frmPlayerOverview_Load(object sender, EventArgs e)
        {
            Player player = new Player();
            dgvPlayers.AutoGenerateColumns = false;
            dgvPlayers.DataSource = player.GetGamePlayerList(game);
            lblChosenGame.Text = game.Name;
        }

        private void dgvPlayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var column = e.ColumnIndex;
            Console.WriteLine($"Row: {row} Column: {column}");
            Player player = dgvPlayers.CurrentRow.DataBoundItem as Player;

            txtbPlayerName.Text = player.Name;

            //Delete Button
            if (column == 1)
            {
                if (MessageBox.Show("Weet je zeker dat je de speler wil verwijderen?", "Delete speler", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    player.Delete(game);
                    dgvPlayers.DataSource = player.GetGamePlayerList(game);
                    MessageBox.Show("De speler is verwijderd!");
                    txtbPlayerName.Text = string.Empty;
                }
            }
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            Player player = new Player(0, txtbPlayerName.Text);
            player.Create(game);
            dgvPlayers.DataSource = player.GetGamePlayerList(game);
            MessageBox.Show("De speler is aangemaakt!");
            txtbPlayerName.Text = string.Empty;
        }

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            Player player = dgvPlayers.CurrentRow.DataBoundItem as Player;
            player.Edit(player.Id, txtbPlayerName.Text);
            player.Update();
            dgvPlayers.DataSource = player.GetGamePlayerList(game);
            MessageBox.Show("De speler is aangepast!");
            txtbPlayerName.Text = string.Empty;
        }
    }
}
