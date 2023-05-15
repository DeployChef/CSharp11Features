# Static virtual abstract interface operators

We can add static abstract or static virtual members in interfaces to define interfaces that include overloadable operators, other static members, and static properties.

Counter.cs
```csharp
public interface IAddOperator<T> where T : IAddOperator<T>
{
    static abstract int operator +(T source, T other);
}

public class Counter : IAddOperator<Counter>
{
    public int Count { get; set; }

    public static int operator +(Counter source, Counter other)
    {
        return source.Count + other.Count;
    }
}
```

Program.cs
```csharp
internal class Program
{
    static void Main(string[] args)
    {
        var counter1 = new Counter(){Count = 2};
        var counter2 = new Counter(){Count = 1};
        var result = counter1 + counter2;
        Console.WriteLine(result); //3
    }
}
```