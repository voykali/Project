﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_Snake
{
    public partial class Form1 : Form
    {
        Graphics tlo;
        Snake snake = new Snake();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            tlo = e.Graphics;
            snake.rysujSnake(tlo);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
