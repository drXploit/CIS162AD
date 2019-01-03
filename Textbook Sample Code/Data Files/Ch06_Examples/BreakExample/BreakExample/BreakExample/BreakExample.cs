using System;
using static System.Console;

namespace BreakExample
{
    class BreakExample
    {
        static void Main( )
        {
            int total = 0;
            for (int nValue = 0; nValue < 10; nValue++)
            {
                if (nValue == 5)
                {
                    break;
                }
                total += nValue;
                Write(nValue + "\t");
            }
            WriteLine("\nTotal is equal to {0}.", total);
            ReadKey();
        }
    }
}