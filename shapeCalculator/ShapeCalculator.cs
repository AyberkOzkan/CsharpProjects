using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class ShapeCalculator
    {
        public double Calculate(Shape shape, string calculationType)
        {
            switch (calculationType.ToLower()) 
            {
                case "alan":
                    return shape.CalculateArea();
                case "hacim":
                    return shape.CalculateVolume();
                case "çevre":
                    return shape.CalculatePerimeter();
                default:
                    throw new ArgumentException("Geçersiz Hesaplama Türü!");
            }
        }
    }
}
