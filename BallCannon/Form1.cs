using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CannonBall
{
    public partial class Form1 : Form
    {
        List<Shot> shots = new List<Shot>();
        List<Wall> walls = new List<Wall>();

        public Form1()
        {
            InitializeComponent();

            Config.World_Width = 1000;
            Config.World_Height = 300;

            Config.Screen_Width =pictureBox1.Width;
            Config.Screen_Height = pictureBox1.Height;

            walls.Add(new Wall(300,100,50));
            walls.Add(new Wall(700,200, 50));
            walls.Add(new Wall(900, 200, 150));


            for (int i = 0; i < 500; i++)
            {
                Shot s = new Shot();
                shots.Add(s);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var wall in walls)
            {
                wall.Draw(g);
            }

            foreach (var shot in shots)
            {
                shot.Draw(g);
            }
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var shot in shots)
            {
                shot.Update(walls);
            }

            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        
    }
}
