# Required members

We can add the required modifier to properties and fields to enforce constructors and callers to initialize those values. The System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute can be added to constructors to inform the compiler that a constructor initializes all required members.

Worker.cs
```csharp
public class Person
{
    public Person() { }

    [SetsRequiredMembers]
    public Person(string firstName) => FirstName = firstName;

    public required string FirstName { get; init; }
}
```

Program.cs
```csharp
var person = new VersionNinePoint2.Person("John");
person = new VersionNinePoint2.Person{ FirstName = "John"};
// Error CS9035: Required member `Person.FirstName` must be set:
// person = new VersionNinePoint2.Person();
```