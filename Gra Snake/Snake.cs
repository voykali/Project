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
        private Rectangle[] snakeRect;
        private SolidBrush brush;
        private int x, y, szerokosc, wysoko;

        public Rectangle[] SnakeRec
        {
            get { return snakeRect; }
        }
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
        public void rysujSnake()
        {
            for (int i = snakeRect.Length - 1; i > 0; i--)
            {
                snakeRect[i] = snakeRect[i - 1];
            }
        }
        public void wDol()
        {
            rysujSnake();
            snakeRect[0].Y += 10;
        }
        public void wGore()
        {
            rysujSnake();
            snakeRect[0].Y -= 10;
        }
        public void wPrawo()
        {
            rysujSnake();
            snakeRect[0].X += 10;
        }
        public void wLewo()
        {
            rysujSnake();
            snakeRect[0].X -= 10;
        }
        public void rosnieSnake()
        {
            List<Rectangle> rec = snakeRect.ToList();
            rec.Add(new Rectangle(snakeRect[snakeRect.Length - 1].X, snakeRect[snakeRect.Length - 1].Y, szerokosc, wysoko));
            snakeRect = rec.ToArray();
        }
    }
}
