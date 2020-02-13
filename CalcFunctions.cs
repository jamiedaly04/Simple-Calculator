using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Calculator
{
    public class CalcFunctions
    {
        ConsoleKey input;
        public static int CalculatorAdd(int num1, int num2)
        {
            int answer = num1 + num2;
            Console.WriteLine("Your result is: {0}", answer);
            return answer;
        }

        public static int CalculatorSubtract(int num1, int num2)
        {
            int answer = num1 - num2;
            Console.WriteLine("Your result is: {0}", answer);
            return answer;
        }

        public static int CalculatorMultiply(int num1, int num2)
        {
            int answer = num1 * num2;
            Console.WriteLine("Your result is: {0}", answer);
            return answer;
        }

        public static int CalculatorDivide(int num1, int num2)
        {
            int answer = num1 / num2;
            Console.WriteLine("Your result is: {0}", answer);
            return answer;
        }


        public static void restartChoice()
        {
            CalcFunctions accessor = new CalcFunctions();
            Console.WriteLine("\nWould you like to restart your application? Y/N");
            accessor.input = Console.ReadKey().Key;

            while (accessor.input != ConsoleKey.N)
            {
                if (accessor.input == ConsoleKey.Y)
                {
                    appDialog();
                    Console.WriteLine("\nWould you like to restart your application? Y/N");
                    accessor.input = Console.ReadKey().Key;
                }
            }
        }


        public static void appDialog()
        {
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("Enter your first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter your second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter your operator:\nFor example - = * /");
            string operation = Console.ReadLine();

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
                    try
                    {
                        CalculatorDivide(num1, num2);
                    } catch
                    {
                        Console.WriteLine("\nMake sure you arent diving by zero!");
                    }
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized.");
            }

        }
    }
}
