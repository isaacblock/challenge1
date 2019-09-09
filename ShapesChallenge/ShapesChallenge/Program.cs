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
            bool selecta = false;
            bool selectb = false;
            bool selectc = false;
            bool squarepick = false;
            bool rectanglepick = false;
            

            Console.WriteLine("Would you like to enter the measurements for a Square (S) or a Rectangle (R)");
            string ans = Console.ReadLine();

            while (selecta == false)
            {

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

                else
                {
                    Console.WriteLine("Re-enter your decision");
                }

            }

            while (selectb == false)
            {
                if (squarepick == true)
                {

                    Console.WriteLine("Enter the first measurement");
                    Side1Length = Int32.Parse(Console.ReadLine());
                    Side3Length = Side1Length;

                    Console.WriteLine("Enter the second measurement");
                    Side2Length = Int32.Parse(Console.ReadLine());
                    Side4Length = Side2Length;

                    selectb = false;
                }

                else if (rectanglepick == true)
                {
                    Console.WriteLine("Enter the first measurement");
                    Side1Length = Int32.Parse(Console.ReadLine());
                    Side3Length = Side1Length;

                    Console.WriteLine("Enter the second measurement");
                    Side2Length = Int32.Parse(Console.ReadLine());
                    Side4Length = Side2Length;

                    selectb = false;

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
                        ();


                    }

                    else if (rectanglepick == true)
                    {

                    }

                }

                else if (ans.ToUpper() == "A")
                {
                    if (squarepick == true)
                    {

                    }

                    else if (rectanglepick == true)
                    {

                    }
                }

                else
                {
                    Console.WriteLine("Re-enter your decision");
                }


            }

            Console.ReadKey(true);
            Environment.Exit(0);


        }
    }
}
