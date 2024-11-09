using BenchmarkDotNet.Running;
using SerializationComparison;

BenchmarkRunner.Run<Benchmarks>();

Console.WriteLine("First");
Console.WriteLine("Second");