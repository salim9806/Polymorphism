using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism._2dShapes
{
    internal class Rectangle:Geometry
    {
        private double sideOne;
        private double sideTwo;

        public Rectangle(double sideOne, double sideTwo)
        {
            this.sideOne = sideOne;
            this.sideTwo = sideTwo;
        }

        public override double Area()
        {
            return sideOne * sideTwo;
        }
    }
}
