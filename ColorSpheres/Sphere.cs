using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color color;
        private float radius;
        private int nTimesThrown;

        public Sphere(Color c, float r)
        {
            color = c;
            radius = r;
            nTimesThrown = 0;
        }

        public void Pop()
        {
            radius = 0;
        }
    }
}