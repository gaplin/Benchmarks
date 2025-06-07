using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using ZLinq;

namespace ZlinqVsLinq;

[MemoryDiagnoser(false)]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
public class Benchmarks
{
    private int[] _ints = null!;

    [GlobalSetup]
    public void Setup()
    {
        _ints = [.. Enumerable.Range(1, 1_000_000)];
    }

    [Benchmark(Baseline = true), BenchmarkCategory("Where")]
    public int WhereLinq()
    {
        var odds = _ints.Where(x => x % 2 == 1);
        int count = 0;
        foreach (var odd in odds)
        {
            ++count;
        }
        return count;
    }

    [Benchmark, BenchmarkCategory("Where")]
    public int WhereZlinq()
    {
        var odds = _ints.AsValueEnumerable().Where(x => x % 2 == 1);
        int count = 0;
        foreach (var odd in odds)
        {
            ++count;
        }
        return count;
    }

    [Benchmark(Baseline = true), BenchmarkCategory("WhereToList")]
    public List<int> WhereToListLinq()
    {
        var odds = _ints.Where(x => x % 2 == 1).ToList();
        return odds;
    }

    [Benchmark, BenchmarkCategory("WhereToList")]
    public List<int> WhereToListZlinq()
    {
        var odds = _ints.AsValueEnumerable().Where(x => x % 2 == 1).ToList();
        return odds;
    }
}
