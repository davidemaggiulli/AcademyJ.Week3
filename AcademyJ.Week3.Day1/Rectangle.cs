using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyJ.Week3.Day1
{
    public class Rectangle
    {

        public float Base { get; private set; }
        public float Height { get; private set; }

        public Rectangle(float @base, float height)
        {
            Base = @base;
            Height = height;
        }

        public float GetArea()
        {
            return Base * Height;
        }

        public float GetPerimetro()
        {
            return 2 * (Height + Base);
        }
    }
}
