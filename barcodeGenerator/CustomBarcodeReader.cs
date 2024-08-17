using ZXing;
using System.Drawing;
using ZXing.Windows.Compatibility;

public class CustomBarcodeReader
{
    public string ReadBarcode(string filePath)
    {
        var barcodeReader = new BarcodeReader();

        using (Bitmap bitmap = (Bitmap)Image.FromFile(filePath))
        {
            var result = barcodeReader.Decode(bitmap);

            if (result != null)
            {
                return result.Text;
            }
            else
            {
                return "Barcode okunamadı.";
            }
        }
    }
}
