using System;

public class OverdraftTask: Task
{

    // Method overrides the specific implimentation
    protected override void DoExecute()
    {
        Console.WriteLine("Overdraft Approved");
    }
}