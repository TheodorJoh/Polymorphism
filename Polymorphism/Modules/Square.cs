using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Modules
{
    public class Square : Geometry
    {
        public Square()
        {
            Side1 = 4;
            Side2 = 4;
        }
        public Square(double Side1, double Side2)
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
            Console.WriteLine($"Square with sides of {Side1} and has an area of {Area()}");
        }
    }
}
