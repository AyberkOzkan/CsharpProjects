using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeCharAtIndex
{
    public class InputHandler
    {
        public (string, int) GetInput() 
        {
            Console.WriteLine("String ve index'i giriniz (örnek: Algoritma,3):");
            string input = Console.ReadLine();

            var parts = input.Split(',');

            if (parts.Length == 2 && int.TryParse(parts[1], out int index))
            {
                    return (parts[0], index);
            }

            Console.WriteLine("Geçersiz giriş. String ve index virgül ile ayrılmış olmalı.");
            return GetInput();
        }
    }
}
