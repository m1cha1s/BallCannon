using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CannonBall
{
    static internal class Config
    {
        static public double World_Width;
        static public double World_Height;

        static public int Screen_Width;
        static public int Screen_Height;

        static public int ToScreenX(double x)
        {
            return Convert.ToInt32(x / World_Width * Screen_Width);
        }

        static public int ToScreenY(double y)
        {
            return Convert.ToInt32(Screen_Height - y / World_Height * Screen_Height);
        }

    }
}
