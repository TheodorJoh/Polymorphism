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
            Side2 = 12;
        }
        public Rectangle(double Side1,double Side2)
        {
            this.Side1 = Side1;
            this.Side2 = Side2;
        }
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public override double Area()
        {
            return Math.Round(Side1 * Side2, 2);
        }
    }
}
