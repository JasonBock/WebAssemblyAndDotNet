using Collatz;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

[assembly: SupportedOSPlatform("wasi")]

Console.WriteLine($"{RuntimeInformation.OSDescription}:{RuntimeInformation.OSArchitecture}");
var sequence = CollatzSequenceGenerator.Generate(42);
Console.WriteLine(string.Join(", ", sequence));