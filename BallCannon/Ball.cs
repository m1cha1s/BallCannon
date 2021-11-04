using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CannonBall
{
    internal class Ball
    {
        public Ball()
        {
        }

        public Point Position;
        public double Vx { get; set;}
        public double Vy {  get; set;}

        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Tomato, Config.ToScreenX(Position.X)-5, Config.ToScreenY(Position.Y)-5, 10, 10);
        }
    }
}
