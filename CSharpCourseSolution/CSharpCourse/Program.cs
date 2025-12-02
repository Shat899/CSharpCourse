using System;
using System.Text;
using System.Threading.Channels;

namespace CShaprCourse
{
    class Program
    {
        static void Main(string[] args) //void --> function doesn't return any value
        {
            // Fitst Point of Home Work
            Console.WriteLine("Hi whats your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            // Second Point of Home Work
            int a = new int();
            int b = new int();
            int c = new int();
            int d = new int();
            Console.WriteLine("Plese enter 2 integer Number");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"After swapping: a = {a}, b = {b}");
            // Third Point of Home Work
            Console.WriteLine("Ples enter integer with contait 4 or more characters");
            d = int.Parse(Console.ReadLine());
            string dLength = d.ToString();
            Console.WriteLine(dLength.Length);
            
            // Heron's Formula
            Console.WriteLine("Please Enter sides of a triangle");
            Console.WriteLine("Side A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Side B");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Side C");
            c = int.Parse(Console.ReadLine());
            d = (a + b + c) / 2;
            Console.WriteLine($"The area is {d}");

            // User Profile
            string profileFirstName = new string("");
            string profileLastName = new string("");
            int profileAge = new int();
            double profileHeight = new int();
            double profileWeight = new int();
            double bodyMassIndex = new int();

            Console.WriteLine("Please Enter your Profile Information");
            Console.WriteLine("What is your First Name?");
            profileFirstName = Console.ReadLine();
            Console.WriteLine("What is your Last Name?");
            profileLastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            profileAge = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your Weight in kg?");
            profileWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your Height in cm?");
            profileHeight = double.Parse(Console.ReadLine());
            bodyMassIndex = profileWeight / profileHeight * profileHeight;

            Console.WriteLine($"Your Profile:\nFull Name: {profileFirstName} {profileLastName}\nAge: {profileAge}\nWeight: {profileWeight}\nHeight: {profileHeight}\nBody Mass Index: {bodyMassIndex}");



        }

        static void DateTimeDemo()
        {
            DateTime now = DateTime.Now;     // Get the current date and time
            int sec = now.Second;            // Get the current second
            DateTime dt = new DateTime(2023, 1, 1); // Create a new DateTime object for January 1, 2023
            DateTime newDt = dt.AddDays(10); // Add 10 days to the DateTime object
            TimeSpan tS = newDt - dt;        // Calculate the difference between two DateTime objects
        }

        static void ArrayAndStringManipulationDemo()
        {
            int[] a1 = new int[10];                    //declaration and instantiation of an array of integers with 10 elements   
            int[] a2 = new int[5] { 1, 2, 3, 4, 5 }; //declaration, instantiation and initialization of an array of integers with 5 elements
            int[] a3 = { 1, 2, 3, 4, 5, 6 };           //declaration and initialization of an array of integers with 6 elements
            int number = a3[2];                       //accessing the 3rd element of the array a3
            a3[4] = 10;                                //modifying the 5th element of the array a3
            int length = a3.Length;                    //getting the length of the array a3
            int index = a3.Length - 1;                 //getting the index of the last element of the array a3

            string s1 = "Hello";                       //declaration and initialization of a string
            char c = s1[1];                            //accessing the 2nd character of the string s1
            char d = s1[s1.Length - 1];               //getting the index of the last character of the string s1
        }

        static void DemoTypeConversions()
        {
            byte b = new byte();
            int i = 3;
            float f = 3.0f;
            string s = "1";

            b = (byte)i;        // convert int to byte
            i = (int)f;         // convert float to int
            i = int.Parse(s);   // parse string to int

            Console.WriteLine(f);
        }

        static void DemoStringFormat()
        {
            string name = "Jhon";
            int age = 30;
            string str1 = string.Format("My name is {0} and I am {1}", name, age); // string interpolation
            string str2 = $"My name is {name} and I am {age}";                     // string interpolation
            string str3 = "My name is \nJohn";                                     // escape sequence for new line
            string str4 = "My name is \tJohn";                                     // escape sequence for tab
            string str5 = "I am \"good\" programer";                               // escape sequence for double quote
            string str6 = "C:\\Users\\Jhon";                                       // escape sequence for backslash
            string str7 = @"C:\Users\Jhon";                                        // verbatim string literal

            int answer = 42;
            string result = string.Format("{0:d}", answer);                        // Decimal format
            string result2 = string.Format("{0:d4}", answer);                      // Decimal with leading zeros

            result = string.Format("{0:f}", answer);                               // fixed-point format
            result2 = string.Format("{0:f4}", answer);                             // fixed-point format

            double money = 12.8;
            result = string.Format("{0:c}", money);                                // currency format
            Console.WriteLine(money.ToString("C2"));                               // currency format with 2 decimal places
        }
        static void DemonstrateStringOperations()
        {
            Console.WriteLine("Hello, World!");
            string name = "Exemplare"; // Variable ''name'' is an exemplar of type string
            name.ToArray(); // .ToArray is a static method available for exmplare string 

            string @string = " abcdhgfh";
            string withSpace = " ";
            string nullString = null;
            string abc = string.Concat("a", "b", "c"); // concat is a static method of string class
            string data = "12;28;34;25;64";
            string[] split = new string[0];
            char[] chars = new char[0];



            split = data.Split(';'); // splits the string data at each ';' and stores in array split
            chars = data.ToCharArray(); // converts string data to char array

            Console.WriteLine(int.MinValue);
            Console.WriteLine(@string.Contains("a"));                //checks if string contains "a"
            Console.WriteLine(@string.EndsWith("fg"));               //checks if string ends with "fg"
            Console.WriteLine(@string.StartsWith("x"));              //checks if string starts with "x"
            Console.WriteLine(@string.IndexOf("d"));                 //returns the index of first occurrence of "d"
            Console.WriteLine(@string.Length);                       //returns the length of the string
            Console.WriteLine(@string.Substring(0, 5));              //returns substring from index 0 to 5
            Console.WriteLine(string.IsNullOrEmpty(nullString));     //checks if string is null or empty
            Console.WriteLine(string.IsNullOrWhiteSpace(withSpace)); //checks if string is null or whitespace
            Console.WriteLine(string.Join(" ", "My", "Name", "is")); //joins strings with space separator
            Console.WriteLine(@string.Insert(5, "By"));              //inserts "By" at index 5
            Console.WriteLine(@string.Remove(1, 5));                  //removes 5 characters starting from index 1
            Console.WriteLine(@string.Replace("a", "c"));            //replaces all occurrences of "a" with "c"
            Console.WriteLine(split[3]);                             //prints the 4th element from split array
            Console.WriteLine(chars[5]);                             //prints the 6th character from chars array
            Console.WriteLine(@string[1]);                           //prints the character at index 1 of the string
            Console.WriteLine(@string.ToLower());                    //converts string to lowercase
            Console.WriteLine(@string.ToUpper());                    //converts string to uppercase
            Console.WriteLine(@string.Trim());                       //converts string to uppercase

            StringBuilder sb = new StringBuilder();                  // Creating an instance of StringBuilder class
            sb.Append("Hello");                                      // Appending "Hello" to the StringBuilder   
            sb.Append(" World");                                     // Appending " World" to the StringBuilder  
            sb.AppendLine("!!!");                                    // Appending "!" with a new line to the StringBuilder
            string str = sb.ToString();                              // Converting StringBuilder to string
        }
    }


}