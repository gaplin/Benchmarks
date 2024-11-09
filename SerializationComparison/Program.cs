using BenchmarkDotNet.Running;
using SerializationComparison;

BenchmarkRunner.Run<Benchmarks>();

Console.WriteLine("Five");