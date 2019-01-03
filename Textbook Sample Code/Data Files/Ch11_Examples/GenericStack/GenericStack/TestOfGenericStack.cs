using System;
using static System.Console;

namespace GenericStack
{
    class TestOfGenericStack
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>(5);
            Stack<double> doubleStack = new Stack<double>(5);
            Stack<string> stringStack = new Stack<string>(5);
            stringStack.Push("test");

            intStack.Push(100);
            intStack.Push(200);

            doubleStack.Push(3.6);

            WriteLine("Values in the 3 Stacks are: " +
                      doubleStack.Pop() + ", " +
                      intStack.Pop() + ", " +
                      intStack.Pop() + ", " +
                      stringStack.Pop());
            ReadKey();
        }
    }
}
