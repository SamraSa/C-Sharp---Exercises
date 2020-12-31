using System;

namespace Strings
{
    class Strings
    {
        static void Main(string[] args)
        {
           // Example 1.
            var firstName = "Samra";
            var lastName = "Salkanovic";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            //Example 2.

            var names = new string[3] {"John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            //Example 3.

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            //better way
            var text1 = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text1);

        }
    }
}
