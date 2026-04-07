using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ItalianChef : Chef
    {
        public void makePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }

        public override void makeSpecialDish()
        {
            Console.WriteLine("The chef makes chicken parm");
        }
    }
}
