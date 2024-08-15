using pairProcessor;
using System;

public class Program
{
    static void Main(string[] args)
    {
        InputHandler inputHandler = new InputHandler();
        PairProcessor pairProcessor = new PairProcessor();
        int n = inputHandler.GetNumberOfPairs();

        for (int i = 0; i < n; i++)
        {
            var (num1, num2) = inputHandler.GetPair(i + 1);
            int result = pairProcessor.ProcessorPair(num1, num2);
            Console.WriteLine($"Sonuç: {result}");
        }
    }
}