using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometricShapes
{
    internal class Square
    {
        public int Side { get; set; }

        public int Perimeter()
        {
            return Side * 4;
        }
        public int Area()
        {
            return Side * Side; 
        }
        public Square() { }
        public Square(int side)
        {
            Side = side;
        }
    }
}
