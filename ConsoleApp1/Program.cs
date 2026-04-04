using ConsoleApp1;

Calculator calculator = new Calculator();
double num1, num2;
string operation;
string cont = "y";
while (cont == "y" || cont == "Y")
{
    Console.Write("Enter a number : ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter another number : ");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Select operation (+, -, *, /) : ");
    operation = Console.ReadLine();

    switch(operation){
        case "+":
            calculator.Add(num1, num2);
            break;
        case "-":
            calculator.Subtract(num1, num2);
            break;
        case "*":
            calculator.Multiply(num1, num2);
            break;
        case "/":
            if (num2 != 0)
                calculator.Divide(num1, num2);
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
