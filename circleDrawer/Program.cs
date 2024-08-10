using circleDrawer;
using System;

public class Program
{
    static void Main(string[] args)
    {
        InputHandler inputHandler = new InputHandler();
        int radius = inputHandler.GetRadius();

        CircleDrawer circleDrawer = new CircleDrawer();
        circleDrawer.DrawCircle(radius);
    }
}