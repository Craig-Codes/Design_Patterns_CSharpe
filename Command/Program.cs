using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new customerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command);
            
            button.click();
        }
    }
}
