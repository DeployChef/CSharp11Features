namespace StaticAndVirtualInterfaces;

internal class Program
{
    static void Main(string[] args)
    {
        var counter1 = new Counter(){Count = 2};
        var counter2 = new Counter(){Count = 1};
        var result = counter1 + counter2;
        Console.WriteLine(result);
    }
}

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
