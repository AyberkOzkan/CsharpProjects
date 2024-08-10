using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleDrawer
{
    public class InputHandler
    {
        public int GetRadius()
        {
            int radius;
            Console.Write("Dairenin yarıçapını giriniz:");
            while (!int.TryParse(Console.ReadLine(), out radius) || radius <= 0) 
            {
                Console.Write("Lütfen geçerli bir pozitif tamsayı giriniz:");
            }
            return radius;
        }
    }
}
