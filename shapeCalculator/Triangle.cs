using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class Triangle : Shape
    {
        public double SideA {  get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC)); // Heron formulü
        }
        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
        public override double CalculateVolume()
        {
            return 0; // Üçgenin hacmi yok
        }

    }


}
