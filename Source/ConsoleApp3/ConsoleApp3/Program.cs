using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] anArray = { { 100, 100, 100 } { 100, 100, 100 } };
            int[,] anArray2 = new int[,] { { 100, 100, 100 } { 100, 100, 100 } };
            int[,] anArray3 = new int[2, 3] { { 100, 100, 100 } { 100, 100, 100 } };

            try
            {
                int x = 1;
            }
            catch (EndofStreamException)
            {
            }
        }
    }
}
