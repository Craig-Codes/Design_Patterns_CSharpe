using System;

public class SelectionTool : Tool
{
    public override void MouseDown()
    {
        Console.WriteLine("Selection icon");
    }

    public override void MouseUp()
    {
        Console.WriteLine("Draw dashed rectangle");
    }
}