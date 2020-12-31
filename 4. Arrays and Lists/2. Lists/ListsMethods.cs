using System;
using System.Collections.Generic;

namespace ListsMethods
{
    class ListsMethods
    {
        static void Main(string[] args)
        {
           //Add()
            
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);

            //AddRange()
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
                Console.WriteLine(number);

            //IndexOf()
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));

            //LastIndex()
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            //Count
            Console.WriteLine("Count: " + numbers.Count);

            //Remove()
            numbers.Remove(1);
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Remove all 1 in the array

           for (var i=0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Clear
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);





        }
    }
}
