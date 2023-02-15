using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometricShapes
{
    internal class Rect
    {
        public int Longside { get; set; }
        public int Shortside { get; set; }

        public int Perimeter()
        {
            return (Longside + Shortside) * 2;
        }
        public int Area()
        {
            return Longside * Shortside;
        }
        //default constructor
        public Rect() { }

        public Rect(int longside, int shortside)
        {
            Longside = longside;
            Shortside = shortside;
        }
    }
}
