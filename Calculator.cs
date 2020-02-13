using System;

namespace Simple_Calculator
{
    public class Calculator : CalcFunctions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your operator:\nFor example - = * /");
            string operation = Console.ReadLine();

            Console.WriteLine("Your result is:");
            
            switch (operation.Trim().ToLower())
            {
                case "add":
                case "+":
                    CalculatorAdd(num1, num2);
                    break;
                case "subtract":
                case "-":
                    CalculatorSubtract(num1, num2);
                    break;
                case "mulitply":
                case "*":
                    CalculatorMultiply(num1, num2);
                    break;
                case "divide":
                case "/":
                    CalculatorDivide(num1, num2);
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized.");
                    
            }

        }

    }
}
