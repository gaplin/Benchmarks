using BenchmarkDotNet.Attributes;

namespace ListArrayInit;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Params(1_000, 1_000_000)]
    public int Count { get; set; }

    [Benchmark(Baseline = true)]
    public List<string> EnumerableToList()
    {
        return Enumerable.Range(0, Count).Select(x => x.ToString()).ToList();
    }

    [Benchmark]
    public List<string> ListAdd()
    {
        List<string> result = [];
        for (int i = 0; i < Count; ++i)
        {
            result.Add(i.ToString());
        }
        return result;
    }

    [Benchmark]
    public List<string> ListAddWithCorrectCapacity()
    {
        List<string> result = new(Count);
        for (int i = 0; i < Count; ++i)
        {
            result.Add(i.ToString());
        }
        return result;
    }

    [Benchmark]
    public string[] EnumerableToArray()
    {
        return Enumerable.Range(0, Count).Select(x => x.ToString()).ToArray();
    }

    [Benchmark]
    public string[] ArrayFill()
    {
        string[] arr = new string[Count];
        for (int i = 0; i < Count; ++i)
        {
            arr[i] = i.ToString();
        }
        return arr;
    }
}
