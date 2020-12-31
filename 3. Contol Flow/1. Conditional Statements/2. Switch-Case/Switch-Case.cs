using System;


namespace Switch_Case
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1.
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's perfect to go to beach.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }

            //Example 2.
            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
    }
}
