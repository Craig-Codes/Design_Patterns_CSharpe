using System;

public class MoneyTransferTask : Task
{

    // Method overrides the specific implimentation
    protected override void DoExecute()
    {
        Console.WriteLine("Transfer Money");
    }
}