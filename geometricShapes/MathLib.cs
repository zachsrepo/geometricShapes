using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
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
        public static int[] CubedRange(int x, int y)
        {
            int cubedValue;
            int pos = 0;
            int[] cubedKeep = new int[y - x + 1];
            if (x < 0 && y < 0)
            {
                Console.WriteLine($"The range of numbers to cube cannot be negative");
                    return new int[0]; 
            }
            else
            {
                while (y >= x)
                {                   
                    cubedValue = x * x * x;
                    cubedKeep[pos] = cubedValue;
                    //Console.WriteLine($"{x} {cubedValue}");
                    pos++;
                    x++;
                }
                return cubedKeep;               
            }
            //return ($"these are all the cubed values from {idx} to {y}");
        }
    }
}
 