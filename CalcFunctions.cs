using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Calculator
{
    public class CalcFunctions : Calculator
    {
        //Adds together two input values and returns result
        public static int CalculatorAdd(int num1, int num2)
        {
            int answer = num1 + num2;
            Console.WriteLine("Your result is: {0}", answer);
            return answer;
        }

        //Subtracts second input value from first input value and returns result
        public static int CalculatorSubtract(int num1, int num2)
        {
            int answer = num1 - num2;
            Console.WriteLine("Your result is: {0}", answer);
            return answer;
        }

        //Multiplies together two input values and returns result
        public static int CalculatorMultiply(int num1, int num2)
        {
            int answer = num1 * num2;
            Console.WriteLine("Your result is: {0}", answer);
            return answer;
        }

        //Subtracts first input value by second input value and returns result
        public static int CalculatorDivide(int num1, int num2)
        {
            int answer = num1 / num2;
            Console.WriteLine("Your result is: {0}", answer);
            return answer;
        }

        //Takes first input value and does validation on the input
        public int firstNumInput()
        {
            Console.WriteLine("Enter your first number:");
            try
            {
                num1 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Please try again.", ex.Message);
                firstNumInput();
            }
            return num1;
        }

        //Takes first second value and does validation on the input
        public int secondNumInput()
        {
            Console.WriteLine("\nEnter your second number:");
            try
            {
                num2 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Please try again.", ex.Message);
                secondNumInput();
            }
            return num2;
        }

        //Uses calc functions to choose the correct path via the input operation, divide also has validation - so that a division by 0 cannot be performed
        //Validation is also performed on input operation
        public void operation()
        {
            Console.WriteLine("\nEnter your operator:\nFor example + - * /");
            this.operatorUsed = Console.ReadLine();

            try
            {
                switch (this.operatorUsed.Trim())
                {
                    case "+":
                        CalcFunctions.CalculatorAdd(num1, num2);
                        break;
                    case "-":
                        CalcFunctions.CalculatorSubtract(num1, num2);
                        break;
                    case "*":
                        CalcFunctions.CalculatorMultiply(num1, num2);
                        break;
                    case "/":
                        try
                        {
                            CalcFunctions.CalculatorDivide(num1, num2);
                        }
                        catch
                        {
                            Console.WriteLine("\nMake sure you arent diving by zero!");
                        }
                        break;
                    default:
                        throw new InvalidOperationException("Try again and enter an operator e.g. - + * /");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error: {0}", ex.Message);
                operation();
            }
        }

    }
}
