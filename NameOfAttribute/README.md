# NameOf in attribute

Now we can use the nameof operator to specify the name of a method parameter in an attribute on the method or parameter declaration.

```csharp
[Description(nameof(Main))]
static void Main([Description(nameof(args))] string[] args)
{
    Console.WriteLine("Hello, World!");
}
```