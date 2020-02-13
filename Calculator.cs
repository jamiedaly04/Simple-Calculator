using System;
using System.Linq;

namespace Simple_Calculator
{
    public class Calculator : CalcFunctions
    {
        public static void Main(string[] args)
        {
            //Runs main application using methods created in CalcFunctions class
            CalcFunctions accessor = new CalcFunctions();

            Console.WriteLine("\n----------------------------");
            accessor.firstNumInput();
            accessor.secondNumInput();
            accessor.operation();
            accessor.restartChoice();

            //TO DO LIST - 
            //UNIT TESTING
            
        }

    }
}
