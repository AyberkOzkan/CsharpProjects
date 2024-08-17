using System;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        BarcodeGenerator generator = new BarcodeGenerator();
        CustomBarcodeReader reader = new CustomBarcodeReader();

        Console.WriteLine("Ne yapmak istersiniz?");
        Console.WriteLine("1: Barcode Oluştur");
        Console.WriteLine("2: Barcode Oku");
        Console.Write("Seçiminiz (1 veya 2): ");
        string? choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Oluşturulacak barcode için içerik girin: ");
            string? content = Console.ReadLine();

            if (!string.IsNullOrEmpty(content))
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "barcode.png");

                // Barcode üretme ve kaydetme
                generator.GenerateBarcode(content, filePath);
                Console.WriteLine($"Barcode başarıyla '{filePath}' olarak proje dizininde oluşturuldu.");
            }
            else
            {
                Console.WriteLine("Geçersiz içerik girdiniz.");
            }
        }
        else if (choice == "2")
        {
            Console.WriteLine("Lütfen okunacak dosyayı proje dizinine koyun.");
            Console.WriteLine("Örnek dosya adı: 'barcode.png'");
            Console.Write("Dosya adını girin: ");
            string? fileName = Console.ReadLine();

            if (!string.IsNullOrEmpty(fileName))
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

                // Dosyanın var olup olmadığını kontrol et
                if (File.Exists(filePath))
                {
                    // Barcode okuma
                    string decodedContent = reader.ReadBarcode(filePath);
                    Console.WriteLine($"Okunan Barcode: {decodedContent}");
                }
                else
                {
                    Console.WriteLine($"Dosya bulunamadı: {filePath}. Lütfen dosyanın proje dizininde olduğundan emin olun.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz dosya adı girdiniz.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz seçim.");
        }
    }
}
