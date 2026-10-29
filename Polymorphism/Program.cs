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

            List<Geometry> Shapes = new List<Geometry>();
            Shapes.Add(Circle);
            Shapes.Add(Rectangle);
            Shapes.Add(Square);
            foreach(var shape in Shapes)
            {
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area()}");
            }

            Console.ReadKey();

        }
    }
}
