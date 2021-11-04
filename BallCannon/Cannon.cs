using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CannonBall
{
    internal class Cannon
    {
        public Cannon() 
        { 
        }

        public Cannon(Point position, double slope, double length, double power)
        {
            Position = position;
            Slope = slope;
            Length = length;
            Power = power;
        }

        public Point Position;
        public double Slope { get; set; }
        public double Length { get; set; }
        public double Power { get; set; }

        public void Draw(Graphics g)
        {
            double x0 = Position.X;
            double y0 = Position.Y;
            double x1 = x0 + Length*Math.Cos(Slope*Math.PI/180);
            double y1 = x0 + Length * Math.Sin(Slope * Math.PI / 180);

            g.DrawLine(Pens.Black, Config.ToScreenX(x0), Config.ToScreenY(y0), Config.ToScreenX(x1), Config.ToScreenY(y1));
        }

    }
}
