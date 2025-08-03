using BenchmarkDotNet.Attributes;

namespace LinqChaining;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private int[] _nums = null!;
    private readonly Random _random = new(5);

    [GlobalSetup]
    public void Setup()
    {
        _nums = [.. Enumerable.Range(0, 1_000_000).Select(x => _random.Next(1_000_000_000))];
    }

    [Benchmark(Baseline = true)]
    public long NoLinq()
    {
        long result = 0;
        foreach (var num in _nums)
        {
            if (num % 2 == 0 && num > 10 && num < 5_500_000 && num % 3 == 0 && num % 5 == 2)
            {
                result += num;
            }
        }
        return result;
    }

    [Benchmark]
    public long Linq()
    {
        long result = 0;
        foreach (var num in _nums
            .Where(x => x % 2 == 0)
            .Where(x => x > 10)
            .Where(x => x < 5_500_000)
            .Where(x => x % 3 == 0)
            .Where(x => x % 5 == 2))
        {
            result += num;
        }
        return result;
    }
}