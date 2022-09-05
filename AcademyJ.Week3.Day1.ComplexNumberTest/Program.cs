using AcademyJ.Week3.Day1.Lib;

namespace AcademyJ.Week3.Day1.ComplexNumberTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Complex Number test **");
            ComplexNumber c1 = ReadComplexNumberFromConsole();
            Console.WriteLine(c1);

            ComplexNumber c2 = ReadComplexNumberFromConsole();
            Console.WriteLine(c2);


            Console.WriteLine("Quale operazione vuoi svolgere (+, -, *, /):");
            string op = Console.ReadLine();
            if(op == "+")
            {
                Console.WriteLine($"Somma tra {c1} e {c2}: {c1.Add(c2)}");
            }
            else if (op == "-")
            {
                Console.WriteLine($"Differenza tra {c1} e {c2}: {c1.Sub(c2)}");
            }
            else if (op == "*")
            {
                Console.WriteLine($"Prodotto tra {c1} e {c2}: {c1.Mul(c2)}");
            }
            else if (op == "/")
            {
                Console.WriteLine($"Divisione tra {c1} e {c2}: {c1.Div(c2)}");
            }
            else
            {
                Console.WriteLine("Operazione non valida.");
            }


            Console.ReadLine();
        }

        private static ComplexNumber ReadComplexNumberFromConsole()
        {
            Console.WriteLine("Inserimento numero complesso.");
            Console.Write("Parte reale:\t");
            
            bool success = double.TryParse(Console.ReadLine(), out double real);
            

            Console.Write("Parte immaginaria:\t");
            success = double.TryParse(Console.ReadLine(), out double imaginary);

            return new ComplexNumber(real,imaginary);  
        }
    }
}