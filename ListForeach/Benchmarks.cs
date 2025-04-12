using BenchmarkDotNet.Attributes;

namespace ListForeach;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private readonly List<int> _ints = [.. Enumerable.Range(0, 1_000_000)];

    [Benchmark(Baseline = true)]
    public long ForeachList()
    {
        long sum = 0;
        foreach (var value in _ints)
        {
            sum += value;
        }
        return sum;
    }

    [Benchmark]
    public long ForeachEnumerable()
    {
        long sum = 0;
        foreach (var value in (IEnumerable<int>)_ints)
        {
            sum += value;
        }
        return sum;
    }
}
