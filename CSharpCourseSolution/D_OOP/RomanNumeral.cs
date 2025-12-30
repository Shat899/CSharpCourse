using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{

    /*
     Write a function that takes a string — a Roman numeral — as input, and returns this number in Arabic form.
     For example, if we pass "XV", it should return 15; if we pass "IV", it should return 4.
     Here is the list of Roman symbols and their mapping to Arabic numbers:
     - I = 1
     - V = 5
     - X = 10
     - L = 50
     - C = 100
     - D = 500
     - M = 1000
     Variants like IIIV = 5 − 3 = 2 are not considered. Although the Romans sometimes used such forms, there is conflicting information about their acceptability. In our assignment, such variants are excluded.
     
     Here’s an excerpt from Wikipedia:
     “It should be noted that other subtraction methods are not allowed; for example, the number 99 must be written as XCIX, not as IC.”
     
     
     Hint:
     To solve this, you need to implement two rules:
     - If a larger numeral comes before a smaller one, they are added (principle of addition).
     - If a smaller numeral comes before a larger one, the smaller is subtracted from the larger (principle of subtraction).

     
     */
    public class RomanNumeral
    {
        private static Dictionary <char, int> map = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        public static int Pars(string roman)
        {
            int result = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && IsSubtractive(roman[i], roman[i + 1]))
                {
                    result -= map[roman[i]];
                }
                else
                {
                    result += map[roman[i]];
                }


            }
            
            return result;
        }
        private static bool IsSubtractive(char c1, char c2)
        {
            return map[c1] < map[c2];
        }
    }
    
}
