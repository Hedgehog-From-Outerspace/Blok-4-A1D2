
namespace Monopoly
{
    partial class frmGameOverview
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
            this.lblGameOverview = new System.Windows.Forms.Label();
            this.dgvGameOverview = new System.Windows.Forms.DataGridView();
            this.lblCloseButton = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagePlayers = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Play = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameOverview
            // 
            this.lblGameOverview.AutoSize = true;
            this.lblGameOverview.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOverview.Location = new System.Drawing.Point(372, 9);
            this.lblGameOverview.Name = "lblGameOverview";
            this.lblGameOverview.Size = new System.Drawing.Size(343, 51);
            this.lblGameOverview.TabIndex = 0;
            this.lblGameOverview.Text = "Game Overview";
            // 
            // dgvGameOverview
            // 
            this.dgvGameOverview.AllowUserToAddRows = false;
            this.dgvGameOverview.AllowUserToDeleteRows = false;
            this.dgvGameOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGameOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGameOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameName,
            this.GameCategory,
            this.ManagePlayers,
            this.Play,
            this.Delete});
            this.dgvGameOverview.Location = new System.Drawing.Point(53, 63);
            this.dgvGameOverview.Name = "dgvGameOverview";
            this.dgvGameOverview.ReadOnly = true;
            this.dgvGameOverview.RowHeadersVisible = false;
            this.dgvGameOverview.RowHeadersWidth = 82;
            this.dgvGameOverview.RowTemplate.Height = 33;
            this.dgvGameOverview.Size = new System.Drawing.Size(970, 426);
            this.dgvGameOverview.TabIndex = 1;
            // 
            // lblCloseButton
            // 
            this.lblCloseButton.AutoSize = true;
            this.lblCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.lblCloseButton.ForeColor = System.Drawing.Color.Red;
            this.lblCloseButton.Location = new System.Drawing.Point(13, 13);
            this.lblCloseButton.Name = "lblCloseButton";
            this.lblCloseButton.Size = new System.Drawing.Size(27, 25);
            this.lblCloseButton.TabIndex = 2;
            this.lblCloseButton.Text = "X";
            this.lblCloseButton.Click += new System.EventHandler(this.lblCloseButton_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewGame.Location = new System.Drawing.Point(406, 512);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(275, 74);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "Nieuw Spel";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // GameName
            // 
            this.GameName.DataPropertyName = "Name";
            this.GameName.HeaderText = "Name";
            this.GameName.MinimumWidth = 10;
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            // 
            // GameCategory
            // 
            this.GameCategory.DataPropertyName = "Category";
            this.GameCategory.HeaderText = "Category";
            this.GameCategory.MinimumWidth = 10;
            this.GameCategory.Name = "GameCategory";
            this.GameCategory.ReadOnly = true;
            // 
            // ManagePlayers
            // 
            this.ManagePlayers.HeaderText = "Players";
            this.ManagePlayers.MinimumWidth = 10;
            this.ManagePlayers.Name = "ManagePlayers";
            this.ManagePlayers.ReadOnly = true;
            // 
            // Play
            // 
            this.Play.HeaderText = "Play";
            this.Play.MinimumWidth = 10;
            this.Play.Name = "Play";
            this.Play.ReadOnly = true;
            this.Play.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 10;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // frmGameOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1080, 618);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblCloseButton);
            this.Controls.Add(this.dgvGameOverview);
            this.Controls.Add(this.lblGameOverview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGameOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGameOverview";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmGameOverview_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmGameOverview_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmGameOverview_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameOverview;
        private System.Windows.Forms.DataGridView dgvGameOverview;
        private System.Windows.Forms.Label lblCloseButton;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameCategory;
        private System.Windows.Forms.DataGridViewButtonColumn ManagePlayers;
        private System.Windows.Forms.DataGridViewButtonColumn Play;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}