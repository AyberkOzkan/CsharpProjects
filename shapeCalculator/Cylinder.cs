using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class Cylinder : Shape
    {
        public double Height { get; set; }
        public double Radius { get; set; }
        public Cylinder(double radius, double height)
        {
            Height = height;
            Radius = radius;
        }

        public override double CalculateArea() => 2 * Math.PI * Radius * (Radius + Height);

        public override double CalculateVolume() => Math.PI * Math.Pow(Radius, 2) * Height;
    }
}
