using System;

namespace CShaprCourse
{
    class Program
    {
        static void Main(string[] args) //void --> function doesn't return any value
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
            Console.WriteLine(@string.Remove(1,5));                  //removes 5 characters starting from index 1
            Console.WriteLine(@string.Replace("a", "c"));            //replaces all occurrences of "a" with "c"
            Console.WriteLine(split[3]);                             //prints the 4th element from split array
            Console.WriteLine(chars[5]);                             //prints the 6th character from chars array
            Console.WriteLine(@string[1]);                           //prints the character at index 1 of the string
            Console.WriteLine(@string.ToLower());                    //converts string to lowercase
            Console.WriteLine(@string.ToUpper());                    //converts string to uppercase
            Console.WriteLine(@string.Trim());                       //converts string to uppercase

        }

    }


}