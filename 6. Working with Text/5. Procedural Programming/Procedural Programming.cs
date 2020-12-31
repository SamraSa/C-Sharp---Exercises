using System;


namespace Procedural_Programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* Example
            Console.Write("What's your name? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var = name.Length; if > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
            */

            //Procedural Programming

            Console.Write("What's your name? ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: " + reversed);
        }

        public static string ReverseName(string name)
        {             
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                 array[name.Length - i] = name[i - 1];

            return new string(array);

        }
    }
}
