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
        public Rectangle[] wazRect;
        private SolidBrush brush;
        private int x, y, szerokosc, wysoko;

        public Snake()
        {
            wazRect = new Rectangle[2];
            brush = new SolidBrush(Color.Green);
            x = 20;
            y = 0;
            szerokosc = 10;
            wysoko = 10;

        }
    }
}
