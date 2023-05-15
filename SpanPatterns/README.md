# Span pattern match

Now you can use the same pattern matching logic with variables that are Span<char> or ReadOnlySpan<char>.

```csharp
string str = "123456";
ReadOnlySpan<char> span = str;
Console.WriteLine(span.Slice(0, 3) is "123"); //True
```