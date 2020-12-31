using System;

namespace For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Example 1.
            for (var i = 1; i<= 10; i++)
            { if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Example 2.
            for (var i = 10; i >= 1; i--)
            { if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
