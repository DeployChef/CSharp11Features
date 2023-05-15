# Auto default struct

If you don't initialize all fields in a struct, the compiler adds code to the constructor that initializes those fields to the default value. The compiler performs its usual definite assignment analysis. Any fields that are accessed before being assigned, or not definitely assigned when the constructor finishes executing are assigned their default values before the constructor body executes. If this is accessed before all fields are assigned, the struct is initialized to the default value before the constructor body executes.

```csharp
internal class Program
{
    static void Main(string[] args)
    {
        var m1 = new Measurement(5);
        Console.WriteLine(m1);  // output: 5 (Ordinary measurement)

        var m2 = new Measurement();
        Console.WriteLine(m2);  // output: 0 ()

        var m3 = default(Measurement);
        Console.WriteLine(m3);  // output: 0 ()
    }
}
```

```csharp
public readonly struct Measurement
{
    public Measurement(double value)
    {
        Value = value;
    }

    public Measurement(double value, string description)
    {
        Value = value;
        Description = description;
    }

    public Measurement(string description)
    {
        Description = description;
    }

    public double Value { get; init; }
    public string Description { get; init; } = "Ordinary measurement";

    public override string ToString() => $"{Value} ({Description})";
}
```

