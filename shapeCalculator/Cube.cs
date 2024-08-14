using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class Cube : Shape
    {
        public double SideLength { get; set; }

        public Cube(double sideLength) 
        {
            SideLength = sideLength;
        }
        public override double CalculateArea() => 6 * Math.Pow(SideLength, 2);

        public override double CalculateVolume() => Math.Pow(SideLength, 3);
    }
}
