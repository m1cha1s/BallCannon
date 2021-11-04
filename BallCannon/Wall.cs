using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CannonBall
{
    internal class Wall
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Gap { get; set; }

        public Wall(double x, double y, double gap)
        {
            X = x;
            Y = y;
            Gap = gap;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(new Pen(Color.Black, 5), Config.ToScreenX(X), Config.ToScreenY(0), Config.ToScreenX(X), Config.ToScreenY(Y - Gap / 2));
            g.DrawLine(new Pen(Color.Black, 5), Config.ToScreenX(X), Config.ToScreenY(Y + Gap / 2), Config.ToScreenX(X), Config.ToScreenY(Config.World_Height));
        }
    }
}
