using System;
using triangleDrawer;

public class Program
{
    static void Main(string[] args)
    {
        InputHandler inputHandler = new InputHandler();
        int size = inputHandler.GetTriangleSize();

        TriangleDrawer triangleDrawer = new TriangleDrawer();
        triangleDrawer.DrawTriangle(size);
    }
}