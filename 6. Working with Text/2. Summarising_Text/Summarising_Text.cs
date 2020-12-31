using System;
using System.Collections.Generic;


namespace Summarising_Text
{
    class Summarising_Text
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be really really really really really long text";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);
        }      
    }
}
