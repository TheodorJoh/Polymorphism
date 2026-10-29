using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Modules
{
    public class Circle : Geometry
    {
        public Circle()
        {
            Radius = 4;
        }
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.Round(Radius*Radius*Math.PI,2);
        }
    }
}
