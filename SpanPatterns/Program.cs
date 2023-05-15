
string str = "123456";
ReadOnlySpan<char> span = str;
Console.WriteLine(span.Slice(0, 3) is "123"); //True
