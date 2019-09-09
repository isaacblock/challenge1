using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{

    public class Quadrilateral
    {
        public int Side1Length = 0;
        public int Side2Length = 0;
        public int Side3Length = 0;
        public int Side4Length = 0;
        public string color = "null";

        public int QuadPerimeter()
        {
            int perimeter = Side1Length + Side2Length + Side3Length + Side4Length;
            return perimeter;

        }

        public class Square : Quadrilateral
        {
            public int SquareArea()
            {
                int squarearea = Side1Length * Side1Length;
                return squarearea;

            }

        }

        public class Rectangle : Quadrilateral
        {
            public int RectangleArea()
            {
                int rectarea = Side1Length * Side2Length;
                return rectarea;
            }


        }
    }




}
