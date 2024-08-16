using stringManipulator;
using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        InputHandler inputHandler = new InputHandler();
        StringManipulator stringManipulator = new StringManipulator();

        List<string> stringList = inputHandler.GetStrings();

        foreach (string str in stringList) 
        { 
            string result = stringManipulator.SwapFirstAndLastCharacter(str);
            Console.WriteLine(result);
        }
    }

}