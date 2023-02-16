using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometricShapes
{
    internal class Rect : Quad
    {
        // if we got rid of this Perimeter statment it would be calculated in the quad class.
        //public override int Perimeter()
        //{
        //    return base.Perimeter();
        //}
        public virtual int Area()
        {
            return Side1 * Side2;
        }
        //default constructor
        public Rect() : base() { }

        public Rect(int side1, int side2) : base(side1, side2, side1, side2) { }
    }
}
