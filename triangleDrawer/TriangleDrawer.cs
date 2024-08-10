using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleDrawer
{
    public class TriangleDrawer
    {
        public void DrawTriangle(int size)
        {
            int consoleWidth = Console.WindowWidth;
            for (int i = 1;  i <= size; i++) { 
                int starsCount = 2 * i - 1;
                int spacesCount = (consoleWidth - starsCount) / 2;
                Console.WriteLine(new string(' ', spacesCount) + new string('*', starsCount));
            }
        }
    }
}
