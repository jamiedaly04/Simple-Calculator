using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Calculator
{
    public class CalcFuntions
    {
        public static void CalculatorAdd(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }

        public static void CalculatorSubtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }

        public static void CalculatorMultiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }

        public static void CalculatorDivide(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine(result);
        }

    }
}
