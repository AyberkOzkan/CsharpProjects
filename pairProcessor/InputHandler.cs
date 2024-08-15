using System;

namespace pairProcessor
{
    public class InputHandler
    {
        public int GetNumberOfPairs()
        {
            Console.WriteLine("Kaç sayı çifti gireceğinizi belirtiniz:");
            string? input = Console.ReadLine();

            int numberOfPairs;
            while (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out numberOfPairs))
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir tam sayı girin!");
                input = Console.ReadLine();
            }

            return numberOfPairs;
        }

        public (int, int) GetPair(int pairNumber)
        {
            Console.WriteLine($"Lütfen {pairNumber}. sayı çiftini giriniz (örnek: 1 2):");
            string? input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input) || input.Split(' ').Length != 2)
            {
                Console.WriteLine("Geçersiz giriş. Lütfen iki sayı giriniz (örnek: 1 2):");
                input = Console.ReadLine();
            }

            string[] numbers = input.Split(' ');

            while (!int.TryParse(numbers[0], out int num1) || !int.TryParse(numbers[1], out int num2))
            {
                Console.WriteLine("Geçersiz giriş. Lütfen geçerli iki sayı giriniz (örnek: 1 2):");
                input = Console.ReadLine();
                numbers = input?.Split(' ') ?? new string[0];
            }

            return (int.Parse(numbers[0]), int.Parse(numbers[1]));
        }
    }
}
