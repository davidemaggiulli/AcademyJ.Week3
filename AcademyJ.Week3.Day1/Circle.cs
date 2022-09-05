using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyJ.Week3.Day1
{
    public class Circle
    {
        public float Radius { get; private set; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public Circle()
        {
            Radius = 1.0f;
        }

        public float GetArea()
        {
            return (float)(Math.PI * Math.Pow(Radius, 2));
        }

        public float GetPerimetro()
        {
            return (float)(2 * Math.PI * Radius);
        }
    }
}
