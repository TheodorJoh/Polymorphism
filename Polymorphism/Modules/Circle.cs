using System;
using System.Collections.Generic;
using System.Text;
//Circle
//Subclass to Geometry
// Radius : Properity that is a double and is used to calculate the area.
// Has two Constructors, one without parameters and one with.
// This class has one method called Area and it is used to return the area of the circle.
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
