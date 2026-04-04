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

        public void Calculate()
        {
            double num1, num2;
            string operation, input1, input2;
            string cont = "y";
            while (cont == "y" || cont == "Y")
            {
                Console.Write("Enter first number : ");
                input1 = Console.ReadLine();
                if (!Double.TryParse(input1, out num1))
                {
                    Console.WriteLine("Invalid input, please try again.");
                    continue;
                }

                while (true)
                {
                    Console.Write("Enter second number : ");
                    input2 = Console.ReadLine();
                    if (!Double.TryParse(input2, out num2))
                    {
                        Console.WriteLine("Invalid input, please try again.");
                        continue;
                    }
                    break;
                }

                Console.Write("Select operation (+, -, *, /) : ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Add(num1, num2);
                        break;
                    case "-":
                        Subtract(num1, num2);
                        break;
                    case "*":
                        Multiply(num1, num2);
                        break;
                    case "/":
                        if (num2 != 0)
                            Divide(num1, num2);
                        else
                            Console.WriteLine("Cannot divide by 0!");
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        break;
                }
                Console.Write("Do you want to try again? (y/n) : ");
                cont = Console.ReadLine();
            }

        }
    }
}
