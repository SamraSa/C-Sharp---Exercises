using System;

namespace Foreach_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1.
            //Way 1.
            var name = "Samra Salkanovic";
            
            /*for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            */

            //Way 2. Foreach Loop
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 1, 2, 3, 4 };
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
