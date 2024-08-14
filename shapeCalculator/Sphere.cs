using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class Sphere : Shape
    {
        public double Radius { get; set; }
        public Sphere(double radius) 
        { 
            Radius = radius;
        }

        public override double CalculateArea() => 4 * Math.PI * Math.Pow(Radius, 2);

        public override double CalculateVolume() => (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    }
}
