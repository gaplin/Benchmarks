using BenchmarkDotNet.Attributes;

namespace CopyIteration;

[MemoryDiagnoser(false)]
[GroupBenchmarksBy(BenchmarkDotNet.Configs.BenchmarkLogicalGroupRule.ByCategory)]
public class Benchmarks
{
    [Params(1_000_000)]
    public int MaxElement { get; set; }
    private readonly List<int> _elementsList = [];
    private IEnumerable<int> _elementsEnumerable = null!;

    [GlobalSetup]
    public void Setup()
    {
        _elementsList.AddRange(Enumerable.Range(1, MaxElement));
        _elementsEnumerable = Enumerable.Range(1, MaxElement);
    }

    [Benchmark(Baseline = true), BenchmarkCategory("FromList")]
    public long ListToListIteration()
    {
        long result = 0;
        foreach (var element in _elementsList.ToList())
        {
            if (element % 6 == 0)
            {
                result += element;
            }
        }
        return result;
    }

    [Benchmark, BenchmarkCategory("FromList")]
    public long ListToArrayIteration()
    {
        long result = 0;
        foreach (var element in _elementsList.ToArray())
        {
            if (element % 6 == 0)
            {
                result += element;
            }
        }
        return result;
    }

    [Benchmark(Baseline = true), BenchmarkCategory("FromEnumerable")]
    public long EnumerableToListIteration()
    {
        long result = 0;
        foreach (var element in _elementsEnumerable.ToList())
        {
            if (element % 6 == 0)
            {
                result += element;
            }
        }
        return result;
    }

    [Benchmark, BenchmarkCategory("FromEnumerable")]
    public long EnumerableToArrayIteration()
    {
        long result = 0;
        foreach (var element in _elementsEnumerable.ToArray())
        {
            if (element % 6 == 0)
            {
                result += element;
            }
        }
        return result;
    }
}