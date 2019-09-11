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
            string ans = "";
            bool selecta = false;
            bool selectb = false;
            bool selectc = false;
            bool squarepick = false;
            bool rectanglepick = false;
            int valuea = 0;
            int valueb = 0;


            while (selecta == false)
            {
                Console.WriteLine("Would you like to enter the measurements for a Square (S) or a Rectangle (R)");
                ans = Console.ReadLine();

                if (ans.ToUpper() == "S")
                {
                    squarepick = true;
                    selecta = true;
                }

                else if (ans.ToUpper() == "R")
                {
                    rectanglepick = true;
                    selecta = true;

                }

                if (selecta == false)
                {
                Console.WriteLine("Re-enter your decision");

                }



            }

            while (selectb == false)
            {
                if (squarepick == true)
                {
                    new Shapes.Quadrilateral.Square(valuea, valueb, valueb, valuea);


                    Console.WriteLine("Ok, Square it is.");
                    Console.WriteLine("Enter the first measurement");
                    valuea = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second measurement");
                    valueb = Int32.Parse(Console.ReadLine());

                    selectb = true;
                }

                else if (rectanglepick == true)
                {
                    new Shapes.Quadrilateral.Rectangle(valuea, valueb, valueb, valuea);

                    Console.WriteLine("Ok, Rectangle it is.");
                    Console.WriteLine("Enter the first measurement");
                    valuea = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second measurement");
                    valueb = Int32.Parse(Console.ReadLine());

                    selectb = true;

                }



            }

            while (selectc == false)
            {
                Console.WriteLine("Would you like to calculate the (P) Perimeter of the shape or the (A) Area of the shape?");
                ans = Console.ReadLine();

                if (ans.ToUpper() == "P")
                {
                    if (squarepick == true)
                    {
                        int perimeter = valuea + valueb + valuea + valueb;
                        Console.WriteLine("The Perimeter of the Square is " + perimeter);
                        selectc = true;

                    }

                    else if (rectanglepick == true)
                    {
                        int perimeter = valuea + valueb + valuea + valueb;
                        Console.WriteLine("The Perimeter of the Rectangle is " + perimeter);
                        selectc = true;



                    }

                }

                else if (ans.ToUpper() == "A")
                {
                    if (squarepick == true)
                    {
                        int squarearea = valuea * valuea;
                        Console.WriteLine("The Area of the Square is " + squarearea);
                        selectc = true;


                    }

                    else if (rectanglepick == true)
                    {
                        int rectarea = valuea * valueb;
                        Console.WriteLine("The Area of the Rectangle is " + rectarea);
                        selectc = true;

                    }
                }

                if (selectc == false)
                {
                    Console.WriteLine("Re-enter your decision");

                }

            }

            Console.ReadKey(true);
            Environment.Exit(0);


        }
    }
}
