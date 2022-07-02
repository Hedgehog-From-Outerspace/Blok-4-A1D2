
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblGameOverview = new System.Windows.Forms.Label();
            this.dgvGameOverview = new System.Windows.Forms.DataGridView();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagePlayers = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Play = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblCloseButton = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameOverview
            // 
            this.lblGameOverview.AutoSize = true;
            this.lblGameOverview.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOverview.Location = new System.Drawing.Point(341, 9);
            this.lblGameOverview.Name = "lblGameOverview";
            this.lblGameOverview.Size = new System.Drawing.Size(306, 44);
            this.lblGameOverview.TabIndex = 0;
            this.lblGameOverview.Text = "Game Overview";
            // 
            // dgvGameOverview
            // 
            this.dgvGameOverview.AllowUserToAddRows = false;
            this.dgvGameOverview.AllowUserToDeleteRows = false;
            this.dgvGameOverview.AllowUserToResizeColumns = false;
            this.dgvGameOverview.AllowUserToResizeRows = false;
            this.dgvGameOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGameOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGameOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameName,
            this.GameCategory,
            this.ManagePlayers,
            this.Play,
            this.Delete});
            this.dgvGameOverview.Location = new System.Drawing.Point(49, 60);
            this.dgvGameOverview.Name = "dgvGameOverview";
            this.dgvGameOverview.ReadOnly = true;
            this.dgvGameOverview.RowHeadersVisible = false;
            this.dgvGameOverview.RowHeadersWidth = 82;
            this.dgvGameOverview.RowTemplate.Height = 33;
            this.dgvGameOverview.Size = new System.Drawing.Size(889, 409);
            this.dgvGameOverview.TabIndex = 1;
            this.dgvGameOverview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGameOverview_CellClick);
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
            this.GameCategory.DataPropertyName = "CategoryName";
            this.GameCategory.HeaderText = "Category";
            this.GameCategory.MinimumWidth = 10;
            this.GameCategory.Name = "GameCategory";
            this.GameCategory.ReadOnly = true;
            // 
            // ManagePlayers
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Orange;
            this.ManagePlayers.DefaultCellStyle = dataGridViewCellStyle1;
            this.ManagePlayers.HeaderText = "Players";
            this.ManagePlayers.MinimumWidth = 10;
            this.ManagePlayers.Name = "ManagePlayers";
            this.ManagePlayers.ReadOnly = true;
            this.ManagePlayers.Text = "Players";
            this.ManagePlayers.UseColumnTextForButtonValue = true;
            // 
            // Play
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Play.DefaultCellStyle = dataGridViewCellStyle2;
            this.Play.HeaderText = "Play";
            this.Play.MinimumWidth = 10;
            this.Play.Name = "Play";
            this.Play.ReadOnly = true;
            this.Play.Text = "Play";
            this.Play.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Firebrick;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 10;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // lblCloseButton
            // 
            this.lblCloseButton.AutoSize = true;
            this.lblCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.lblCloseButton.ForeColor = System.Drawing.Color.Red;
            this.lblCloseButton.Location = new System.Drawing.Point(12, 12);
            this.lblCloseButton.Name = "lblCloseButton";
            this.lblCloseButton.Size = new System.Drawing.Size(25, 24);
            this.lblCloseButton.TabIndex = 2;
            this.lblCloseButton.Text = "X";
            this.lblCloseButton.Click += new System.EventHandler(this.lblCloseButton_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewGame.Location = new System.Drawing.Point(372, 492);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(252, 71);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "Nieuw Spel";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // frmGameOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(990, 593);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblCloseButton);
            this.Controls.Add(this.dgvGameOverview);
            this.Controls.Add(this.lblGameOverview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGameOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGameOverview";
            this.Load += new System.EventHandler(this.frmGameOverview_Load);
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