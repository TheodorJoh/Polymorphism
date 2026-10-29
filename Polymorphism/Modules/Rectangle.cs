using System;
using System.Collections.Generic;
using System.Text;
//Rectangle
//Subclass to Geometry
// Side1 : Properity that is a double and is used to calculate the area. It represents one of the sides of the rectangle.
// Side2 : Properity that is a double and is used to calculate the area. It represents one of the sides of the rectangle.
// Has two Constructors, one without parameters and one with.
// This class has one method called Area and it is used to return the area of the rectangle.
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
