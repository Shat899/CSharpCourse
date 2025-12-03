using System;
using System.Text;
using System.Threading.Channels;

namespace CShaprCourse
{
    class Program
    {
        static void Main(string[] args) //void --> function doesn't return any value
        {


        }
        static void HomeWork2() //void --> function doesn't return any value
        {


            int firstNumber = new int();
            int secondNumber = new int();
            string result = new string("");
            Console.WriteLine("Please Enter 2 integer numbers");
            firstNumber = int.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());

            result = firstNumber > secondNumber ? $"First number {firstNumber} is begger then second Number {secondNumber}" :
                                                  $"Second number {secondNumber} is begger then first Number {firstNumber}";
            Console.WriteLine(result);
        }
        static void  ControlFlowDeom() //void --> function doesn't return any value
        {

            int profileAge = new int();
            double profileWeight = new double();
            double profileHeight = new double();
            double bodyMassIndex = new double();
            bool isToLooLow = new bool();
            bool isNormal = new bool();
            bool isAboveNormal = new bool();
            bool isToFat = new bool();
            bool isFat = new bool();
            Console.WriteLine("How old are you?");
            profileAge = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your Weight in kg?");
            profileWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your Height in m?");
            profileHeight = double.Parse(Console.ReadLine());
            bodyMassIndex = profileWeight / (profileHeight * profileHeight);

            isToLooLow = bodyMassIndex <= 18.5;
            isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;           // use logical AND operator
            isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
            isToFat = bodyMassIndex > 30;
            isFat = isAboveNormal || isToFat;                                   // use logical OR operator
            string description = new string("");

            if (isFat)                                                          //use if statement
            {
                Console.WriteLine("You'd better lose some weight");
            }
            else                                                              // use else statement
            {
                Console.WriteLine("You are in a good shape");
            }

            description = profileAge < 18 ? "You are a minor" : "You are an adult";  // use conditional operator

        }






    }


}