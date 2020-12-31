using System;
using System.IO;


namespace Directory_and_DirectoryInfo
{
    class Directory_and_DirectoryInfo
    {
        static void Main(string[] args)
        {
            //Directory
            //Directory.CreateDirectory(@"c:\Users\SiradS\Desktop\folder1");
           
           /*var files = Directory.GetFiles(@"c:\Users\SiradS\Desktop\Udemy\C#","*.sln*", SearchOption.AllDirectories);
           foreach (var file in files)
           Console.WriteLine(file);
           */



          /* var directories = Directory.GetDirectories(@"c:\Users\SiradS\Desktop\Udemy\C#", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);
          */

          /*var exists = Directory.Exists(@"c:\Users\SiradS\Desktop\Udemy\C#");
            Console.WriteLine(exists);
          */

            var directoryInfo = new DirectoryInfo(@"c:\Users\SiradS\Desktop\Udemy\C#");

            /*var files = directoryInfo.GetFiles();           
            foreach (var file in files)
                Console.WriteLine(file);
            */

            var directories = directoryInfo.GetDirectories();
            foreach (var directory in directories)
                Console.WriteLine(directory);



        }
    }
}
