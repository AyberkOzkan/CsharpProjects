using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleDrawer
{
    public class CircleDrawer
    {
        public void DrawCircle(int radius)
        {
            //  dairenin iç ve dış sınırlarını belirlemek için
            double rIn = radius - 0.4;
            double rOut = radius + 0.4;

            for (double y = radius; y >= -radius; --y)
            {
                for(double x = -radius; x < rOut; x += 0.5)
                {
                    double value = (x * x) + (y * y);
                    if (value >= rIn * rIn && value <= rOut * rOut) 
                    {
                    Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
