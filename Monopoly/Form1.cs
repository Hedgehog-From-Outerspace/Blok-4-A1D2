﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            Board board = new Board(0);
            labelTest.Text = board.RollDice().ToString();

        }
    }
}
