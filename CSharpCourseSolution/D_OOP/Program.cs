using System;

namespace D_OOP 
{
    
    class Program
    {
        static void Main(string[] args) //void --> function doesn't return any value
        {                                            //"exmplare"
            Character c = new Character(); // Create an instance of Character class "exmplare"
            c.Hit(10);                     // Call the Hit method on the Character instance
            Console.WriteLine(c.Health);   // Print the current health of the character with property
        }
}   }