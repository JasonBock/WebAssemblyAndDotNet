using Collatz;
using System.Runtime.Versioning;

[assembly: SupportedOSPlatform("wasi")]

var sequence = CollatzSequenceGenerator.Generate(42);
Console.WriteLine(string.Join(", ", sequence));