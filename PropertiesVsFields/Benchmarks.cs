using BenchmarkDotNet.Attributes;

namespace PropertiesVsFields;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private readonly TestClass _instance = new();

    [Params(100_000, 10_000_000)]
    public int Iterations { get; set; }

    [Benchmark(Baseline = true)]
    public void AutoProp()
    {
        int tmp = 0;
        for (int i = 0; i < Iterations; ++i)
        {
            _instance.AutoProp = i;
            tmp = _instance.AutoProp;
        }
    }

    [Benchmark]
    public void NoInliningProp()
    {
        int tmp = 0;
        for (int i = 0; i < Iterations; ++i)
        {
            _instance.NoInliningProp = i;
            tmp = _instance.NoInliningProp;
        }
    }

    [Benchmark]
    public void Field()
    {
        int tmp = 0;
        for (int i = 0; i < Iterations; ++i)
        {
            _instance.FieldValue = i;
            tmp = _instance.FieldValue;
        }
    }
}
