using System;
using AcademyJ.Week3.Day1.Lib;

namespace AcademyJ.Week3.Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** OOP - Day 1 **");

            #region Person Example

            Person p1;
            Person p2;

            p1 = new Person("Davide", "Maggiulli");
            p2 = new Person("Antonia", "Passaretti");

            p1.SetAddress("Imola - Via Fosse Ardeatine");
            p2.SetAddress("Bologna - Via delle Moline");

            Console.WriteLine(p1.GetFirstName());


            #endregion


            #region Geometry
            Rectangle r1 = new Rectangle(10.0f, 20.0f);
            Rectangle r2 = new Rectangle(15.0f, 15.0f);

            Console.WriteLine($"Rettangolo 1: Base: {r1.Base}, Altezza: {r1.Height}, Area: {r1.GetArea()}, Perimetro: {r1.GetPerimetro()}");
            Console.WriteLine($"Rettangolo 2: Base: {r2.Base}, Altezza: {r2.Height}, Area: {r2.GetArea()}, Perimetro: {r2.GetPerimetro()}");

            if(r1.GetArea() > r2.GetArea())
            {
                Console.WriteLine("Il primo rettangolo ha area maggiore");
            }
            else
            {
                Console.WriteLine("Il secondo rettangolo ha area maggiore");
            }

            Circle c1 = new Circle(10);
            Circle c2 = new Circle();
            Console.WriteLine($"Cerchio 1: Raggio: {c1.Radius}, Area: {c1.GetArea()}, Perimetro: {c1.GetPerimetro()}");
            Console.WriteLine($"Cerchio 2: Raggio: {c2.Radius}, Area: {c2.GetArea()}, Perimetro: {c2.GetPerimetro()}");

            #endregion

            #region Complex Number Test 

            ComplexNumber c;

            #endregion

            Console.ReadLine();
        }
    }
}
