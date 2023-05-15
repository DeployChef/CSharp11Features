string longMessage = """
    Lorem ipsum dolor sit amet,
    consectetur adipiscing elit,
    sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
    Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi
    ut aliquip ex ea commodo consequat.
    Duis aute irure dolor in reprehenderit
    in voluptate velit esse cillum dolore
    eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat
    non proident,
    sunt in culpa qui officia deserunt mollit anim id est laborum.
    """;

Console.WriteLine(longMessage);

var innerTagValue = 123;

var tags = $$"""
   <Tag>
    <InnerTag A="{{innerTagValue}}"/>
   </Tag>
   """;

Console.WriteLine(tags);

Console.ReadLine();