using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Snake
{
    public class Jedzenie
    {
        private int x, y, szeroko, wysoko;
        private SolidBrush brush;
        public Rectangle foodRec;
        public Jedzenie(Random rndFood)
        {
            x = rndFood.Next(0, 29) * 10;
            y = rndFood.Next(0, 29) * 10;
            brush = new SolidBrush(Color.Red);
            szeroko = 10;
            wysoko = 10;
            foodRec = new Rectangle(x, y, szeroko, wysoko);
        }
        public void polozenie(Random rndFood)
        {
            x = rndFood.Next(0, 29) * 10;
            y = rndFood.Next(0, 29) * 10;
        }
        public void rysujJedzenie(Graphics tlo)
        {

        }
    }
}
