using System;
using System.IO;


namespace Path_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\Users\Sirads\Desktop\Udemy\C#\Logical+Operations.pdf";
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("FileName: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));


        }
    }
}