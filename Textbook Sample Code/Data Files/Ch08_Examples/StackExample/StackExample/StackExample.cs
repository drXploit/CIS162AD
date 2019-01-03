/*StackExample.cs
 * Creates a stack, pushes elements onto it,
 * pops one off and then displays the contents.
 */

using System;
using static System.Console;
using System.Collections;

namespace StackExample
{
    class StackExample
    {
        static void Main( )
        {
            Stack lastInFirstOut = new Stack();

            lastInFirstOut.Push("Jill Won");
            lastInFirstOut.Push("Donna Abbott");
            lastInFirstOut.Push("Jeremy Door");
            lastInFirstOut.Push("Olivia Rivers");

            lastInFirstOut.Pop();

            DisplayInfo(lastInFirstOut);
            ReadKey();
        }

        public static void DisplayInfo(Stack lastInFirstOut)
        {
            WriteLine("Stack - Last In First Out ");
            WriteLine("\nNumber of Elements:    {0}", lastInFirstOut.Count);
            Write("Values:");
            foreach (Object obj in lastInFirstOut)
                     Write("    {0}", obj);
            WriteLine();
        }
    }
}