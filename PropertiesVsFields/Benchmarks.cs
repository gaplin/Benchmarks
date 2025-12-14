using BenchmarkDotNet.Attributes;

namespace PropertiesVsFields;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private readonly TestClass _instance = new();

    [Params(100_000, 10_000_000)]
    public int Iterations { get; set; }

    [Benchmark(Baseline = true)]
    public long AutoProp()
    {
        long sum = 0;
        for (int i = 0; i < Iterations; ++i)
        {
            _instance.AutoProp = i;
            sum += _instance.AutoProp;
        }
        return sum;
    }

    [Benchmark]
    public long NoInliningProp()
    {
        long sum = 0;
        for (int i = 0; i < Iterations; ++i)
        {
            _instance.NoInliningProp = i;
            sum += _instance.NoInliningProp;
        }
        return sum;
    }

    [Benchmark]
    public long Field()
    {
        long sum = 0;
        for (int i = 0; i < Iterations; ++i)
        {
            _instance.FieldValue = i;
            sum += _instance.FieldValue;
        }
        return sum;
    }
}
