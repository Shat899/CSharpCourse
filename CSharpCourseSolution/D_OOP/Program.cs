using System;


namespace D_OOP 
{
    
    class Program
    {
        static void Main(string[] args) //void --> function doesn't return any value
        {                                            //"exmplare"
            Character c = new Character(); // Create an instance of Character class "exmplare"
            //c.Hit(10);                     // Call the Hit method on the Character instance
            //Console.WriteLine(c.Health);   // Print the current health of the character with property

            Calculator Calc = new Calculator();
            double area1 = Calc.CalcTriangleSquareby(ab:3, bc:4, ac:5);        // Call the method with named arguments
            double average1 = Calc.Average1(new int[] { 10, 20, 30, 40, 50 }); // Call the Average method where we pass an array of integers
            double average2 = Calculator.Average2(10, 20, 30, 40, 50);         // Call the Average method where we pass a variable number of integer arguments
                                                                               // Call Average2 with params keyword without creating instance of Calculator class

            bool tryDivideResult = Calc.TryDivide(10, 2, out double resault); // Call the TryDivide method with out parameter
            Console.WriteLine(tryDivideResult);                               // Print whether the division was successful
            Console.WriteLine(resault);                                       // Print the result of the division

            // Value types is stored in stack memory and reference types is stored in heap memory
            PointVal a1; // Creating value type instance
            a1.X = 3;
            a1.Y = 5;
            PointVal a2 = a1; // Copying value type
            a2.X = 7;
            a2.Y = 10;
            a1.LongValues();
            a2.LongValues();



            PointRef b1 = new PointRef(); // Creating reference type instance
            b1.X = 3;
            b1.Y = 5;
            PointRef b2 = b1; // Copying reference type
            b2.X = 7;
            b2.Y = 10;
            b1.LongValues();
            b2.LongValues();

            EvilStruct es1 = new EvilStruct();
            es1.PointRef = new PointRef() { X = 1, Y = 2 }; // Object initializer syntax to set properties
            EvilStruct es2 = es1;                           // Copying the struct

            Console.WriteLine($"X = {es1.PointRef.X} Y = {es1.PointRef.Y}");
            Console.WriteLine($"X = {es2.PointRef.X} Y = {es2.PointRef.Y}");

            // structs are value types, so modifying es2.PointRef will affect es1.PointRef because both es1 and es2 contain a reference to the same PointRef object

        }

    }
}   