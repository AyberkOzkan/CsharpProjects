using System;
using numberProcessor67;

public class Program
{
    static void Main(string[] args)
    {
        InputHandler inputHandler = new InputHandler();
        NumberProcessor numberProcessor = new NumberProcessor();

        int n = inputHandler.GetNumberOfInputs();
        var numbers = inputHandler.GetNumbers(n);

        var (sumOfDifferences, sumOfSquaredDifferences) = numberProcessor.ProcessNumbers(numbers);

        Console.WriteLine($"67'den küçük olanların farklarının toplamı: {sumOfDifferences}");
        Console.WriteLine($"67'den büyük olanların farklarının mutlak karelerinin toplamı: {sumOfSquaredDifferences}");
    }
}
