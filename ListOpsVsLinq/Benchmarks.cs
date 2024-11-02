using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace ListOpsVsLinq;

[MemoryDiagnoser(false)]
[SimpleJob(RuntimeMoniker.Net80, baseline: true)]
[SimpleJob(RuntimeMoniker.Net90)]
public class Benchmarks
{
    private readonly List<int> _ints = [.. Enumerable.Range(0, 1_000_000)];

    [Benchmark(Baseline = true)]
    public int? Find()
    {
        return _ints.Find(x => x == 500_000);
    }

    [Benchmark]
    public int? FirstOrDefault()
    {
        return _ints.FirstOrDefault(x => x == 500_000);
    }
}
