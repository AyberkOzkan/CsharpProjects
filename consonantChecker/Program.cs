using consonantChecker;
using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        InputHandler inputHandler = new InputHandler();
        ConsonantChecker consonantChecker = new ConsonantChecker();

        List<string> strings = inputHandler.GetStrings();

        foreach (string s in strings)
        {
            bool result = consonantChecker.HasConsecutiveConsonants(s);
            Console.WriteLine(result);
        }
    }

}