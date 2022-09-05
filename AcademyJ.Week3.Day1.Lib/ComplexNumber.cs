using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyJ.Week3.Day1.Lib
{
    public class ComplexNumber
    {
        public double Real { get;}
        public double Imaginary { get;}

        //public ComplexNumber Conjugated
        //{
        //    get
        //    {
        //        return new ComplexNumber(Real, -Imaginary);
        //    }
        //}
        public ComplexNumber Conjugated => new ComplexNumber(Real, -Imaginary);

        public double Module => Math.Sqrt(Real * Real + Imaginary * Imaginary);


        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public ComplexNumber() : this(0,0)
        {
            //Real = 0;
            //Imaginary = 0;
        }

        public ComplexNumber(double real) : this(real,0)
        {

        }

        public override string ToString()
        {
            if (Real == 0 && Imaginary == 0)
                return "0";

            if (Real == 0)
                return $"{Imaginary}i";

            if(Imaginary == 0)
                return $"{Real}";

            if(Imaginary < 0)
                return $"{Real} - {Math.Abs(Imaginary)}i";

            return $"{Real} + {Imaginary}i";
        }

        public ComplexNumber Add(ComplexNumber c)
        {
            return new ComplexNumber(this.Real + c.Real, Imaginary + c.Imaginary);
        }

        public ComplexNumber Sub(ComplexNumber c)
        {
            return new ComplexNumber(this.Real - c.Real, Imaginary - c.Imaginary);
        }

        public ComplexNumber Mul(ComplexNumber c)
        {
            return new ComplexNumber(this.Real*c.Real - Imaginary*c.Imaginary, Real * c.Imaginary + Imaginary * c.Real);
        }

        public ComplexNumber Div(ComplexNumber c)
        {
            double den = Math.Pow(c.Real, 2) + Math.Pow(c.Imaginary, 2);
            return new ComplexNumber((Real * c.Real + Imaginary * c.Imaginary)/den, (Real * c.Imaginary - Imaginary * c.Real)/den);
        }
    }
}
