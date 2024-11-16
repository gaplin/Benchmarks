using BenchmarkDotNet.Attributes;

namespace EnumerableToList;

[MemoryDiagnoser(false)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90, baseline: true)]
public class Benchmarks
{
    private readonly List<int> _items = Enumerable.Range(1, 1_000_000).ToList();

    [Benchmark(Baseline = true)]
    public List<int> JustEnumerable()
    {
        IEnumerable<int> odds = _items.Where(x => x % 2 == 1);

        return odds.Select(x => x * x).ToList();
    }

    [Benchmark]
    public List<int> DoubleToList()
    {
        List<int> odds = _items.Where(x => x % 2 == 1).ToList();

        return odds.Select(x => x * x).ToList();
    }
}