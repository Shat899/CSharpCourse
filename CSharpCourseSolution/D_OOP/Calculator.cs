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
    }
}
