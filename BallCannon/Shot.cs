using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CannonBall
{
    internal class Shot
    {
        const float G = 1;

        static Random rnd = new Random();

        public Cannon cannon = new Cannon();

        public Ball ball = new Ball();

        bool isActive = true;

        public Shot()
        {
            cannon.Position.X = 0;
            cannon.Position.Y = rnd.Next(0, 100);
            cannon.Length = 10;
            cannon.Slope = 40+rnd.Next(-20, 20);
            cannon.Power = 30+rnd.Next(-10, 10); 

            ball.Position = cannon.Position;
            ball.Vx = cannon.Power * Math.Cos(cannon.Slope*Math.PI/180);
            ball.Vy = cannon.Power * Math.Sin(cannon.Slope * Math.PI / 180);
        }

        public void Update(List<Wall> walls)
        {
            if (!isActive) return;
            
            ball.Vy -= G;

            ball.Position.X += Convert.ToInt32(ball.Vx);
            ball.Position.Y += Convert.ToInt32(ball.Vy);

            foreach (var wall in walls)
            {
                if (Math.Abs(ball.Position.X - wall.X) < 20)
                    if (ball.Position.Y < wall.Y-wall.Gap/2 || ball.Position.Y > wall.Y + wall.Gap / 2)
                    {
                        ball.Position.X = Convert.ToInt32(wall.X);
                        isActive = false;
                    }
            }

            if (ball.Position.Y < 0)
            {
                ball.Position.Y = 2;
                isActive = false;
            }

            if (ball.Position.X >= Config.World_Width)
            {
                ball.Position.X = Convert.ToInt32(Config.World_Width - 2);
                isActive = false;
            }



        }
        public void Draw(Graphics g)
        {
            cannon.Draw(g);
            ball.Draw(g);
        }

    }
}
