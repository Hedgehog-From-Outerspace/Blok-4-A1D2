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
            this.btnManageGames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayQuiz
            // 
            this.btnPlayQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayQuiz.Location = new System.Drawing.Point(60, 55);
            this.btnPlayQuiz.Name = "btnPlayQuiz";
            this.btnPlayQuiz.Size = new System.Drawing.Size(300, 100);
            this.btnPlayQuiz.TabIndex = 1;
            this.btnPlayQuiz.Text = "Play Quiz";
            this.btnPlayQuiz.UseVisualStyleBackColor = true;
            this.btnPlayQuiz.Click += new System.EventHandler(this.btnPlayQuiz_Click);
            // 
            // btnManageQuestions
            // 
            this.btnManageQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageQuestions.Location = new System.Drawing.Point(60, 161);
            this.btnManageQuestions.Name = "btnManageQuestions";
            this.btnManageQuestions.Size = new System.Drawing.Size(300, 100);
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
            this.lblClose.Location = new System.Drawing.Point(13, 13);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 25);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnManageGames
            // 
            this.btnManageGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageGames.Location = new System.Drawing.Point(60, 267);
            this.btnManageGames.Name = "btnManageGames";
            this.btnManageGames.Size = new System.Drawing.Size(300, 100);
            this.btnManageGames.TabIndex = 4;
            this.btnManageGames.Text = "Games Beheren";
            this.btnManageGames.UseVisualStyleBackColor = true;
            this.btnManageGames.Click += new System.EventHandler(this.btnManageGames_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::Monopoly.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(420, 422);
            this.Controls.Add(this.btnManageGames);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnManageQuestions);
            this.Controls.Add(this.btnPlayQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
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
        private System.Windows.Forms.Button btnManageGames;
    }
}

