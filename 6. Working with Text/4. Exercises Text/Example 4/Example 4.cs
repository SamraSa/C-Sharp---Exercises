﻿using System;


namespace Example_4
{
    class Program
    {
        /* Example 4.
        Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable 
        name with PascalCase.For example, if the user types: "number of students", display "NumberOfStudents". 
        Make sure that the program is not dependent on the input.So, if the user types "NUMBER OF STUDENTS", the 
        program should still display "NumberOfStudents".
        */


        static void Main(string[] args)
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }
    }
}
