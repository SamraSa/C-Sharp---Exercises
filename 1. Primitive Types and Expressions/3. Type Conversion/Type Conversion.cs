using System;


namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1.
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            // reverse 
            int i1 = 1000;
            byte b1 = (byte)i1;
            Console.WriteLine(b1);

            //Example 2.
            var number = "1234";
            int t = Convert.ToInt32(number);
            Console.WriteLine(t);

            //Example 3.
            try
            {
                var number1 = "1234";
                byte b2 = Convert.ToByte(number1);
                Console.WriteLine(b2);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }

            // Example 4. 

            try
            {
                string str = "true";
                bool B = Convert.ToBoolean(str);
                Console.WriteLine(B);
            }
            catch (Exception)
            {
                Console.WriteLine();
            }





        }
    }
}
