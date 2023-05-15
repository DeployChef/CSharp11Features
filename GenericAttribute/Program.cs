[Type<string>]
internal class Program
{
    static void Main(string[] args)
    {
        var attribute = typeof(Program).GetCustomAttributes(false)[0] as TypeAttribute<string>;
    }
}

public class TypeAttribute<T> : Attribute { }
