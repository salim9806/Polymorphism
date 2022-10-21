using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism._2dShapes
{
    internal class Parallelogram:Geometry
    {
        private double heightLength;
        private double baseLength;

        public Parallelogram(double heightLength, double baseLength)
        {
            this.baseLength = baseLength;
            this.heightLength = heightLength;
        }
        public override double Area()
        {
            return heightLength * baseLength;
        }
    }
}
