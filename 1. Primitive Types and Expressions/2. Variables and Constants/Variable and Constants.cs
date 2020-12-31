using System;


namespace Variables_and_Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1 Variables
            // way 1.: byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Samra";
            bool isWorking = false;

            // Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // way 2.
            var number = 2;
            Console.WriteLine(number);

            //   Example 2 Variables

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // Example 3 Constants

            const float Pi = 3.14f;
            Console.WriteLine(Pi);
        }
    }
}

