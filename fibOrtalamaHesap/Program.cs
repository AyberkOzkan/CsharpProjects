using fibOrtalamaHesap;
using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fibonacci Serisi Derinliğini Giriniz:");
        int depth;
        while (!int.TryParse(Console.ReadLine(), out depth) || depth <= 0)
        {
            Console.WriteLine("Lütfen geçerli bir pozitif tam sayı giriniz:");
        }

        FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();
        List<int> series = fibonacciCalculator.GenerateSeries(depth);

        Console.WriteLine("Fibonacci Serisi:");
        foreach (int number in series) 
        {
            Console.WriteLine(number + " ");
        }
        Console.WriteLine();

        AverageCalculator averageCalculator = new AverageCalculator();
        double average = averageCalculator.CalculateAvarage(series);

        Console.WriteLine($"Fibonacci serisinin {depth} derinliğine kadar olan elemanlarının ortalaması: {average}");
    }
}