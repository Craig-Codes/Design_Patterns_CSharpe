using System;

public class AddCustomerCommand : ICommand {
    private customerService service;

    public AddCustomerCommand(customerService service){
        this.service = service;
    }

    public void Execute(){
        // Implementation of interface
        service.AddCustomer();  // Service does the actual work
    }
}