using Polymorphism.Modules;

namespace Polymorphism
{
    //Main.
    //The different shapes are initilized and then put into a list called Shapes.
    //The list is then looped througn and each shapes area and names is printed.
    //Polymorphism works through every shape having the same type, Geometry and all of them using the same method Area.
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
