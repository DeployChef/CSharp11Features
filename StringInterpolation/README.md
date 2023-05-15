# String interpolations accept newlines

The text inside the { and } characters for a string interpolation can now span multiple lines. The text between the { and } markers is parsed as C#. Any legal C#, including newlines, is allowed. This feature makes it easier to read string interpolations that use longer C# expressions, like pattern matching switch expressions, or LINQ queries.

```csharp
Console.WriteLine($"Framework Description: {RuntimeInformation
    .FrameworkDescription}  - OS Verion: {Environment
    .OSVersion
    .VersionString} - machine name: {Environment
    .MachineName}");
```
