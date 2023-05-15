using System.ComponentModel;

namespace NameOfAttribute;

internal class Program
{
    [Description(nameof(Main))]
    static void Main([Description(nameof(args))] string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
