
namespace Monopoly
{
    partial class frmPlayQuiz
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
            this.lblColorRed = new System.Windows.Forms.Label();
            this.lblColorGreen = new System.Windows.Forms.Label();
            this.lblColorYellow = new System.Windows.Forms.Label();
            this.lblColorBlue = new System.Windows.Forms.Label();
            this.txtbColorRedName = new System.Windows.Forms.TextBox();
            this.txtbColorGreenName = new System.Windows.Forms.TextBox();
            this.txtbColorYellowName = new System.Windows.Forms.TextBox();
            this.txtbColorBlueName = new System.Windows.Forms.TextBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblSelectedCategory = new System.Windows.Forms.Label();
            this.cboxCategories = new System.Windows.Forms.ComboBox();
            this.txtbGameName = new System.Windows.Forms.TextBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblColorRed
            // 
            this.lblColorRed.AutoSize = true;
            this.lblColorRed.BackColor = System.Drawing.Color.Transparent;
            this.lblColorRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColorRed.Location = new System.Drawing.Point(45, 230);
            this.lblColorRed.Name = "lblColorRed";
            this.lblColorRed.Size = new System.Drawing.Size(87, 37);
            this.lblColorRed.TabIndex = 2;
            this.lblColorRed.Text = "Red:";
            // 
            // lblColorGreen
            // 
            this.lblColorGreen.AutoSize = true;
            this.lblColorGreen.BackColor = System.Drawing.Color.Transparent;
            this.lblColorGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorGreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColorGreen.Location = new System.Drawing.Point(235, 230);
            this.lblColorGreen.Name = "lblColorGreen";
            this.lblColorGreen.Size = new System.Drawing.Size(120, 37);
            this.lblColorGreen.TabIndex = 3;
            this.lblColorGreen.Text = "Green:";
            // 
            // lblColorYellow
            // 
            this.lblColorYellow.AutoSize = true;
            this.lblColorYellow.BackColor = System.Drawing.Color.Transparent;
            this.lblColorYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorYellow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColorYellow.Location = new System.Drawing.Point(45, 340);
            this.lblColorYellow.Name = "lblColorYellow";
            this.lblColorYellow.Size = new System.Drawing.Size(127, 37);
            this.lblColorYellow.TabIndex = 4;
            this.lblColorYellow.Text = "Yellow:";
            // 
            // lblColorBlue
            // 
            this.lblColorBlue.AutoSize = true;
            this.lblColorBlue.BackColor = System.Drawing.Color.Transparent;
            this.lblColorBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorBlue.Location = new System.Drawing.Point(235, 340);
            this.lblColorBlue.Name = "lblColorBlue";
            this.lblColorBlue.Size = new System.Drawing.Size(94, 37);
            this.lblColorBlue.TabIndex = 5;
            this.lblColorBlue.Text = "Blue:";
            // 
            // txtbColorRedName
            // 
            this.txtbColorRedName.Location = new System.Drawing.Point(50, 270);
            this.txtbColorRedName.Name = "txtbColorRedName";
            this.txtbColorRedName.Size = new System.Drawing.Size(120, 31);
            this.txtbColorRedName.TabIndex = 6;
            // 
            // txtbColorGreenName
            // 
            this.txtbColorGreenName.Location = new System.Drawing.Point(240, 270);
            this.txtbColorGreenName.Name = "txtbColorGreenName";
            this.txtbColorGreenName.Size = new System.Drawing.Size(120, 31);
            this.txtbColorGreenName.TabIndex = 6;
            // 
            // txtbColorYellowName
            // 
            this.txtbColorYellowName.Location = new System.Drawing.Point(50, 380);
            this.txtbColorYellowName.Name = "txtbColorYellowName";
            this.txtbColorYellowName.Size = new System.Drawing.Size(120, 31);
            this.txtbColorYellowName.TabIndex = 6;
            // 
            // txtbColorBlueName
            // 
            this.txtbColorBlueName.Location = new System.Drawing.Point(240, 380);
            this.txtbColorBlueName.Name = "txtbColorBlueName";
            this.txtbColorBlueName.Size = new System.Drawing.Size(120, 31);
            this.txtbColorBlueName.TabIndex = 6;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(12, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 25);
            this.lblClose.TabIndex = 7;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblSelectedCategory
            // 
            this.lblSelectedCategory.AutoSize = true;
            this.lblSelectedCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCategory.Location = new System.Drawing.Point(55, 15);
            this.lblSelectedCategory.Name = "lblSelectedCategory";
            this.lblSelectedCategory.Size = new System.Drawing.Size(300, 25);
            this.lblSelectedCategory.TabIndex = 8;
            this.lblSelectedCategory.Text = "**SELECTED CATEGORY**";
            // 
            // cboxCategories
            // 
            this.cboxCategories.FormattingEnabled = true;
            this.cboxCategories.Location = new System.Drawing.Point(50, 58);
            this.cboxCategories.Name = "cboxCategories";
            this.cboxCategories.Size = new System.Drawing.Size(308, 33);
            this.cboxCategories.TabIndex = 9;
            // 
            // txtbGameName
            // 
            this.txtbGameName.Location = new System.Drawing.Point(47, 160);
            this.txtbGameName.Name = "txtbGameName";
            this.txtbGameName.Size = new System.Drawing.Size(313, 31);
            this.txtbGameName.TabIndex = 10;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.BackColor = System.Drawing.Color.Transparent;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblGameName.Location = new System.Drawing.Point(40, 120);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(195, 37);
            this.lblGameName.TabIndex = 11;
            this.lblGameName.Text = "Spel Naam:";
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGame.Location = new System.Drawing.Point(47, 440);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(313, 121);
            this.btnCreateGame.TabIndex = 0;
            this.btnCreateGame.Text = "Spel Aanmaken";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmPlayQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(408, 600);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.txtbGameName);
            this.Controls.Add(this.cboxCategories);
            this.Controls.Add(this.lblSelectedCategory);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.txtbColorBlueName);
            this.Controls.Add(this.txtbColorYellowName);
            this.Controls.Add(this.txtbColorGreenName);
            this.Controls.Add(this.txtbColorRedName);
            this.Controls.Add(this.lblColorBlue);
            this.Controls.Add(this.lblColorYellow);
            this.Controls.Add(this.lblColorGreen);
            this.Controls.Add(this.lblColorRed);
            this.Controls.Add(this.btnCreateGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlayQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlayQuiz";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPlayQuiz_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPlayQuiz_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmPlayQuiz_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblColorRed;
        private System.Windows.Forms.Label lblColorGreen;
        private System.Windows.Forms.Label lblColorYellow;
        private System.Windows.Forms.Label lblColorBlue;
        private System.Windows.Forms.TextBox txtbColorRedName;
        private System.Windows.Forms.TextBox txtbColorGreenName;
        private System.Windows.Forms.TextBox txtbColorYellowName;
        private System.Windows.Forms.TextBox txtbColorBlueName;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblSelectedCategory;
        private System.Windows.Forms.ComboBox cboxCategories;
        private System.Windows.Forms.TextBox txtbGameName;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Button btnCreateGame;
    }
}