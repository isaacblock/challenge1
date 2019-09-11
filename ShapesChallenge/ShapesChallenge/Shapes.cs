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
        public string Color = "null";

        public Quadrilateral(int side1Length, int side2Length, int side3Length, int side4Length, string color)
        {
            Side1Length = side1Length;
            Side2Length = side2Length;
            Side3Length = side3Length;
            Side4Length = side4Length;
            Color = color;
        }

        public int GetPerimeter()
        {
            int perimeter = Side1Length + Side2Length + Side3Length + Side4Length;
            return perimeter;
        }



        public class Square : Quadrilateral
        {
            public Square(int side1Length, int side2Length, int side3Length, int side4Length, string color) : base(side1Length, side2Length, side3Length, side4Length, color)
            {
                Side1Length = side1Length;
                Side2Length = side2Length;
                Side3Length = side3Length;
                Side4Length = side4Length;
                Color = color;

            }

            public int GetArea()
            {
                int area = Side1Length * Side1Length;
                return area;
            }




        }

        public class Rectangle : Quadrilateral
        {
            public Rectangle(int side1Length, int side2Length, int side3Length, int side4Length, string color) : base(side1Length, side2Length, side3Length, side4Length, color)
            {
                Side1Length = side1Length;
                Side2Length = side2Length;
                Side3Length = side3Length;
                Side4Length = side4Length;
                Color = color;


            }


            public int GetArea()
            {
                int area = Side1Length * Side2Length;
                return area;
            }


        }


    }


}
