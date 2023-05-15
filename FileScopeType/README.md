# File scope type

Now we can use the file access modifier to create a type whose visibility is scoped to the source file in which it is declared. This feature helps source generator authors avoid naming collisions.

Worker.cs
```csharp
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
```

Program.cs
```csharp
//visible
var worker = new Worker();

//not visible
var hiddenWorker = new HiddenWorker();
```