using System;

public class HighContrastFilter : IFilter
{
    public void apply(string fileName)
    {
        Console.WriteLine("Applying High Contrast filter");
    }
}