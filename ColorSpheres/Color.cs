using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private byte red, green, blue, alpha;

        private Color(byte red, byte green, byte blue, byte alpha)
        {
            red = GetRed();
            green = GetGreen();
            blue = GetBlue();
            alpha = GetAlpha();
        }

        private Color(byte red, byte green, byte blue)
        {
            red = GetRed();
            green = GetGreen();
            blue = GetBlue();
            alpha = 255;
        }

        public byte GetRed()
        {
            return red;
        }

        public byte GetGreen()
        {
            return green;
        }

        public byte GetBlue()
        {
            return blue;
        }

        public byte GetAlpha()
        {
            return alpha;
        }

        private byte GetGrey()
        {
            return (byte)((red + green + blue) / 3);
        }
    }
}