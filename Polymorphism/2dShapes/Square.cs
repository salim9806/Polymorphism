using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism._2dShapes
{
    internal class Square:Geometry
    {
        private double sideLength;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double Area()
        {
            return Math.Pow(sideLength, 2);
        }
    }
}
