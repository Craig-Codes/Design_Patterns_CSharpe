using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new MoneyTransferTask();
            task.Execute();

            var overdraft = new OverdraftTask();
            overdraft.Execute();
        }
    }
}
