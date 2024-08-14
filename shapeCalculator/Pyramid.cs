using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class Pyramid : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }
        public Pyramid(double baseLength, double height) 
        {
            BaseLength = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            double baseArea = Math.Pow(BaseLength, 2);
            double slantHeight = Math.Sqrt(Math.Pow(BaseLength / 2, 2) + Math.Pow(Height, 2));
            double lateralArea = 2 * BaseLength * slantHeight;
            return baseArea + lateralArea;
        }

        public override double CalculateVolume() => (1.0 / 3.0) * Math.Pow(BaseLength, 2) * Height;
    }
}
