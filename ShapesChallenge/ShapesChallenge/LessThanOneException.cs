using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesChallenge
{
    class LessThanOneException : Exception
    {
        public LessThanOneException() : base("You must not enter a number less than 1.")
        {
            

        }
    }
}
