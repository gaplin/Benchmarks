using BenchmarkDotNet.Attributes;

namespace LambdaVsLocalFunction;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private readonly List<int> _nums = Enumerable.Range(1, 1_000_000).ToList();

    [Benchmark(Baseline = true)]
    public long Lambda()
    {
        return Methods.LambdaSum(_nums);
    }

    [Benchmark]
    public long LocalFunction()
    {
        return Methods.LocalFunctionSum(_nums);
    }
}