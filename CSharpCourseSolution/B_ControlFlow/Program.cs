using System;
using System.Diagnostics.Metrics;
using System.Text;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace CShaprCourse
{
    class Program
    {
        static void Main(string[] args) //void --> function doesn't return any value
        {

        }
        static void HowmeWork2() //void --> function doesn't return any value
        {

            /*First two numbers - units. All subsequent numbers are calculated as the sum of the previous two
              Task: ask the user how many Fibonacci numbers he wants to generate (calculate), and actually generate
              (calculate). In the generation process, write the numbers to the array. After generation, 
              display the calculated numbers.*/

            int counter = new int();
            Console.WriteLine("Enter the number of Fibonacci numbers");
            counter = int.Parse(Console.ReadLine());
            int[] numbers = new int[2 + counter];
            numbers[0] = 1;
            numbers[1] = 1;

            for (int i = 1; i <= counter; i++)
            {
                numbers[i + 1] = numbers[i - 1] + numbers[i];
            }


            foreach (var val in numbers)
            {
                Console.Write(val + " ");
            }

            Console.ReadLine();


            /* Prompt the user for up to 10 positive integers. The user can stop accepting numbers by entering 0.
               After the user stops accepting integers (this happens if 10 numbers have been entered, or if the user 
               enters 0 to avoid entering all 10), calculate the average of positive integers that are multiples of three
               and display it on the console.*/
            bool exit = false;
            int[] averageNumbers = new int[10];
            int average = new int();
            while (averageNumbers.Length <= 10)
            {
                Console.WriteLine("Calculate average");
                Console.WriteLine("Input 10 integer numbers. If you want to stop before reaching 10, type 0.");
                for (int i = 0; i < averageNumbers.Length; i++)
                {
                    averageNumbers[i] = int.Parse(Console.ReadLine());
                    if (averageNumbers[i] == 0)
                    {
                        exit = true;
                        break;
                    }

                }

                if (exit == true || averageNumbers.Length <= 10)
                {
                    Console.WriteLine($"Average: {averageNumbers.Where(n => n != 0).Average()}");// LINQ method to calculate average excluding zeros
                    break;
                }
            }


            /*The factorial of a number is the product of that number and all the numbers preceding it (except 0).
              In mathematics, a factorial is written with an exclamation point. 
              For example, 5! = 5 * 4 * 3 * 2 * 1 = 120. Special cases: 0! = 1. 1! = 1.

              Problem: Prompt the user for the number whose factorial needs to be calculated and perform the calculation. 
              Then display the result. There's no need to prompt for an exclamation point; besides, there's no such operation in C#. 
              To calculate a factorial, multiplication is required.*/
            Console.WriteLine("Insert number for factorial");
            int nFactorial = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 2; i <= nFactorial; i++)
            {
                factorial *= i;  // means: x = x * y
            }

            Console.WriteLine($"Factorial{factorial} fro {nFactorial}");


            /*Let's assume the login/password for logging in is johnsilver/qwerty.Prompt the user for their login and password. Give the user only three attempts to enter the correct login/password pair. 
             * If the user enters the correct password, print "Enter the System" to the console and stop prompting for the login/password. If the user makes three incorrect attempts, print "The number of 
             * available tries has been exceeded" and stop prompting for the login/password pair.*/

            int atemps = 3;
            string logIn = string.Empty;
            string password = string.Empty;
            string[] credentials = { "johnsilver", "qwerty" };
            bool islogIn = false;

            for (int i = 0; i < atemps; i++)
            {

                Console.WriteLine("Enter login: ");
                logIn = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();

                if (logIn == credentials[0] && password == credentials[1])
                {
                    islogIn = true;
                    break;

                }

            }

            if (islogIn)
            {
                Console.WriteLine("Welcome to the system");
            }
            else
            {
                Console.WriteLine("The number of available tries have been exceeded");
            }

        }

        static void CyclesAndSwich() //void --> function doesn't return any value
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.Write(numbers[i] + " "); // Print numbers in a single line

            }
            

            for (int i = numbers.Length - 1; i >= 0; i--)
            {

                Console.Write(numbers[i] + " "); // Print numbers in a single line in reverse order
            }
            

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) // Check if the number is even
                {

                    Console.Write(numbers[i] + " "); // Print even numbers in a single line

                }
                

            }
            

            foreach (int val in numbers)
            {

                Console.Write(val + " "); // Print numbers using foreach loop without index
            }
            

            for (int i = 0; i < numbers.Length - 1; i++) // Find pairs that sum to zero
            {
                for (int j = i + 1; j < numbers.Length; j++) // Start j from i + 1 to avoid duplicate pairs and self-pairing using cicles in cicles
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0) // Check if the sum of the pair is zero
                    {
                        Console.WriteLine($"Pair found: {atI}, {atJ}"); // Print the pair
                    }
                    
                }
                
            }
            

            for (int i = 0; i < numbers.Length - 2; i++) // Find pairs that sum to zero
            {

                for (int j = i + 1; j < numbers.Length - 1; j++) // Start j from i + 1 to avoid duplicate pairs and self-pairing using cicles in cicles
                {
                    for (int k = j + 1; k < numbers.Length; k++) // Start k from j + 1 to avoid duplicate pairs and self-pairing using cicles in cicles
                    {
                        int atI1 = numbers[i];
                        int atJ2 = numbers[j];
                        int atK = numbers[k];
                        if (atI1 + atJ2 + atK == 0) // Check if the sum of the pair is zero
                        {
                            Console.WriteLine($"Triplet found: {atI1}, {atJ2}, {atK}"); // Print the pair
                        }
                        ;
                    }
                    ;

                    int atI = numbers[i];
                    int atJ = numbers[j];
                }
                

            }
            

            // while: Checks the condition before executing the code block (Pre-test loop).
            // do -while: Executes the code block once and then checks the condition(Post-test loop).

            int age = new int();
            while (age < 18) // Check if the number is even
            {
                Console.WriteLine("Please enter your age: ");
                age = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Good !!!");

            do // Check if the number is even
            {
                Console.WriteLine("Please enter your age: ");
                age = int.Parse(Console.ReadLine());

            } while (age < 18); // Check if the number is even

            Console.WriteLine("Good !!!");

            int[] intNumbers = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };
            char[] leters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

            for (int i = 0; i < intNumbers.Length; i++)
            {
                Console.WriteLine($"Number={numbers[i]};");

                for (int j = 0; j < leters.Length; j++)
                {
                    if (intNumbers[i] == j)
                        break; // exit the inner loop when condition is met
                    Console.WriteLine($"Leter={leters[j]};");
                };
            };

            foreach (int n in intNumbers)
            {
                if (n % 2 != 0)
                    continue; //The continue statement is used to skip the rest of the current iteration and jump immediately to the next evaluation of the loop's condition.
                Console.WriteLine($"Even Number={n};");
            }
            

            Console.WriteLine("How long have you are married?");
            int weaddingYears = int.Parse(Console.ReadLine());
            string str = string.Empty;

            switch (weaddingYears)
            {                             // switch statement
                case 1:
                    str = "You are newlyweds";
                    break;
                case 5:
                    str = "You have a small family";
                    break;
                case 10:
                    str = "You are an experienced couple";
                    break;
                case 20:
                    str = "You are an example for others";
                    break;
                default:
                    str = "You have a good relationship";
                    break;
            }
            
            Console.WriteLine(str);

            Console.WriteLine("Please enter month number (1-12): ");
            int month = new int();
            string season = string.Empty;
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    season = "Invalid month number";
                    break;
            }
            
        }
        static void ControlFlowShowcase() //void --> function doesn't return any value
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
        static void ControlFlowDeom() //void --> function doesn't return any value
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

    };

};