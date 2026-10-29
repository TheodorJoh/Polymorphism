using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Modules
{
    public class Square : Geometry
    {
        public Square()
        {
            Side1 = 8;
        }
        public Square(double Side1)
        {
            this.Side1 = Side1;
        }
        public double Side1 { get; set; }

        public override double Area()
        {
            return Math.Round(Side1 * Side1, 2);
        }
    }
}
