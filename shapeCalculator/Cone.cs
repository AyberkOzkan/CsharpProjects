using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class Cone : Shape
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public Cone(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double CalculateArea()
        {
            double slantHeight = Math.Sqrt(Math.Pow(Radius, 2) * Math.Pow(Height, 2));
            return Math.PI * Radius * (Radius + slantHeight);
        }

        public override double CalculateVolume() => (1.0/3.0) * Math.PI * Math.Pow(Radius, 2) * Height;
    }
}
