using System;
using System.Collections.Generic;


namespace Example_5
{
    class Program
    {
        /*Example 5.
        Write a program and ask the user to enter an English word.Count the number of vowels (a, e, o, u, i) in the word.
        So, if the user enters "inadequate", the program should display 6 on the console. ake sure the program calculates
        the number of vowels irrespective of the casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
        */


        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            // Note the ToLower() here. This is used to count for both A and a. 
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
