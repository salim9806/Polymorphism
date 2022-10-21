using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism._2dShapes
{
    internal class Elipse : Geometry
    {
        private double radiusOne;
        private double radiusTwo;

        public Elipse(double radiusOne, double radiusTwo)
        {
            this.radiusOne = radiusOne;
            this.radiusTwo = radiusTwo;
        }

        public override double Area()
        {
            return Math.PI * radiusOne * radiusTwo;
        }
    }
}
