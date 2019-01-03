using System;
using static System.Console;

namespace DoWhile
{
    class DoWhile
    {
        static void Main( )
        {
            int counter = 10;
            do                  // No semicolon on this line
            {
                WriteLine(counter + "\t" + Math.Pow(counter, 2));
                counter--;
            }
            while (counter > 0);

            ReadKey();
        }
    }
}