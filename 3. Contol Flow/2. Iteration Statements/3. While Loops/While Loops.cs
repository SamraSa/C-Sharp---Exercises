using System;


namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Example 1. 
             Way 1.
             for (var i = 1; i <= 10; i++)
            {
            if (i % 2 == 0)
            Console.Writeline(i);
            }
            */

            //Way 2.
            //While Loop
            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);

                i++;
            }

            //Example 2.

            //Way 1.
           while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine("@Echo: " + input);
            }

            //Way 2.

            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;

                }

                break;

            }

        }
    }
}
