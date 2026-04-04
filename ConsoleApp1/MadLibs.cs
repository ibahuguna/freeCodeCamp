using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class MadLibs
    {
        string color, pluralNoun, celebrity;

        public void play()
        {
            Console.Write("Enter a color : ");
            color = Console.ReadLine();
            Console.Write("Enter a plural Noun : ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity : ");
            celebrity = Console.ReadLine();

            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I Love {celebrity}");

            Console.ReadLine();

        }

    }
}
