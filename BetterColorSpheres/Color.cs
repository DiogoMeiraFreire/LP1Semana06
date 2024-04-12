using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Color
    {
        private byte red, green, blue, alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            red = GetRed;
            green = GetGreen;
            blue = GetBlue;
            alpha = GetAlpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            red = GetRed;
            green = GetGreen;
            blue = GetBlue;
            alpha = 255;
        }

       public byte GetRed
        {
            get => red;

            private set 
            {
                red = value;
            } 
        }


        public byte GetGreen
        {
            get => green;

            private set 
            {
                green = value;
            } 
        }

        public byte GetBlue
        {
            get => blue;

            private set 
            {
                blue = value;
            } 
        }

        public byte GetAlpha
        {
            get => alpha;

            private set 
            {
                alpha = value;
            } 
        }
       
        public byte GetGrey
        {
            get => (byte)((red + green + blue) / 3);
        }
    }
}