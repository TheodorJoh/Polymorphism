using Polymorphism.Modules;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry Circle = new Circle();
            Geometry Rectangle = new Rectangle();
            Geometry Square = new Square();

            Console.WriteLine($"Area of Circle: {Circle.Area()}");
            Console.WriteLine($"Area of Square: {Square.Area()}");
            Console.WriteLine($"Area of Rectangle {Rectangle.Area()}");

        }
    }
}
