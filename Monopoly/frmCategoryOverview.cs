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
    public partial class frmCategoryOverview : Form
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

        public frmCategoryOverview()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void frmCategoryOverview_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmCategoryOverview_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmCategoryOverview_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void lblCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCategoryOverview_Load(object sender, EventArgs e)
        {
            Category category = new Category();
            dgvCategories.AutoGenerateColumns = false;
            dgvCategories.DataSource = category.GetList();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category(0, txtbCategoryName.Text, "");
            category.Create(category);
            dgvCategories.DataSource = category.GetList();
            MessageBox.Show("Category Added!");
            txtbCategoryName.Text = string.Empty;
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var column = e.ColumnIndex;

            //Edit Button

            //Add Question Button
            if (column == 2)
            {
                var category = dgvCategories.CurrentRow.DataBoundItem as Category;
                frmQuestionOverview frm = new frmQuestionOverview(category);
                frm.ShowDialog();
            }
            //Delete Button
            else if (column == 3)
            {
                if (MessageBox.Show("Weet je zeker dat je de category wil verwijderen?", "Delete Category", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var category = dgvCategories.CurrentRow.DataBoundItem as Category;
                    category.Delete(category);
                    dgvCategories.DataSource = category.GetList();
                    MessageBox.Show("Category is verwijderd");
                }
            }
        }
    }
}
