using System;


namespace If_Else_and_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1.
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >=12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's everning.");
            }

            //Example 2.
            //way 1.
            bool isGoldCustomer = true;

            /*float price;
            if (isGoldCustomer)
                Console.WriteLine(price = 19.95f);
            else
                Console.WriteLine(price = 29.95f);
            */
            //way 2.
            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);


        }
    }
}
