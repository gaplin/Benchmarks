using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Runtime.InteropServices;

namespace ListOpsVsLinq;

[MemoryDiagnoser(false)]
[SimpleJob(RuntimeMoniker.Net80, baseline: true)]
[SimpleJob(RuntimeMoniker.Net90)]
public class Benchmarks
{
    private List<int> _ints = null!;

    [Params(1_000_000)]
    public int MaxElem { get; set; }
    private int _toFind;

    [GlobalSetup]
    public void Setup()
    {
        _ints = [.. Enumerable.Range(1, MaxElem)];
        _toFind = MaxElem / 2;
    }

    [Benchmark(Baseline = true)]
    public int? Find()
    {
        return _ints.Find(x => x == _toFind);
    }

    [Benchmark]
    public int? FirstOrDefault()
    {
        return _ints.FirstOrDefault(x => x == _toFind);
    }

    [Benchmark]
    public int? FindDirectly()
    {
        foreach(int x in CollectionsMarshal.AsSpan(_ints))
        {
            if(x == _toFind)
            {
                return x;
            }
        }
        return null;
    }
}
