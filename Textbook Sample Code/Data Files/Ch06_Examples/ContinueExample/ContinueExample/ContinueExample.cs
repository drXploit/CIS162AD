using System;
using static System.Console;

namespace ContinueExample
{
    class ContinueExample
    {
        static void Main( )
        {
            int total = 0;
            for (int nValue = 0; nValue < 10; nValue++)
            {
                if (nValue % 2 == 0)
                {
                    continue;
                }
                total += nValue;
                Write(nValue + "\t");
            }
            WriteLine("\nTotal is equal to {0}.", total);
            ReadKey();
        }
    }
}
