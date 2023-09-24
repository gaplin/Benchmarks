using BenchmarkDotNet.Attributes;

namespace LambdaVsLocalFunction;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private const int _iterations = 1_000;
    private readonly List<int> _nums = Enumerable.Range(0, 30).ToList();

    [Benchmark(Baseline = true)]
    public void Lambda()
    {
        for (int i = 0; i < _iterations; ++i)
        {
            Methods.LambdaSum(_nums);
        }
    }

    [Benchmark]
    public void LocalFunction()
    {
        for (int i = 0; i < _iterations; ++i)
        {
            Methods.LocalFunctionSum(_nums);
        }
    }
}