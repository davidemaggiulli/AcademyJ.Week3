using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyJ.Week3.Day1.SolarSystem.Models
{
    public class Planet
    {
        public string Name { get;}

        public float Mass { get; }

        public float Radius { get; }

        public Point2D Position { get; }

        public Planet(string name, float mass, float radius, float distanceFromSun)
        {
            Name = name;
            Mass = mass;
            Radius = radius;
            Position = new Point2D(distanceFromSun, 0);
        }
        

        public double GetGravity(Planet p)
        {
            float m1 = this.Mass;
            float m2 = p.Mass;
            float d12 = (float)Math.Sqrt(Math.Pow(this.Position.X - p.Position.X, 2) + Math.Pow(this.Position.Y - p.Position.Y, 2));
            double g = 6.67E-11 * m1 * m2 / Math.Pow(d12, 2);
            return g;
        }

        public override string ToString()
        {
            return $"{Name} - m: {Mass}Kg - r:{Radius}m";
        }

    }
}
