using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberProcessor67
{
    public class InputHandler
    {
        public int GetNumberOfInputs()
        {
            Console.WriteLine("Kaç sayı gireceğinizi belirtiniz:");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir tam sayı giriniz!");
            }
            return n;
        }
        public List<int> GetNumbers(int count) 
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1} adet sayıyı giriniz: ");
                int number;
                while(!int.TryParse(Console.ReadLine(), out number) )
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir tam sayı giriniz!");
                }
                numbers.Add(number);
            }
            return numbers;
        }
    }
}
