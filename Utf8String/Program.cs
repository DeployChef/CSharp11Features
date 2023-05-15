using System.Text;

string str = "Строка";
var b1 = Encoding.Unicode.GetBytes(str);
ReadOnlySpan<byte> b2 = "Строка"u8;
Console.WriteLine(string.Join("-", b1)); //33-4-66-4-64-4-62-4-58-4-48-4
Console.WriteLine(string.Join("-", b2.ToArray())); //208-161-209-130-209-128-208-190-208-186-208-176
var b3 = "Строка"u8.ToArray();
