using System;

public abstract class Task
{
    // All implentaations of Task now have the audit trail inside,
    // No need to remember to add it with each new task.
    private AuditTrail auditTrail;

    // Default constructor, so that each concreate Task doesnt need to pass in a new audit trail
    public Task()
    {
        auditTrail = new AuditTrail();
    }

    // Could share one audit trail across tasks, or use different audit trails for different tasks etc
    // Each concreate implementation would then be passed the approriate auditTrail into its constructor like bellow
    
    //public Task(AuditTrail auditTrail)
    //{
    //    this.auditTrail = auditTrail;
    //}

    // Protected classes only seen by sub classes
    public void Execute()
    {
        auditTrail.Record();
        // DoExecute method is over ridden by the concreate implementations
        DoExecute();
    }

    // We need method to be private but passed to sub classes... use protected as visible to sub classes!
    protected abstract void DoExecute();
}