# Generic attribute

Now we can declare a generic class whose base class is System.Attribute. This feature provides a more convenient syntax for attributes that require a System.Type parameter.

```csharp
[Type<string>]
internal class Program
{
    static void Main(string[] args)
    {
        var attribute = typeof(Program).GetCustomAttributes(false)[0] as TypeAttribute<string>;
    }
}

public class TypeAttribute<T> : Attribute { }
```