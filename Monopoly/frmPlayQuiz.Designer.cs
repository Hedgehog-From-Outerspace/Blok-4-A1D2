
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblSelectedCategory = new System.Windows.Forms.Label();
            this.cboxCategories = new System.Windows.Forms.ComboBox();
            this.txtbGameName = new System.Windows.Forms.TextBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblColorRed
            // 
            this.lblColorRed.AutoSize = true;
            this.lblColorRed.BackColor = System.Drawing.Color.Transparent;
            this.lblColorRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColorRed.Location = new System.Drawing.Point(41, 221);
            this.lblColorRed.Name = "lblColorRed";
            this.lblColorRed.Size = new System.Drawing.Size(78, 32);
            this.lblColorRed.TabIndex = 2;
            this.lblColorRed.Text = "Red:";
            // 
            // lblColorGreen
            // 
            this.lblColorGreen.AutoSize = true;
            this.lblColorGreen.BackColor = System.Drawing.Color.Transparent;
            this.lblColorGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorGreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColorGreen.Location = new System.Drawing.Point(215, 221);
            this.lblColorGreen.Name = "lblColorGreen";
            this.lblColorGreen.Size = new System.Drawing.Size(107, 32);
            this.lblColorGreen.TabIndex = 3;
            this.lblColorGreen.Text = "Green:";
            // 
            // lblColorYellow
            // 
            this.lblColorYellow.AutoSize = true;
            this.lblColorYellow.BackColor = System.Drawing.Color.Transparent;
            this.lblColorYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorYellow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColorYellow.Location = new System.Drawing.Point(41, 326);
            this.lblColorYellow.Name = "lblColorYellow";
            this.lblColorYellow.Size = new System.Drawing.Size(114, 32);
            this.lblColorYellow.TabIndex = 4;
            this.lblColorYellow.Text = "Yellow:";
            // 
            // lblColorBlue
            // 
            this.lblColorBlue.AutoSize = true;
            this.lblColorBlue.BackColor = System.Drawing.Color.Transparent;
            this.lblColorBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorBlue.Location = new System.Drawing.Point(215, 326);
            this.lblColorBlue.Name = "lblColorBlue";
            this.lblColorBlue.Size = new System.Drawing.Size(85, 32);
            this.lblColorBlue.TabIndex = 5;
            this.lblColorBlue.Text = "Blue:";
            // 
            // txtbColorRedName
            // 
            this.txtbColorRedName.Location = new System.Drawing.Point(46, 259);
            this.txtbColorRedName.Name = "txtbColorRedName";
            this.txtbColorRedName.Size = new System.Drawing.Size(110, 29);
            this.txtbColorRedName.TabIndex = 6;
            // 
            // txtbColorGreenName
            // 
            this.txtbColorGreenName.Location = new System.Drawing.Point(220, 259);
            this.txtbColorGreenName.Name = "txtbColorGreenName";
            this.txtbColorGreenName.Size = new System.Drawing.Size(110, 29);
            this.txtbColorGreenName.TabIndex = 6;
            // 
            // txtbColorYellowName
            // 
            this.txtbColorYellowName.Location = new System.Drawing.Point(46, 365);
            this.txtbColorYellowName.Name = "txtbColorYellowName";
            this.txtbColorYellowName.Size = new System.Drawing.Size(110, 29);
            this.txtbColorYellowName.TabIndex = 6;
            // 
            // txtbColorBlueName
            // 
            this.txtbColorBlueName.Location = new System.Drawing.Point(220, 365);
            this.txtbColorBlueName.Name = "txtbColorBlueName";
            this.txtbColorBlueName.Size = new System.Drawing.Size(110, 29);
            this.txtbColorBlueName.TabIndex = 6;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(11, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 24);
            this.lblClose.TabIndex = 7;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(43, 422);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(287, 116);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblSelectedCategory
            // 
            this.lblSelectedCategory.AutoSize = true;
            this.lblSelectedCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCategory.Location = new System.Drawing.Point(50, 14);
            this.lblSelectedCategory.Name = "lblSelectedCategory";
            this.lblSelectedCategory.Size = new System.Drawing.Size(268, 24);
            this.lblSelectedCategory.TabIndex = 8;
            this.lblSelectedCategory.Text = "**SELECTED CATEGORY**";
            // 
            // cboxCategories
            // 
            this.cboxCategories.FormattingEnabled = true;
            this.cboxCategories.Location = new System.Drawing.Point(46, 56);
            this.cboxCategories.Name = "cboxCategories";
            this.cboxCategories.Size = new System.Drawing.Size(283, 32);
            this.cboxCategories.TabIndex = 9;
            this.cboxCategories.SelectedIndexChanged += new System.EventHandler(this.cboxCategories_SelectedIndexChanged);
            // 
            // txtbGameName
            // 
            this.txtbGameName.Location = new System.Drawing.Point(43, 154);
            this.txtbGameName.Name = "txtbGameName";
            this.txtbGameName.Size = new System.Drawing.Size(287, 29);
            this.txtbGameName.TabIndex = 10;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.BackColor = System.Drawing.Color.Transparent;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblGameName.Location = new System.Drawing.Point(37, 115);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(172, 32);
            this.lblGameName.TabIndex = 11;
            this.lblGameName.Text = "Spel Naam:";
            // 
            // frmPlayQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(374, 576);
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
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlayQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlayQuiz";
            this.Load += new System.EventHandler(this.frmPlayQuiz_Load);
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
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblSelectedCategory;
        private System.Windows.Forms.ComboBox cboxCategories;
        private System.Windows.Forms.TextBox txtbGameName;
        private System.Windows.Forms.Label lblGameName;
    }
}