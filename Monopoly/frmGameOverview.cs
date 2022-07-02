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
    public partial class frmGameOverview : Form
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


        public frmGameOverview()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void frmGameOverview_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmGameOverview_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmGameOverview_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void lblCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            frmPlayQuiz PlayQuiz = new frmPlayQuiz();
            PlayQuiz.ShowDialog();
            dgvGameOverview.DataSource = game.GetList();
        }

        private void frmGameOverview_Load(object sender, EventArgs e)
        {
            Game game = new Game();
            dgvGameOverview.AutoGenerateColumns = false;
            dgvGameOverview.DataSource = game.GetList();
        }

        private void dgvGameOverview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var column = e.ColumnIndex;
            Console.WriteLine($"Row: {row} Column: {column}");
            Game game = dgvGameOverview.CurrentRow.DataBoundItem as Game;
            //Players Button
            if(column == 2)
            {
                frmPlayerOverview frm = new frmPlayerOverview(game);
                frm.ShowDialog();
                dgvGameOverview.DataSource = game.GetList();
            }
            //Play Button
            else if(column == 3)
            {
                frmBoard board = new frmBoard(game);
                board.ShowDialog();
            }
            //Delete Button
            else if (column == 4)
            {
                if (MessageBox.Show("Weet je zeker dat je de game wil verwijderen?", "Delete vraag", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    game.Delete(game);
                    dgvGameOverview.DataSource = game.GetList();
                    MessageBox.Show("De game is verwijderd");
                }
            }
        }
    }
}
