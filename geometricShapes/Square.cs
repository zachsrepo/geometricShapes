using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometricShapes
{
    internal class Square : Rect
    {
        public Square() : base() { }
        public Square(int side) : base(side, side) { }
    }
}
