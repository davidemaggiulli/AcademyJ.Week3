using AcademyJ.Week3.Day1.SolarSystem.Models;
using System.Globalization;
using System.IO;

namespace AcademyJ.Week3.Day1.SolarSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Solar System Example **");

            //Planet mercurio = new Planet("Mercury", 3.285E23f, 2439.7f, 57910000);
            //Planet sun = new Planet("Sun", 1.989E30f, 696340f, 0);

            //double gMS = sun.GetGravity(mercurio);

            //Console.WriteLine(gMS.ToString("E3"));

            IList<Planet> planets = new List<Planet>();
            planets = ReadPlanetsFromFile();

            //Planet sun = null;
            //foreach(var planet in planets)
            //{
            //    if (planet.Name.Equals("SOLE", StringComparison.InvariantCultureIgnoreCase))
            //    {
            //        sun = planet;
            //        break;
            //    }
            //}

            Planet sun = planets.FirstOrDefault(planet => planet.Name.Equals("SOLE", StringComparison.InvariantCultureIgnoreCase));

            double gravity = 0;
            foreach(var planet in planets)
            {
                Console.WriteLine(planet.ToString());
                if (planet != sun)
                {
                    gravity += sun.GetGravity(planet);
                }
            }
            
            Console.WriteLine($"Gravità totale sul sole: {gravity}");

            // Inserire da tastiera i dati di un nuovo pianeta
            // Aggiungere il nuovo pianeta alla lista
            // Salvare un nuovo file con la lista di tutti i pianeti (incluso quello nuovo)

            Planet newPlanet = ReadPlanetFromConsole();
            if(newPlanet != null)
                planets.Add(newPlanet);
            WritePlanetsIntoFile(planets);

            Console.ReadLine();
        }

        private static IList<Planet> ReadPlanetsFromFile()
        {
            string[] lines = File.ReadAllLines(@"data\planets.txt");
            var planets = new List<Planet>();
            foreach(var line in lines)
            {
                try
                {
                    var parts = line.Split("|", StringSplitOptions.RemoveEmptyEntries);
                    string name = parts[0].Trim();
                    var ukCulture = new CultureInfo("en-UK");
                    float mass = float.Parse(parts[1], ukCulture);
                    float radius = float.Parse(parts[2], ukCulture);
                    float distanceFromSun = float.Parse(parts[3], ukCulture);

                    Planet p = new Planet(name, mass, radius, distanceFromSun);
                    planets.Add(p);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Errore durante il parsing: " + e.Message);
                }
                
            }

            return planets;
        }

        private static Planet ReadPlanetFromConsole()
        {
            var ukCulture = new CultureInfo("en-UK");
            Console.Write("Inserire nome pianeta:\t");
            string name = Console.ReadLine();

            try
            {
                Console.Write("Inserire massa pianeta:\t");
                float mass = float.Parse(Console.ReadLine(), ukCulture);

                Console.Write("Inserire raggio pianeta:\t");
                float radius = float.Parse(Console.ReadLine(), ukCulture);

                Console.Write("Inserire distanza dal sole:\t");
                float distanceFromSun = float.Parse(Console.ReadLine(), ukCulture);

                Planet p = new Planet(name, mass, radius, distanceFromSun);
                return p;
            } catch(Exception e)
            {
                Console.WriteLine("Errore in lettura pianeta: " + e.Message);
            }
            return null;
        }

        private static void WritePlanetsIntoFile(IList<Planet> planets)
        {
            string res = "";
            foreach(var planet in planets)
            {
                string line = $"{planet.Name}\t\t| {planet.Mass} | {planet.Radius} | {planet.Position.X}\n";
                res += line;
            }

            File.WriteAllText(@"data\newPlanets.txt", res);
        }
    }
}