using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Runtime.InteropServices;

namespace ListOpsVsLinq;

[MemoryDiagnoser(false)]
[SimpleJob(RuntimeMoniker.Net90)]
[SimpleJob(RuntimeMoniker.Net10_0)]
public class BenchmarksConst
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
    public int? FindWithoutElseConst()
    {
        return _ints.FindWithoutElse(x => x == 500_000);
    }

    [Benchmark]
    public int? FindWithElseConst()
    {
        return _ints.FindWithElse(x => x == 500_000);
    }

    [Benchmark]
    public int? FindWithoutElseVariable()
    {
        return _ints.FindWithoutElse(x => x == _toFind);
    }

    [Benchmark]
    public int? FindWithElseVariable()
    {
        return _ints.FindWithElse(x => x == _toFind);
    }
}

public static class LstExtensions
{
    public static TSource? FindWithoutElse<TSource>(this List<TSource> lst, Func<TSource, bool> predicate)
    {
        var span = CollectionsMarshal.AsSpan(lst);
        foreach (TSource item in span)
        {
            if (predicate(item)) return item;
        }
        return default;
    }

    public static TSource? FindWithElse<TSource>(this List<TSource> lst, Func<TSource, bool> predicate)
    {
        if (TryGetSpan(lst, out ReadOnlySpan<TSource> span))
        {
            foreach (TSource item in span)
            {
                if (predicate(item)) return item;
            }
        }
        else
        {
            foreach (TSource item in lst)
            {
                if (predicate(item)) return item;
            }
        }
        return default;
    }

    public static bool TryGetSpan<TSource>(this List<TSource> lst, out ReadOnlySpan<TSource> span)
    {
        span = CollectionsMarshal.AsSpan(lst);
        return true;
    }
}
