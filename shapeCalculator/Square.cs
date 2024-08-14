using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class Square : Shape
    {
        public double SideLength { get; set; }
        public Square(double sideLength) 
        {
            SideLength = sideLength;
        }
        public override double CalculateArea()
        {
            return Math.Pow(SideLength, 2);
        }
        public override double CalculatePerimeter()
        {
            return SideLength * 4;
        }
        public override double CalculateVolume()
        {
            return 0;
        }
    }
}
