namespace Monopoly
{
    partial class frmMain
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
            this.btnPlayQuiz = new System.Windows.Forms.Button();
            this.btnManageQuestions = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayQuiz
            // 
            this.btnPlayQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayQuiz.Location = new System.Drawing.Point(30, 29);
            this.btnPlayQuiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlayQuiz.Name = "btnPlayQuiz";
            this.btnPlayQuiz.Size = new System.Drawing.Size(150, 52);
            this.btnPlayQuiz.TabIndex = 1;
            this.btnPlayQuiz.Text = "Play Quiz";
            this.btnPlayQuiz.UseVisualStyleBackColor = true;
            this.btnPlayQuiz.Click += new System.EventHandler(this.btnPlayQuiz_Click);
            // 
            // btnManageQuestions
            // 
            this.btnManageQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageQuestions.Location = new System.Drawing.Point(30, 84);
            this.btnManageQuestions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageQuestions.Name = "btnManageQuestions";
            this.btnManageQuestions.Size = new System.Drawing.Size(150, 52);
            this.btnManageQuestions.TabIndex = 2;
            this.btnManageQuestions.Text = "Vragen Beheren";
            this.btnManageQuestions.UseVisualStyleBackColor = true;
            this.btnManageQuestions.Click += new System.EventHandler(this.btnManageQuestions_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(6, 7);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(15, 13);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::Monopoly.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(210, 161);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnManageQuestions);
            this.Controls.Add(this.btnPlayQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlayQuiz;
        private System.Windows.Forms.Button btnManageQuestions;
        private System.Windows.Forms.Label lblClose;
    }
}

