using Polymorphism._2dShapes;
using static System.Console;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry[] shapes = new Geometry[]
            {
                new Square(3),
                new Rectangle(4,6),
                new Parallelogram(heightLength:3, baseLength:5),
                new Circle(7),
                new Elipse(radiusOne:4, radiusTwo: 6)
            };

            foreach (Geometry shape in shapes)
                WriteLine($"Area of {shape.GetType().Name}: {shape.Area()}");
        }
    }
}