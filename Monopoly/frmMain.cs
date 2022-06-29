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
    public partial class frmMain : Form
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

        public frmMain()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void btnManageQuestions_Click(object sender, EventArgs e)
        {
            frmCategoryOverview CategoryOverview = new frmCategoryOverview();
            CategoryOverview.ShowDialog();
        }
        private void btnPlayQuiz_Click(object sender, EventArgs e)
        {
            frmPlayQuiz PlayQuiz = new frmPlayQuiz();
            PlayQuiz.ShowDialog();
        }
        private void btnManageGames_Click(object sender, EventArgs e)
        {
            frmGameOverview GameOverview = new frmGameOverview();
            GameOverview.ShowDialog();
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
