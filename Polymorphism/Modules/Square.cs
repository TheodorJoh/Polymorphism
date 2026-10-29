using System;
using System.Collections.Generic;
using System.Text;
//Square
//Subclass to Geometry
// Side1 : Properity that is a double and is used to calculate the area. It represents one of the sides of the square.
// Has two Constructors, one without parameters and one with.
// This class has one method called Area and it is used to return the area of the Square.
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
