using System;
using System.Collections.Generic;

namespace CShaprCourse
{
    class Program
    {
        static void Main(string[] args) //void --> function doesn't return any value
        {


        }
        static void DemonstrateDataStructures()
        {

            //1,2,3
            //4,5,6
            int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } }; // declaration and instantiation of a 2D array with 2 rows and 3 columns
            int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };               // declaration and initialization of a 2D array with 2 rows and 3 columns
            for (int i = 0; i < r1.GetLength(0); i++) // Iterating through the rows of the 2D array
            {
                for (int j = 0; j < r1.GetLength(1); j++) // Iterating through the columns of the 2D array
                {
                    Console.Write(r1[i, j] + " "); // Printing each element followed by a space
                }
                Console.WriteLine(); // Moving to the next line after each row
            }

            int[][] jaggedArray = new int[4][]; // declaration of a jagged array with 4 rows
            jaggedArray[0] = new int[2] { 1, 2 };          // initializing the first row with 2 elements
            jaggedArray[1] = new int[3] { 3, 4, 5 };       // initializing the second row with 3 elements
            jaggedArray[2] = new int[4] { 6, 7, 8, 9 };    // initializing the third row with 4 elements
            jaggedArray[3] = new int[2] { 10, 11 };        // initializing the fourth row with 2 elements

            for (int i = 0; i < jaggedArray.Length; i++) // Iterating through the rows of the jagged array
            {
                for (int j = 0; j < jaggedArray[i].Length; j++) // Iterating through the columns of each row
                {
                    Console.Write(jaggedArray[i][j] + " "); // Printing each element followed by a space
                }
                Console.WriteLine(); // Moving to the next line after each row
            }


            var queue = new Queue<int>(); // Creating a queue of integers
            queue.Enqueue(1);              // Enqueuing an element into the queue
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Peek();                 // Peeking at the front element of the queue without removing it
            queue.Dequeue();              // Dequeuing the front element from the queue "remove" and return it

            /*
             A Queue is a data structure that works like a real‑life line:
             - You add items at the end → Enqueue
             - You remove items from the front → Dequeue
             - You look at the first item → Peek
             The rule is FIFO: First In, First Out.
             */


            var stack = new Stack<int>();  // Creating a stack of integers
            stack.Push(1);                 // Pushing an element onto the stack
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Peek();                // Peeking at the top element of the stack without removing it
            stack.Pop();                 // Popping the top element off the stack "remove" and return it

            foreach (var item in stack) // Iterating through the elements in the stack
            {
                Console.WriteLine(item);
            }

            /* 
             What a Stack Is (Beginner Level)
             A Stack is a simple data structure that works like a stack of plates:
             - You add items on top → Push
             - You remove the top item → Pop
             - You look at the top item without removing it → Peek
             The rule is LIFO: Last In, First Out.             
             */


            int[] a1;                        // declaration of an array of integers
            a1 = new int[10];               // instantiation of an array of integers with 10 elements
            int[] a2 = new int[5];           // declaration and instantiation of an array of integers with 5 elements
            int[] a4 = { 1, 2, 3 };          // declaration and initialization of an array of integers with 3 elements
            int[] a3 = { 1, 2, 3, 4, 5, 6 }; // declaration and initialization of an array of integers with 6 elements

            Array myArray2 = Array.CreateInstance(typeof(int), 10); // Creating an instance of Array class with 10 elements of type int

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.IndexOf(numbers, 5);       // Finding the index of element '5' in the array
            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);   // Copying elements from 'numbers' array to 'copy' array
            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0);                 // Copying elements from 'copy' array to 'anotherCopy' array
            Array.Reverse(numbers);                       // Reversing the elements of 'numbers' array
            Array.Sort(copy);                             // Sorting the elements of 'copy' array
            Array.Clear(anotherCopy, 0, anotherCopy.Length); // Clearing all elements of 'anotherCopy' array

            /* array is data structure type
                An array in C# is a way to store many values in one variable instead of creating separate variables for each value.
                Think of an array like a row of numbered boxes.
                Each box holds one value, and each box has a number called an index.*/



            var intList = new List<int>() { 1, 4, 2, 7, 5, 9, 12 }; // Creating a list of integers and initializing it with some values
            intList.Add(15);               // Adding an element to the list
            int[] intArray = { 1, 2, 2 };
            intList.AddRange(intArray);           // Adding multiple elements to the list from an array
            intList.Remove(2);                   // Removing the first occurrence of element '2' from the list returns bool
            intList.RemoveAt(0);                 // Removing the element at index 0 from the list
            intList.Reverse();                   // Reversing the order of elements in the list
            intList.Contains(5);                 // Checking if the list contains a specific element returns bool  
            intList.Max();                       // Finding the maximum element in the list 
            intList.Min();                       // Finding the minimum element in the list
            intList.IndexOf(7);               // Finding the index of element '7' in the list 
            intList.LastIndexOf(2);           // Finding the last index of element '2' in the list
            int listCount = intList.Count;              // Getting the number of elements in the list

            /*
                data structure type collection
                A List in C# is like a smarter, more flexible version of an array.
                If an array is a row of fixed boxes,
                a List is a row of boxes that can grow or shrink whenever you need.

             */


            var people = new Dictionary<int, string>(); // Creating a dictionary with int keys and string values
            people.Add(1, "John");               // Adding a key-value pair to the dictionary
            people.Add(2, "Jane");
            people.Add(3, "Sam");

            people = new Dictionary<int, string>()
            {
                {2, "Bob" },
                {5, "Alice" },  // Initializing a dictionary with key-value pairs
                {6, "Sam" }
            };

            string name = people[2];            // Accessing the value associated with key '2'
            var keys = people.Keys;               // Getting all keys in the dictionary
            var values = people.Values;           // Getting all values in the dictionary
            Console.WriteLine(values);

            int peopleCount = people.Count;                   // Getting the number of key-value pairs in the dictionary
            bool hasKey = people.ContainsKey(3);        // Checking if the dictionary contains a specific key returns bool
            bool hasValue = people.ContainsValue("Alice"); // Checking if the dictionary contains a specific value returns bool
            people.Remove(1);                  // Removing the key-value pair with key '1' returns bool
            people.TryAdd(2, "Marta");               // Trying to add a key-value pair, returns false if the key already exists

            if (people.TryGetValue(2, out var value)) // Trying to get the value associated with key '2'
            {
                Console.WriteLine(value);
            }
            /*
              data structure type 
              A Dictionary in C# is a collection that stores pairs of value

             */

        }
    };

};