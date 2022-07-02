
namespace Monopoly
{
    partial class frmPlayerOverview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblChosenGame = new System.Windows.Forms.Label();
            this.lblCloseButton = new System.Windows.Forms.Label();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.txtbPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChosenGame
            // 
            this.lblChosenGame.AutoSize = true;
            this.lblChosenGame.BackColor = System.Drawing.Color.Transparent;
            this.lblChosenGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold);
            this.lblChosenGame.Location = new System.Drawing.Point(119, 9);
            this.lblChosenGame.Name = "lblChosenGame";
            this.lblChosenGame.Size = new System.Drawing.Size(377, 44);
            this.lblChosenGame.TabIndex = 0;
            this.lblChosenGame.Text = "**CHOSEN GAME**";
            // 
            // lblCloseButton
            // 
            this.lblCloseButton.AutoSize = true;
            this.lblCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.lblCloseButton.ForeColor = System.Drawing.Color.Red;
            this.lblCloseButton.Location = new System.Drawing.Point(11, 9);
            this.lblCloseButton.Name = "lblCloseButton";
            this.lblCloseButton.Size = new System.Drawing.Size(25, 24);
            this.lblCloseButton.TabIndex = 1;
            this.lblCloseButton.Text = "X";
            this.lblCloseButton.Click += new System.EventHandler(this.lblCloseButton_Click);
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AllowUserToResizeColumns = false;
            this.dgvPlayers.AllowUserToResizeRows = false;
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.Delete});
            this.dgvPlayers.Location = new System.Drawing.Point(51, 60);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.RowHeadersWidth = 82;
            this.dgvPlayers.RowTemplate.Height = 33;
            this.dgvPlayers.Size = new System.Drawing.Size(528, 219);
            this.dgvPlayers.TabIndex = 2;
            this.dgvPlayers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayers_CellClick);
            // 
            // txtbPlayerName
            // 
            this.txtbPlayerName.Location = new System.Drawing.Point(82, 319);
            this.txtbPlayerName.Name = "txtbPlayerName";
            this.txtbPlayerName.Size = new System.Drawing.Size(156, 29);
            this.txtbPlayerName.TabIndex = 3;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold);
            this.lblPlayerName.Location = new System.Drawing.Point(77, 286);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(88, 29);
            this.lblPlayerName.TabIndex = 4;
            this.lblPlayerName.Text = "Naam:";
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddPlayer.Location = new System.Drawing.Point(264, 286);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(139, 62);
            this.btnAddPlayer.TabIndex = 5;
            this.btnAddPlayer.Text = "Add";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditPlayer.Location = new System.Drawing.Point(409, 286);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(139, 62);
            this.btnEditPlayer.TabIndex = 6;
            this.btnEditPlayer.Text = "Edit";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            this.btnEditPlayer.Click += new System.EventHandler(this.btnEditPlayer_Click);
            // 
            // PlayerName
            // 
            this.PlayerName.DataPropertyName = "Name";
            this.PlayerName.HeaderText = "Name";
            this.PlayerName.MinimumWidth = 10;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Firebrick;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 10;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // frmPlayerOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(629, 382);
            this.Controls.Add(this.btnEditPlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtbPlayerName);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.lblCloseButton);
            this.Controls.Add(this.lblChosenGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlayerOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlayerOverview";
            this.Load += new System.EventHandler(this.frmPlayerOverview_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPlayerOverview_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPlayerOverview_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmPlayerOverview_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChosenGame;
        private System.Windows.Forms.Label lblCloseButton;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.TextBox txtbPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnEditPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}