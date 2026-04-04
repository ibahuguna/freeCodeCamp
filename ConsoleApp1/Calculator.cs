using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
        }

        public void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
        }

        public void Multiply(double num1, double num2)
        {
            Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
        }

        public void Divide(double num1, double num2)
        {
            Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));
        }
    }
}
