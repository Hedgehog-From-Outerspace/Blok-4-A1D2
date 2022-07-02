
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.GameQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblQuestionName = new System.Windows.Forms.Label();
            this.lblQuestionAnswer = new System.Windows.Forms.Label();
            this.txtbQuestionName = new System.Windows.Forms.TextBox();
            this.txtbQuestionAnswer = new System.Windows.Forms.TextBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.lblSelectedCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AllowUserToResizeColumns = false;
            this.dgvQuestions.AllowUserToResizeRows = false;
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameQuestion,
            this.GameAnswer,
            this.Delete});
            this.dgvQuestions.Location = new System.Drawing.Point(37, 42);
            this.dgvQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersVisible = false;
            this.dgvQuestions.RowHeadersWidth = 82;
            this.dgvQuestions.RowTemplate.Height = 33;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(1771, 414);
            this.dgvQuestions.TabIndex = 1;
            this.dgvQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestions_CellClick);
            // 
            // GameQuestion
            // 
            this.GameQuestion.DataPropertyName = "QuestionText";
            this.GameQuestion.HeaderText = "Question";
            this.GameQuestion.MinimumWidth = 10;
            this.GameQuestion.Name = "GameQuestion";
            this.GameQuestion.ReadOnly = true;
            // 
            // GameAnswer
            // 
            this.GameAnswer.DataPropertyName = "Answer";
            this.GameAnswer.HeaderText = "Answer";
            this.GameAnswer.MinimumWidth = 10;
            this.GameAnswer.Name = "GameAnswer";
            this.GameAnswer.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Firebrick;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.HeaderText = "Delete Question";
            this.Delete.MinimumWidth = 10;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // lblQuestionName
            // 
            this.lblQuestionName.AutoSize = true;
            this.lblQuestionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionName.Location = new System.Drawing.Point(46, 508);
            this.lblQuestionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestionName.Name = "lblQuestionName";
            this.lblQuestionName.Size = new System.Drawing.Size(183, 29);
            this.lblQuestionName.TabIndex = 2;
            this.lblQuestionName.Text = "Question Text:";
            // 
            // lblQuestionAnswer
            // 
            this.lblQuestionAnswer.AutoSize = true;
            this.lblQuestionAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionAnswer.Location = new System.Drawing.Point(915, 518);
            this.lblQuestionAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestionAnswer.Name = "lblQuestionAnswer";
            this.lblQuestionAnswer.Size = new System.Drawing.Size(218, 29);
            this.lblQuestionAnswer.TabIndex = 3;
            this.lblQuestionAnswer.Text = "Question Answer:";
            // 
            // txtbQuestionName
            // 
            this.txtbQuestionName.Location = new System.Drawing.Point(51, 566);
            this.txtbQuestionName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbQuestionName.Multiline = true;
            this.txtbQuestionName.Name = "txtbQuestionName";
            this.txtbQuestionName.Size = new System.Drawing.Size(803, 58);
            this.txtbQuestionName.TabIndex = 4;
            // 
            // txtbQuestionAnswer
            // 
            this.txtbQuestionAnswer.Location = new System.Drawing.Point(920, 566);
            this.txtbQuestionAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtbQuestionAnswer.Multiline = true;
            this.txtbQuestionAnswer.Name = "txtbQuestionAnswer";
            this.txtbQuestionAnswer.Size = new System.Drawing.Size(220, 58);
            this.txtbQuestionAnswer.TabIndex = 5;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.Location = new System.Drawing.Point(1255, 548);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(156, 87);
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
            this.lblClose.Location = new System.Drawing.Point(11, 9);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 24);
            this.lblClose.TabIndex = 7;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditQuestion.Location = new System.Drawing.Point(1533, 508);
            this.btnEditQuestion.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(312, 166);
            this.btnEditQuestion.TabIndex = 6;
            this.btnEditQuestion.Text = "Edit Question";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // lblSelectedCategory
            // 
            this.lblSelectedCategory.AutoSize = true;
            this.lblSelectedCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCategory.Location = new System.Drawing.Point(744, 9);
            this.lblSelectedCategory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectedCategory.Name = "lblSelectedCategory";
            this.lblSelectedCategory.Size = new System.Drawing.Size(315, 29);
            this.lblSelectedCategory.TabIndex = 8;
            this.lblSelectedCategory.Text = "**CHOSEN CATEGORY**\r\n";
            // 
            // frmQuestionOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::Monopoly.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1903, 731);
            this.Controls.Add(this.lblSelectedCategory);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.txtbQuestionAnswer);
            this.Controls.Add(this.txtbQuestionName);
            this.Controls.Add(this.lblQuestionAnswer);
            this.Controls.Add(this.lblQuestionName);
            this.Controls.Add(this.dgvQuestions);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Label lblQuestionName;
        private System.Windows.Forms.Label lblQuestionAnswer;
        private System.Windows.Forms.TextBox txtbQuestionName;
        private System.Windows.Forms.TextBox txtbQuestionAnswer;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameAnswer;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label lblSelectedCategory;
    }
}