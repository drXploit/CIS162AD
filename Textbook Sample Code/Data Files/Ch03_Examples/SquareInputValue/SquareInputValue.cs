/* *********************************************
 * SquareInputValue.cs		 	
 * Allows an integer value to be input.
 * Computes and displays the square of the
 * value that is input. 
 **********************************************/
using System;
using static System.Console;

namespace SquareInputValue
{
    class SquareInputValue
    {
        static void Main( )
        {
            string inputStringValue;
            double aValue;
            double result;

            Write("Enter a value to be squared: ");
            inputStringValue = ReadLine();
            aValue = double.Parse(inputStringValue);
            result = Math.Pow(aValue, 2);
            WriteLine("{0} squared is {1}", aValue, result);
            ReadKey();
        }
    }
}
