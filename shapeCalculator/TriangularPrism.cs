using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class TriangularPrism : Shape
    {
        public double Base {  get; set; }
        public double Height {  get; set; }
        public double Length {  get; set; }
        public TriangularPrism(double baseLength, double height, double length)
        {
            Length = length;
            Base = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            double baseArea = 0.5 * Base * Height;
            double lateralArea = Length * (Base + 2 * Height);
            return 2 * baseArea + lateralArea;
        }

        public override double CalculateVolume()
        {
            double baseArea = 0.5 * Base * Height;
            return baseArea * Height;
        }
    }
}
