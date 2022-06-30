using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.CurrentTool = new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();
            canvas.CurrentTool = new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();
            canvas.CurrentTool = new EraserTool();
            canvas.MouseDown();
            canvas.MouseUp();

        }
    }
}
