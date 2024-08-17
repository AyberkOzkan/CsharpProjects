using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using System.Drawing;
using System.Drawing.Imaging;
using ZXing.Windows.Compatibility;

public class BarcodeGenerator
{
    public void GenerateBarcode(string content, string filePath)
    {
        var barcodeWriter = new BarcodeWriter<Bitmap>
        {
            Format = BarcodeFormat.CODE_128,
            Options = new EncodingOptions
            {
                Height = 100,
                Width = 300,
                Margin = 10
            },
            Renderer = new BitmapRenderer()  // Renderer tanımlanıyor
        };

        using (Bitmap bitmap = barcodeWriter.Write(content))
        {
            bitmap.Save(filePath, ImageFormat.Png); // Barcode'u PNG formatında kaydedelim
        }

        Console.WriteLine($"Barcode başarıyla {filePath} konumuna kaydedildi.");
    }
}
