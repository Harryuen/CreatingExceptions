using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingExceptions
{
    public class InvalidRadiusException : Exception
    {
        //public InvalidRadiusException()
        //    : base("Invalid radius: Radius should be greater than zero.")
        //{
        //}

        public InvalidRadiusException(double radius)
            : base($"Invalid radius: {radius} is not a valid value. Radius should be greater than zero.")
        {
        }
    }
}
