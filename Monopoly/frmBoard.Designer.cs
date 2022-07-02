
namespace Monopoly
{
    partial class frmBoard
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
            this.txtbConsole = new System.Windows.Forms.TextBox();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.pnlPlayer3 = new System.Windows.Forms.Panel();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.pnlPlayer4 = new System.Windows.Forms.Panel();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.labelP1Money = new System.Windows.Forms.Label();
            this.labelP2Money = new System.Windows.Forms.Label();
            this.labelP3Money = new System.Windows.Forms.Label();
            this.labelP4Money = new System.Windows.Forms.Label();
            this.pnlPlayer1.SuspendLayout();
            this.pnlPlayer2.SuspendLayout();
            this.pnlPlayer3.SuspendLayout();
            this.pnlPlayer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbConsole
            // 
            this.txtbConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbConsole.Location = new System.Drawing.Point(558, 0);
            this.txtbConsole.Margin = new System.Windows.Forms.Padding(4);
            this.txtbConsole.Multiline = true;
            this.txtbConsole.Name = "txtbConsole";
            this.txtbConsole.Size = new System.Drawing.Size(523, 288);
            this.txtbConsole.TabIndex = 3;
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.Controls.Add(this.labelP1Money);
            this.pnlPlayer1.Controls.Add(this.lblPlayer1);
            this.pnlPlayer1.Location = new System.Drawing.Point(122, 0);
            this.pnlPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(114, 288);
            this.pnlPlayer1.TabIndex = 4;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(13, 10);
            this.lblPlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(88, 29);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "**P1**";
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.Controls.Add(this.labelP2Money);
            this.pnlPlayer2.Controls.Add(this.lblPlayer2);
            this.pnlPlayer2.Location = new System.Drawing.Point(231, 0);
            this.pnlPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(114, 288);
            this.pnlPlayer2.TabIndex = 5;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold);
            this.lblPlayer2.Location = new System.Drawing.Point(13, 10);
            this.lblPlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(88, 29);
            this.lblPlayer2.TabIndex = 0;
            this.lblPlayer2.Text = "**P2**";
            // 
            // pnlPlayer3
            // 
            this.pnlPlayer3.Controls.Add(this.labelP3Money);
            this.pnlPlayer3.Controls.Add(this.lblPlayer3);
            this.pnlPlayer3.Location = new System.Drawing.Point(340, 0);
            this.pnlPlayer3.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPlayer3.Name = "pnlPlayer3";
            this.pnlPlayer3.Size = new System.Drawing.Size(114, 288);
            this.pnlPlayer3.TabIndex = 5;
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold);
            this.lblPlayer3.Location = new System.Drawing.Point(13, 10);
            this.lblPlayer3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(88, 29);
            this.lblPlayer3.TabIndex = 0;
            this.lblPlayer3.Text = "**P3**";
            // 
            // pnlPlayer4
            // 
            this.pnlPlayer4.Controls.Add(this.labelP4Money);
            this.pnlPlayer4.Controls.Add(this.lblPlayer4);
            this.pnlPlayer4.Location = new System.Drawing.Point(449, 0);
            this.pnlPlayer4.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPlayer4.Name = "pnlPlayer4";
            this.pnlPlayer4.Size = new System.Drawing.Size(114, 288);
            this.pnlPlayer4.TabIndex = 5;
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold);
            this.lblPlayer4.Location = new System.Drawing.Point(13, 10);
            this.lblPlayer4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(88, 29);
            this.lblPlayer4.TabIndex = 0;
            this.lblPlayer4.Text = "**P4**";
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitGame.ForeColor = System.Drawing.Color.Red;
            this.btnQuitGame.Location = new System.Drawing.Point(486, 307);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(232, 76);
            this.btnQuitGame.TabIndex = 6;
            this.btnQuitGame.Text = "Quit Game";
            this.btnQuitGame.UseVisualStyleBackColor = false;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // labelP1Money
            // 
            this.labelP1Money.AutoSize = true;
            this.labelP1Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1Money.Location = new System.Drawing.Point(2, 130);
            this.labelP1Money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP1Money.Name = "labelP1Money";
            this.labelP1Money.Size = new System.Drawing.Size(99, 29);
            this.labelP1Money.TabIndex = 1;
            this.labelP1Money.Text = "**200**";
            // 
            // labelP2Money
            // 
            this.labelP2Money.AutoSize = true;
            this.labelP2Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2Money.Location = new System.Drawing.Point(4, 130);
            this.labelP2Money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP2Money.Name = "labelP2Money";
            this.labelP2Money.Size = new System.Drawing.Size(99, 29);
            this.labelP2Money.TabIndex = 2;
            this.labelP2Money.Text = "**200**";
            // 
            // labelP3Money
            // 
            this.labelP3Money.AutoSize = true;
            this.labelP3Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP3Money.Location = new System.Drawing.Point(2, 130);
            this.labelP3Money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP3Money.Name = "labelP3Money";
            this.labelP3Money.Size = new System.Drawing.Size(99, 29);
            this.labelP3Money.TabIndex = 3;
            this.labelP3Money.Text = "**200**";
            // 
            // labelP4Money
            // 
            this.labelP4Money.AutoSize = true;
            this.labelP4Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP4Money.Location = new System.Drawing.Point(4, 130);
            this.labelP4Money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP4Money.Name = "labelP4Money";
            this.labelP4Money.Size = new System.Drawing.Size(99, 29);
            this.labelP4Money.TabIndex = 4;
            this.labelP4Money.Text = "**200**";
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly.Properties.Resources.bordv2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 1264);
            this.Controls.Add(this.btnQuitGame);
            this.Controls.Add(this.pnlPlayer4);
            this.Controls.Add(this.pnlPlayer3);
            this.Controls.Add(this.pnlPlayer2);
            this.Controls.Add(this.pnlPlayer1);
            this.Controls.Add(this.txtbConsole);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBoard";
            this.Load += new System.EventHandler(this.frmBoard_Load);
            this.pnlPlayer1.ResumeLayout(false);
            this.pnlPlayer1.PerformLayout();
            this.pnlPlayer2.ResumeLayout(false);
            this.pnlPlayer2.PerformLayout();
            this.pnlPlayer3.ResumeLayout(false);
            this.pnlPlayer3.PerformLayout();
            this.pnlPlayer4.ResumeLayout(false);
            this.pnlPlayer4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbConsole;
        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Panel pnlPlayer3;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Panel pnlPlayer4;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.Button btnQuitGame;
        private System.Windows.Forms.Label labelP1Money;
        private System.Windows.Forms.Label labelP2Money;
        private System.Windows.Forms.Label labelP3Money;
        private System.Windows.Forms.Label labelP4Money;
    }
}