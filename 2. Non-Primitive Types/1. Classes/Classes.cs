using System;

namespace Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
    class Classes
    {
        static void Main(string[] args)
        {
            var samra = new Person();
            samra.FirstName = "Samra";
            samra.LastName = "Salkanovic";
            samra.Introduce();

        }
    }
}
