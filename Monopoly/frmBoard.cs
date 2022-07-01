using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class frmBoard : Form
    {
        public Game Game;
        public frmBoard(Game _Game)
        {
            Game = _Game;
            InitializeComponent();
        }

        private void frmBoard_Load(object sender, EventArgs e)
        {
            txtbConsole.ReadOnly = true;
            txtbConsole.Text = "Test\r\nDit is een test!";
        }
    }
}
