using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometricShapes
{
    internal class MathLib
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.Write("Cannot Divide by zero!");
                return -1;
            }
            else
            {
                return x / y;
            }
        }
        public static string CubedRange(int x, int y)
        {
            int cubedValue;
            int idx = x;
            while (x <= y)
            {
                cubedValue = x * x * x;
                Console.WriteLine($"{x} {cubedValue}");
                x++;
            }
            return ($"these are all the cubed values from {idx} to {y}");
        }
    }
}
