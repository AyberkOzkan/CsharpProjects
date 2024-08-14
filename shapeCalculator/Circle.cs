using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class Circle : Shape
    {
        public double Radius {  get; set; }
        public Circle(double radius) 
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
        public override double CalculatePerimeter() 
        {
            return 2 * Math.PI * Radius; 
        }
        public override double CalculateVolume()
        {
            return 0; // Hacmi yok
        }
    }
}
