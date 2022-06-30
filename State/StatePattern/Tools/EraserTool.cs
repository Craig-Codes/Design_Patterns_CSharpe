using System;

public class EraserTool : Tool
{
    public override void MouseDown()
    {
        Console.WriteLine("Eraser icon");
    }

    public override void MouseUp()
    {
        Console.WriteLine("Eraser square");
    }
}