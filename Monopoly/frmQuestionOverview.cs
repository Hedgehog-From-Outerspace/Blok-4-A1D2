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
    public partial class frmQuestionOverview : Form
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

        private Category category;
        private Question question;

        public frmQuestionOverview(Category _category)
        {
            category = _category;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmQuestionOverview_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmQuestionOverview_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmQuestionOverview_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void frmQuestionOverview_Load(object sender, EventArgs e)
        {
            Question question = new Question();
            lblSelectedCategory.Text = category.Name.ToString();
            dgvQuestions.AutoGenerateColumns = false;
            dgvQuestions.DataSource = question.GetList(category);

        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            Question question = new Question(0, txtbQuestionName.Text, txtbQuestionAnswer.Text);
            question.AddCategory(category);
            question.Create(question);
            dgvQuestions.DataSource = question.GetList(category);
            txtbQuestionName.Text = txtbQuestionAnswer.Text = string.Empty;
            MessageBox.Show("Vraag aangemaakt!");
        }

        private void dgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var column = e.ColumnIndex;
            Console.WriteLine($"Row: {row} Column: {column}");

            question = dgvQuestions.CurrentRow.DataBoundItem as Question;
            txtbQuestionName.Text = question.QuestionText;
            txtbQuestionAnswer.Text = question.Answer;

            //Delete Button
            if (column == 2)
            {
                if (MessageBox.Show("Weet je zeker dat je de vraag wil verwijderen?", "Delete vraag", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    question.Delete(question);
                    dgvQuestions.DataSource = question.GetList(category);
                    MessageBox.Show("De vraag is verwijderd");
                }
            }
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            //How to try catch this, if you delete the prev edited question. The question in question will be null.
            question = dgvQuestions.CurrentRow.DataBoundItem as Question;
            question.Edit(txtbQuestionName.Text, txtbQuestionAnswer.Text);
            question.Update(question);
            dgvQuestions.DataSource = question.GetList(category);
            txtbQuestionName.Text = txtbQuestionAnswer.Text = string.Empty;
            MessageBox.Show("Vraag bewerkt!");
        }
    }
}
