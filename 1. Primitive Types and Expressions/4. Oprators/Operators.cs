using System;


namespace Oprators
{
    class Program
    {
        static void Main(string[] args)
        {

         //Example 1.
          var a = 10;
          var b = 3;
                Console.WriteLine(a + b);
                Console.WriteLine(a / b);
                Console.WriteLine((float)a / (float)b);

            // Example 2. 
            var s = 1;
            var m = 2;
            var n = 3;

            Console.WriteLine(s + m * n);
            Console.WriteLine((s + m) * n);
            Console.WriteLine(s > m);
            Console.WriteLine(s == m);
            Console.WriteLine(s != m);
            Console.WriteLine(!(s != m));
            Console.WriteLine(n > m && m > s);
            Console.WriteLine(n > m && n == s);
            Console.WriteLine(n > m || n == s);
            Console.WriteLine(!(n > m || n == s));
        }
    }
            
    
}
