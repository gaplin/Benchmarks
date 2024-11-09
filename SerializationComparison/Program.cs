using BenchmarkDotNet.Running;
using SerializationComparison;

BenchmarkRunner.Run<Benchmarks>();

Console.WriteLine("Remake");
Console.WriteLine("New text");