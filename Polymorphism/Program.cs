using Polymorphism.Modules;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle Circle = new Circle();
            Rectangle Rectangle = new Rectangle();
            Square Square = new Square();


            Circle.PrintInfo();
            Rectangle.PrintInfo();
            Square.PrintInfo();
        }
    }
}
