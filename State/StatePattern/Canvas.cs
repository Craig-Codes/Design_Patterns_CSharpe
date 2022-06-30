// Our virtual canvas in photoshop type application

using System;

 public class Canvas
    {

    // When current tool is set, this becomes the newly selected tool
    public Tool CurrentTool { get; set; }


    // Method names shared across concreate abstract class
    // implementations, allowing app to be easily extended 
    // whilst removing long if/else statements from
    // both mouse down and mouse up methods!
    public void MouseDown()
    {
        CurrentTool.MouseDown();
    }

    public void MouseUp()
    {
        CurrentTool.MouseUp();
    }

    }