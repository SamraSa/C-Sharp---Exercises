using System;
using System.Text;


namespace String_Builder
{
    class String_Builder
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            //Append(); AppendLine();
            //creating Header
            builder.Append('-', 10);          
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            //Replace()
            builder.Replace('-', '+');

            //Remove()
            builder.Remove(0, 10);

            //Insert()

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            //Index
            Console.WriteLine("First Char: " + builder[0]);


        }
    }
}
