
namespace Monopoly
{
    partial class frmQuestionOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSelectedCategory = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.lblQuestionName = new System.Windows.Forms.Label();
            this.lblQuestionAnswer = new System.Windows.Forms.Label();
            this.txtbQuestionName = new System.Windows.Forms.TextBox();
            this.txtbQuestionAnswer = new System.Windows.Forms.TextBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.QuestionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectedCategory
            // 
            this.lblSelectedCategory.AutoSize = true;
            this.lblSelectedCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCategory.Location = new System.Drawing.Point(122, 5);
            this.lblSelectedCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedCategory.Name = "lblSelectedCategory";
            this.lblSelectedCategory.Size = new System.Drawing.Size(186, 17);
            this.lblSelectedCategory.TabIndex = 0;
            this.lblSelectedCategory.Text = "**CHOSEN CATEGORY**\r\n";
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionText,
            this.Answer,
            this.Edit,
            this.Delete});
            this.dgvQuestions.Location = new System.Drawing.Point(20, 23);
            this.dgvQuestions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersVisible = false;
            this.dgvQuestions.RowHeadersWidth = 82;
            this.dgvQuestions.RowTemplate.Height = 33;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(385, 116);
            this.dgvQuestions.TabIndex = 1;
            this.dgvQuestions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestions_CellContentClick);
            // 
            // lblQuestionName
            // 
            this.lblQuestionName.AutoSize = true;
            this.lblQuestionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionName.Location = new System.Drawing.Point(18, 140);
            this.lblQuestionName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestionName.Name = "lblQuestionName";
            this.lblQuestionName.Size = new System.Drawing.Size(114, 17);
            this.lblQuestionName.TabIndex = 2;
            this.lblQuestionName.Text = "Question Text:";
            // 
            // lblQuestionAnswer
            // 
            this.lblQuestionAnswer.AutoSize = true;
            this.lblQuestionAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionAnswer.Location = new System.Drawing.Point(164, 140);
            this.lblQuestionAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestionAnswer.Name = "lblQuestionAnswer";
            this.lblQuestionAnswer.Size = new System.Drawing.Size(135, 17);
            this.lblQuestionAnswer.TabIndex = 3;
            this.lblQuestionAnswer.Text = "Question Answer:";
            // 
            // txtbQuestionName
            // 
            this.txtbQuestionName.Location = new System.Drawing.Point(20, 159);
            this.txtbQuestionName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbQuestionName.Multiline = true;
            this.txtbQuestionName.Name = "txtbQuestionName";
            this.txtbQuestionName.Size = new System.Drawing.Size(112, 33);
            this.txtbQuestionName.TabIndex = 4;
            // 
            // txtbQuestionAnswer
            // 
            this.txtbQuestionAnswer.Location = new System.Drawing.Point(166, 158);
            this.txtbQuestionAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbQuestionAnswer.Multiline = true;
            this.txtbQuestionAnswer.Name = "txtbQuestionAnswer";
            this.txtbQuestionAnswer.Size = new System.Drawing.Size(122, 33);
            this.txtbQuestionAnswer.TabIndex = 5;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.Location = new System.Drawing.Point(320, 143);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(85, 47);
            this.btnAddQuestion.TabIndex = 6;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(6, 5);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(15, 13);
            this.lblClose.TabIndex = 7;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // QuestionText
            // 
            this.QuestionText.DataPropertyName = "QuestionText";
            this.QuestionText.HeaderText = "Question Text";
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.ReadOnly = true;
            // 
            // Answer
            // 
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            // 
            // Edit
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle5;
            this.Edit.HeaderText = "Edit Question";
            this.Edit.MinimumWidth = 10;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Firebrick;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle6;
            this.Delete.HeaderText = "Delete Question";
            this.Delete.MinimumWidth = 10;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // frmQuestionOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::Monopoly.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(425, 210);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.txtbQuestionAnswer);
            this.Controls.Add(this.txtbQuestionName);
            this.Controls.Add(this.lblQuestionAnswer);
            this.Controls.Add(this.lblQuestionName);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.lblSelectedCategory);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuestionOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuestionOverview";
            this.Load += new System.EventHandler(this.frmQuestionOverview_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmQuestionOverview_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmQuestionOverview_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmQuestionOverview_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectedCategory;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Label lblQuestionName;
        private System.Windows.Forms.Label lblQuestionAnswer;
        private System.Windows.Forms.TextBox txtbQuestionName;
        private System.Windows.Forms.TextBox txtbQuestionAnswer;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}