using BenchmarkDotNet.Attributes;
using System.Text;

namespace SortWithLookupVsProperty;

[MemoryDiagnoser(false)]
[GroupBenchmarksBy(BenchmarkDotNet.Configs.BenchmarkLogicalGroupRule.ByCategory)]
public class Benchmarks
{
    private List<ForSorting<string>> _stringItems = null!;
    private List<ForSorting<int>> _intItems = null!;
    private readonly Dictionary<string, int> _stringLookup = [];
    private readonly Dictionary<int, int> _intLookup = [];
    private readonly Random _random = new(55);

    [Params(1_000)]
    public int ListSize { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _stringItems = new(ListSize);
        _intItems = new(ListSize);
        Span<byte> bytes = stackalloc byte[30];
        for (int i = 0; i < ListSize; i++)
        {
            int sortValue = _random.Next();
            while (true)
            {
                _random.NextBytes(bytes);
                string stringId = Encoding.UTF8.GetString(bytes);
                if (_stringLookup.ContainsKey(stringId))
                {
                    continue;
                }
                _stringLookup[stringId] = sortValue;
                _stringItems.Add(new(stringId));
                break;
            }
            while (true)
            {
                int intId = _random.Next();
                if (_intLookup.ContainsKey(intId))
                {
                    continue;
                }
                _intItems.Add(new(intId));
                _intLookup[intId] = sortValue;
                break;
            }
        }
    }

    [Benchmark(Baseline = true), BenchmarkCategory("String")]
    public List<ForSorting<string>> SortWithLookupString()
    {
        var lst = new List<ForSorting<string>>(_stringItems);
        lst.Sort((x, y) => _stringLookup[x.Id].CompareTo(_stringLookup[y.Id]));
        return lst;
    }

    [Benchmark, BenchmarkCategory("String")]
    public List<ForSorting<string>> SortWithPropertyFillingString()
    {
        foreach (var item in _stringItems)
        {
            item.SortValue = _stringLookup[item.Id];
        }
        var lst = new List<ForSorting<string>>(_stringItems);
        lst.Sort((x, y) => x.SortValue.CompareTo(y.SortValue));
        return lst;
    }

    [Benchmark(Baseline = true), BenchmarkCategory("Int")]
    public List<ForSorting<int>> SortWithLookupInt()
    {
        var lst = new List<ForSorting<int>>(_intItems);
        lst.Sort((x, y) => _intLookup[x.Id].CompareTo(_intLookup[y.Id]));
        return lst;
    }

    [Benchmark, BenchmarkCategory("Int")]
    public List<ForSorting<int>> SortWithPropertyFillingInt()
    {
        foreach (var item in _intItems)
        {
            item.SortValue = _intLookup[item.Id];
        }
        var lst = new List<ForSorting<int>>(_intItems);
        lst.Sort((x, y) => x.SortValue.CompareTo(y.SortValue));
        return lst;
    }

    public sealed class ForSorting<T>
    {
        public T Id { get; }
        public int SortValue { get; set; } = -1;
        public ForSorting(T id)
        {
            Id = id;
        }
    }
}