using System;
using static System.Console;

namespace NestedLoop
{
    class NestedLoop
    {
        static void Main( )
        {
            int inner;
            for (int outer = 0; outer < 3; outer++)
            {
                for (inner = 10; inner > 5; inner--)
                {
                    WriteLine("Outer: {0}\tInner: {1}", outer, inner);
                }
            }
            ReadKey();
        }
    }
}
