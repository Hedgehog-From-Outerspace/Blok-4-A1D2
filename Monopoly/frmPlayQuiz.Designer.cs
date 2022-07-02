
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
            this.lblClose = new System.Windows.Forms.Label();
            this.lblSelectedCategory = new System.Windows.Forms.Label();
            this.cboxCategories = new System.Windows.Forms.ComboBox();
            this.txtbGameName = new System.Windows.Forms.TextBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cboxCategories.SelectedIndexChanged += new System.EventHandler(this.cboxCategories_SelectedIndexChanged);
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
            this.btnCreateGame.Location = new System.Drawing.Point(49, 210);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(309, 126);
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
            this.ClientSize = new System.Drawing.Size(408, 380);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.txtbGameName);
            this.Controls.Add(this.cboxCategories);
            this.Controls.Add(this.lblSelectedCategory);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnCreateGame);
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
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblSelectedCategory;
        private System.Windows.Forms.ComboBox cboxCategories;
        private System.Windows.Forms.TextBox txtbGameName;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Button btnCreateGame;
    }
}