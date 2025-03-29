namespace oop;

public class BankTerminal
{
    protected string id;

    public BankTerminal(string id)
    {
        this.id = id;
    }

    public virtual void Connect()
    {
        Console.WriteLine("Connecting...");
    }
}

public class ModelXTerminal : BankTerminal
{
    public ModelXTerminal(string id) : base(id)
    {
    }
    public override void Connect()
    {
        base.Connect();
        Console.WriteLine("Actions for ModelX Terminal...");
    }
}

public class ModelYTerminal : BankTerminal
{
    public ModelYTerminal(string id) : base(id)
    {
    }
    public override void Connect()
    {
        Console.WriteLine("Actions for ModelY Terminal...");
    }
}