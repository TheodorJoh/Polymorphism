using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Modules
{
    public class Rectangle : Geometry
    {
        public Rectangle()
        {
            Side1 = 4;
            Side2 = 6;
        }
        public Rectangle(double Side1,double Side2)
        {
            this.Side1 = this.Side1;
            this.Side2 = this.Side2;
        }
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public override double Area()
        {
            return Side1 * Side2;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Rectangle with one side with length of {Side1} and another with {Side2} and has an area of {Area()}");
        }
    }
}
