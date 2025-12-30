using System;

namespace D_OOP 
{
    
    class Program
    {
        static void Main(string[] args) //void --> function doesn't return any value
        {                                            //"exmplare"
            //Character c = new Character(); // Create an instance of Character class "exmplare"
            //c.Hit(10);                     // Call the Hit method on the Character instance
            //Console.WriteLine(c.Health);   // Print the current health of the character with property

            Calculator Calc = new Calculator();
            double average1 = Calc.Average1(new int[] { 10, 20, 30, 40, 50 }); // Call the Average method where we pass an array of integers
            double average2 = Calc.Average2(10, 20, 30, 40, 50);               // Call the Average method where we pass a variable number of integer arguments
        }


}   }