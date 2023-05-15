namespace FileScopeType;

file interface IWorker
{
    int Work();
}

file class HiddenWorker
{
    public int Work() => 42;
}

public class Worker : IWorker
{
    public int Work()
    {
        var worker = new HiddenWorker();
        return worker.Work();
    }
}