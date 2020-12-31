using System;

namespace Random_Class
{
    class Program
    {
        static void Main(string[] args)
        {
           //Example 1.
            var random = new Random();
            for (var i = 0; i < 10; i++)
          /*random numbers
            Console.WriteLine(random.Next());
           */
            Console.WriteLine(random.Next(1, 10));
           
            //ACII a = 97
            Console.WriteLine((int)'a');

            Console.Write((char)random.Next(97, 122));
            Console.WriteLine();

            //Example 2.

            //var random = new Random();
            const int passwordLength = 10;

            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);

        }
    }
}
