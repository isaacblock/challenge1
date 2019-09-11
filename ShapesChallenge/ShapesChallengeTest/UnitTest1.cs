using System;
using NUnit.Framework;
// remember to reference and import your shape library

namespace Quadrilateral_Tests
{
    [TestFixture]
    public class Tests
    {
        Shapes.Quadrilateral.Square sq1 { get; set; }
        Shapes.Quadrilateral.Rectangle rec1 { get; set; }

        Shapes.Quadrilateral.Square sq2 { get; set; }
        Shapes.Quadrilateral.Rectangle rec2 { get; set; }

        Shapes.Quadrilateral.Square sq3 { get; set; }
        Shapes.Quadrilateral.Rectangle rec3 { get; set; }

        Shapes.Quadrilateral.Square sq4 { get; set; }
        Shapes.Quadrilateral.Rectangle rec4 { get; set; }

        Shapes.Quadrilateral.Square sq5 { get; set; }
        Shapes.Quadrilateral.Rectangle rec5 { get; set; }

        [SetUp]
        public void Init()
        {
            sq1 = new Shapes.Quadrilateral.Square(4, 4, 4, 4, "Blue");
            rec1 = new Shapes.Quadrilateral.Rectangle(4, 3, 3, 4, "Red");

            sq2 = new Shapes.Quadrilateral.Square(6, 6, 6, 6, "Green");
            rec2 = new Shapes.Quadrilateral.Rectangle(5, 4, 4, 5, "Yellow");

            sq3 = new Shapes.Quadrilateral.Square(5, 5, 5, 5, "");
            rec3 = new Shapes.Quadrilateral.Rectangle(5, 10, 10, 5, "");

            sq4 = new Shapes.Quadrilateral.Square(15, 15, 15, 15, "");
            rec4 = new Shapes.Quadrilateral.Rectangle(4, 6, 6, 4, "");

            sq5 = new Shapes.Quadrilateral.Square(7, 7, 7, 7, "");
            rec5 = new Shapes.Quadrilateral.Rectangle(9, 7, 7, 9, "");
        }

        [Test]
        public void SquareTests()
        {
            int area = 16;
            int perimeter = 16;

            Assert.AreEqual(area, sq1.GetArea());
            Assert.AreEqual(perimeter, sq1.GetPerimeter());

            area = 36;
            perimeter = 24;

            Assert.AreEqual(area, sq2.GetArea());
            Assert.AreEqual(perimeter, sq2.GetPerimeter());

            area = 25;
            perimeter = 20;

            Assert.AreEqual(area, sq3.GetArea());
            Assert.AreEqual(perimeter, sq3.GetPerimeter());

            area = 225;
            perimeter = 60;

            Assert.AreEqual(area, sq4.GetArea());
            Assert.AreEqual(perimeter, sq4.GetPerimeter());

            area = 49;
            perimeter = 28;

            Assert.AreEqual(area, sq5.GetArea());
            Assert.AreEqual(perimeter, sq5.GetPerimeter());

        }

        [Test]
        public void RectangleTests()
        {
            int area = 12;
            int perimeter = 14;

            Assert.AreEqual(area, rec1.GetArea());
            Assert.AreEqual(perimeter, rec1.GetPerimeter());

            area = 20;
            perimeter = 18;

            Assert.AreEqual(area, rec2.GetArea());
            Assert.AreEqual(perimeter, rec2.GetPerimeter());

            area = 50;
            perimeter = 30;

            Assert.AreEqual(area, rec3.GetArea());
            Assert.AreEqual(perimeter, rec3.GetPerimeter());

            area = 24;
            perimeter = 20;

            Assert.AreEqual(area, rec4.GetArea());
            Assert.AreEqual(perimeter, rec4.GetPerimeter());

            area = 63;
            perimeter = 32;

            Assert.AreEqual(area, rec5.GetArea());
            Assert.AreEqual(perimeter, rec5.GetPerimeter());

        }

    }
}