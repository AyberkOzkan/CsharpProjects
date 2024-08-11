using removeCharAtIndex;
using System;

public class Program
{
    static void Main(string[] args)
    {
        InputHandler inputHandler = new InputHandler();
        var (inputString, index) = inputHandler.GetInput();

        StringProcessor stringProcessor = new StringProcessor();
        string result = stringProcessor.RemoveCharacterAtIndex(inputString, index);
        Console.WriteLine("Sonuç: " + result);
    }
    
}