using System;
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

        bool gora = false;
        bool dol = false;
        bool prawo = false;
        bool lewo = false;

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
            if (e.KeyData == Keys.Down && gora == false)
            {
                dol = true;
                gora = false;
                prawo = false;
                lewo = false;
            }
            if (e.KeyData == Keys.Up && dol == false)
            {
                dol = false;
                gora = true;
                prawo = false;
                lewo = false;
            } 
            if (e.KeyData == Keys.Right && lewo == false)
            {
                dol = false;
                gora = false;
                prawo = true;
                lewo = false;
            } 
            if (e.KeyData == Keys.Left && prawo == false)
            {
                dol = false;
                gora = false;
                prawo = false;
                lewo = true;
            }
        }
    }
}
