using System;
using static System.Console;

namespace Stack
{
    class TestOfStack
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(5);

            stack.Push("test");

            stack.Push(100);
            stack.Push(200);

            stack.Push(3.6);

            WriteLine("Values in the Stack are: " +
                      (double)stack.Pop() + ", " +
                      (int)stack.Pop() + ", " +
                      (int)stack.Pop() + ", " +
                      (string)stack.Pop());
            ReadKey();
        }
    }
}
