// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

Console.WriteLine($"Framework Description: {RuntimeInformation
    .FrameworkDescription}  - OS Verion: {Environment
    .OSVersion
    .VersionString} - machine name: {Environment
    .MachineName}");
