using System;

public class BrushTool : Tool
{
    public override void MouseDown()
    {
        Console.WriteLine("Brush icon");
    }

    public override void MouseUp()
    {
        Console.WriteLine("Draw a line");
    }
}