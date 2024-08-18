using ATM;
using System.IO;

public class LogHandler
{
    private List<string> _logs;

    public LogHandler()
    {
        _logs = new List<string>();
    }

    public void AddLog(string message)
    {
        _logs.Add($"{DateTime.Now}: {message}");
    }

    public void SaveEndOfDayReport(List<Transaction> transactions)
    {
        string date = DateTime.Now.ToString("ddMMyyyy");
        string filePath = $"EOD_{date}.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Gün Sonu Raporu:");
            writer.WriteLine("----------");
            foreach (var transaction in transactions)
            {
                writer.WriteLine(transaction);
            }

            writer.WriteLine("\nHatalı Giriş Denemeleri:");
            foreach (var log in _logs)
            {
                writer.WriteLine(log);
            }
        }

        Console.WriteLine($"Gün sonu raporu '{filePath}' olarak kaydedildi.");
    }
}
