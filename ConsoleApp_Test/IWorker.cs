namespace ConsoleApp_Test;

public abstract class IWorker
{
    public IWorker()
    {
        Console.WriteLine($">>>>> {this.GetType().Name} >>>>>>");
    }
    public void InvokeTest()
    {
        this.Test();
        Console.WriteLine($">>>>>>>>>>>>>>>>>>>>>");
    }
    public abstract void Test();
}
