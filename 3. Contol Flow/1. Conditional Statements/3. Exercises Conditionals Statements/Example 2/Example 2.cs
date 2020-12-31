using System;

namespace Example_2
{
    class Program
    {
        /* Example 2.
        Write a program which takes two numbers from the console and displays the maximum of the two.
       */
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);
        }
    }
}
