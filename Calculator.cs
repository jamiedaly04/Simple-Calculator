using System;
using System.Linq;

namespace Simple_Calculator
{
    public class Calculator
    {
        public ConsoleKey input;
        public string operatorUsed;
        public int num1;
        public int num2;
        public static void Main(string[] args)
        {
            //Runs main application using methods created in CalcFunctions class and OperatorLogic class
            CalcFunctions numericAccessor = new CalcFunctions();
            Calculator mainAccessor = new Calculator();

            Console.WriteLine("\n----------------------------");
            numericAccessor.firstNumInput();
            numericAccessor.secondNumInput();
            numericAccessor.operation();
            mainAccessor.restartChoice();
        }


        //Gives the user the option to do more calculations / restarts application
        public void restartChoice()
        {
            Console.WriteLine("\nWould you like to do more Calculations? Y/N");
            input = Console.ReadKey().Key;

            if (input == ConsoleKey.Y)
            {
                Calculator.Main(null);
                Console.WriteLine("\nWould you like to do more Calculations? Y/N");
                input = Console.ReadKey().Key;
            }
            else if (input == ConsoleKey.N)
            {
                Environment.Exit(0);

            }
            else
            {
                Console.WriteLine("\nPlease Try Again.");
                Console.WriteLine("\nWould you like to do more Calculations? Y/N");
                input = Console.ReadKey().Key;
            }
        }

    }
}
