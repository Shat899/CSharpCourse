using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Calculator
    {
        // Method overloading example
        public double CalcTriangleSquareby(double ab, double bc, double ac)  // method returns doble value, and cames with three parameters
        {
            
           double p = (ab + bc + ac) / 2;
           return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));

        }

        public double CalcTriangleSquare(double b, double h)             // method returns doble value, and cames with two parameters
        {
            return 0.5 * b * h;
        }

        public double CalcTriangleSquare(double ab, double ac, int alpha ,bool isInRadians = false)   // method returns doble value, and cames with two parameters / isInRadians has default value false optional parameter
        {
            if (isInRadians)
            {
                return 0.5 * ab * ac * Math.Sin(alpha);
            }
            else
            {
                double radians = (Math.PI / 180) * alpha;
                return 0.5 * ab * ac * Math.Sin(radians);
            }

        }

        public double Average1(int[] numbers) // create a method that calculates the average of an array of integers
        {
            double sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }  

            return sum / numbers.Length;
        }
        public static double Average2(params int[] numbers) // create a method that calculates the average of an array of integers with params keyword 
        {                                                   //static - we can call this method without creating an instance of the class
            double sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }

            return sum / numbers.Length;
        }

        public bool TryDivide(double divisible, double divisor, out double resault) // create a method with out parameter
        {
            resault = 0;
            if (divisor == 0)
            {
                return false;
            }
            resault = divisible / divisor;
            return true;
        }
    }
}
