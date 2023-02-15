using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometricShapes
{
    internal class Quad
    {
        //properties
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        //instance method for perimeter
        public int Perimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }

        //constructors including default.
        public Quad() { }

        public Quad(int side1, int side2, int side3, int side4)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;
        }


    }
}
