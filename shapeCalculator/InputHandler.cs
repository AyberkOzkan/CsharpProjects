using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeCalculator
{
    public class InputHandler
    {
        public string GetShapeType()
        {
            Console.WriteLine("Seçebileceğiniz geometrik şekiller:");
            Console.WriteLine("\t1) Daire");
            Console.WriteLine("\t2) Üçgen");
            Console.WriteLine("\t3) Dikdörtgen");
            Console.WriteLine("\t4) Kare");
            Console.WriteLine("\t5) Küp");
            Console.WriteLine("\t6) Küre");
            Console.WriteLine("\t7) Silindir");
            Console.WriteLine("\t8) Üçgen Prizma");
            Console.WriteLine("\t9) Koni");
            Console.WriteLine("\t10) Piramit");
            Console.WriteLine("------------------------------------");

            string shapeType;
            while (true)
            {
                Console.Write("Geometrik Şekli seçiniz (1-10): ");
                string choice = Console.ReadLine() ?? string.Empty;

                switch (choice)
                {
                    case "1":
                        shapeType = "daire";
                        break;
                    case "2":
                        shapeType = "üçgen";
                        break;
                    case "3":
                        shapeType = "dikdörtgen";
                        break;
                    case "4":
                        shapeType = "kare";
                        break;
                    case "5":
                        shapeType = "küp";
                        break;
                    case "6":
                        shapeType = "küre";
                        break;
                    case "7":
                        shapeType = "silindir";
                        break;
                    case "8":
                        shapeType = "üçgen prizma";
                        break;
                    case "9":
                        shapeType = "koni";
                        break;
                    case "10":
                        shapeType = "piramit";
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen 1 ile 10 arasında bir sayı giriniz.");
                        continue;
                }
                break;
            }

            return shapeType;
        }
        public double GetDoubleInput(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                {
                    break;
                }
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı giriniz.");
            }
            return value;
        }
    }
}
