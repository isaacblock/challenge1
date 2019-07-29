using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int Side1Length = 0;
            int Side2Length = 0;
            int Side3Length = 0;
            int Side4Length = 0;
            bool selecta = false;
            bool selectb = false;

            Console.WriteLine("Enter the first measurement");
            Side1Length = Int32.Parse(Console.ReadLine());
            Side3Length = Side1Length;

            Console.WriteLine("Enter the second measurement");
            Side2Length = Int32.Parse(Console.ReadLine());
            Side4Length = Side2Length;



            while (selecta == false)
            {

                Console.WriteLine("Would you like to calculate the (P) Perimeter of the shape or the (A) Area of the shape?");
                string ans = Console.ReadLine();

                if (ans == "P")
                {
                    Quad();
                    selecta = true;
                }

                else if (ans == "A")
                {
                    selectb = true;
                    selecta = true;


                }

                else
                {
                    Console.WriteLine("Re-enter your decision");
                }
            }

            if (selectb == true)
            {
                Console.WriteLine("Is the shape a (S) Square or a (R) Rectangle?");
                string ans = Console.ReadLine();

                if (ans == "S")
                {
                    Square();
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }

                else if (ans == "R")
                {
                    Rectangle();
                    Console.ReadKey(true);
                    Environment.Exit(0);

                }

                else
                {
                    Console.WriteLine("Re-enter your decision");
                }


            }

            int Quad()
            {
                int perimeter = Side1Length + Side2Length + Side3Length + Side4Length;
                Console.WriteLine("The perimeter of the shape is " + perimeter);
                return perimeter;

            }

            int Square()
            {
                int squarearea = Side1Length * Side1Length;
                Console.WriteLine("The area of the square is " + squarearea);
                return squarearea;

            }

            int Rectangle()
            {
                int rectarea = Side1Length * Side2Length;
                Console.WriteLine("The area of the rectangle is " + rectarea);
                return rectarea;
            }

            Console.ReadKey(true);
            Environment.Exit(0);


        }
    }
}
