using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Snake
{
    public class Snake
    {
        public Rectangle[] snakeRect;
        private SolidBrush brush;
        private int x, y, szerokosc, wysoko;

        public Snake()
        {
            snakeRect = new Rectangle[2];
            brush = new SolidBrush(Color.Green);
            x = 20;
            y = 0;
            szerokosc = 10;
            wysoko = 10;

            for (int i = 0; i < snakeRect.Length; i++)
            {
                snakeRect[i] = new Rectangle(x, y, szerokosc, wysoko);
                x -= 10;
            }
        }
        public void rysujSnake(Graphics tlo)
        {
            foreach (Rectangle rec in snakeRect)
            {
                tlo.FillRectangle(brush, rec);
            }
        }
    }
}
