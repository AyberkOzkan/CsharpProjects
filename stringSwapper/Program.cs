using stringSwapper;
using System;

public class Program
{
    static void Main(string[] args)
    {
        InputHandler inputHandler = new InputHandler();
        string inputString = inputHandler.GetInputString();

        StringSwapper stringSwapper = new StringSwapper();
        string result = stringSwapper.SwapAdjacentCharacters(inputString);

        Console.WriteLine("Sonuç: " + result);
    }
    
}