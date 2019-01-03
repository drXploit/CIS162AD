/* *********************************************
 * SquareExample.cs		Author:	Doyle	
 * Computes the square of a variable initialized
 * at compile time. 
 **********************************************/
using System;
using static System.Console;

namespace SquareExample
{
    class SquareExample
    {
        static void Main( )
        {
            int aValue = 768;
            int result;

            result = aValue * aValue;
            WriteLine("{0} squared is {1}", aValue, result);
            ReadKey();
        }
    }
}
