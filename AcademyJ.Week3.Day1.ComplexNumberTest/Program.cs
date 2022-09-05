using AcademyJ.Week3.Day1.Lib;

namespace AcademyJ.Week3.Day1.ComplexNumberTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Complex Number test **");
            ComplexNumber c1 = ReadComplexNumberFromConsole();
            ComplexNumber c2 = ReadComplexNumberFromConsole();

        }

        private static ComplexNumber ReadComplexNumberFromConsole()
        {
            Console.WriteLine("Inserimento numero complesso.");
            Console.Write("Parte reale:\t");
            
            bool success = double.TryParse(Console.ReadLine(), out double real);
            

            Console.Write("Parte immaginaria:\t");
            success = double.TryParse(Console.ReadLine(), out double i);

            return new ComplexNumber();  //TODO COMPLETE
        }
    }
}