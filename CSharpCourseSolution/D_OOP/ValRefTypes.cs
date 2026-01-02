using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{

    // Value types are typically stored in the stack memory, and when you assign one value type to another, a copy of the value is made.
    public struct PointVal // Define a struct 
    {
        public int X;
        public int Y;

        public void LongValues()
        {
            Console.WriteLine($"X = {X} Y = {Y}");
        }
    }

    // Reference types are typically stored in the heap memory, and when you assign one reference type to another, a reference (or pointer) to the same memory location is copied.
    public class PointRef // Define a class
    {
        public int X;
        public int Y;
        public void LongValues()
        {
            Console.WriteLine($"X = {X} Y = {Y}");
        }
    }
    public struct EvilStruct
    {
        public int X;
        public int Y;

        public PointRef PointRef; // Struct containing a reference type
    }

}
