using System;


namespace String_Methods
{
    class String_Methods
    {
        static void Main(string[] args)
        {
            var fullName = "Samra Salkanovic ";

            //Trim()
            Console.WriteLine("Trim: '{0}'", fullName.Trim());

            //ToUpper()
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            //IndexOf(' '); Substring
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            //Split()
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            //Replace
            fullName.Replace("Samra", "SamraS");
            Console.WriteLine(fullName.Replace("Samra", "SamraS"));

            //NullChecking
            if(String.IsNullOrWhiteSpace(" "));
            Console.WriteLine("Invalid");

            //Converting String to Number
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            //Converting Number to String
            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));





        }
    }
}
