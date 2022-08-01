using System;

public class Button
{
    private string label;
    private ICommand command;

    public Button(ICommand command){
        this.command = command; // Command passed via constructor
    }

    public void click(){
        command.Execute(); // executes a generic command - implemented in concrete command class
    }

    public string GetLabel(){
        return label;
    }

    public void SetLabel(string label){
        this.label = label;
    }
}