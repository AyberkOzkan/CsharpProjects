using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleDrawer
{
    public class InputHandler
    {
        public int GetTriangleSize()
        {
            int size;
            Console.WriteLine("Üçgenin boyutunu giriniz:");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0 )
            {
                Console.WriteLine("Lütfen geçerli bir pozitif tamsayı giriniz:");
            }
            return size;
        }
    }
}
