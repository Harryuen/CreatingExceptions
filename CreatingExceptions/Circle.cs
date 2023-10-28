using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingExceptions
{
    public class Circle
    {
        private double Radius;

        public void SetRadius(double radius)
        {
            if (radius > 0)
            {
                Radius = radius;
            }
            else
            {
                throw new InvalidRadiusException(radius);
            }
        }

        public double Area() 
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override string ToString()
        {
            return $"Area: " + this.Area();
        }
    }
}
