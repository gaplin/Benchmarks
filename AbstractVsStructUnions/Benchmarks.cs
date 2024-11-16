using BenchmarkDotNet.Attributes;

namespace AbstractVsStructUnions;

[MemoryDiagnoser(false)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90, baseline: true)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
public class Benchmarks
{
    [Params(1_000_000)]
    public int Iterations { get; set; }

    private AbstractUnion<int, string, long> _abstrFirst = default!;
    private AbstractUnion<int, string, long> _abstrSecond = default!;
    private AbstractUnion<int, string, long> _abstrThird = default!;

    private StructUnion<int, string, long> _strFirst;
    private StructUnion<int, string, long> _strSecond;
    private StructUnion<int, string, long> _strThird;

    [GlobalSetup]
    public void Setup()
    {
        _abstrFirst = 5;
        _abstrSecond = "555";
        _abstrThird = 123L;

        _strFirst = 5;
        _strSecond = "555";
        _strThird = 123L;
    }

    [Benchmark(Baseline = true)]
    public long AbstractMatch()
    {
        long sum = 0;
        for (int i = 0; i < Iterations; ++i)
        {
            sum += _abstrFirst switch
            {
                AbstractUnion<int, string, long>.First f => f.Value,
                AbstractUnion<int, string, long>.Second f => int.Parse(f.Value),
                AbstractUnion<int, string, long>.Third f => f.Value,
                _ => 0
            };
            sum += _abstrSecond switch
            {
                AbstractUnion<int, string, long>.First f => f.Value,
                AbstractUnion<int, string, long>.Second f => int.Parse(f.Value),
                AbstractUnion<int, string, long>.Third f => f.Value,
                _ => 0
            };
            sum += _abstrThird switch
            {
                AbstractUnion<int, string, long>.First f => f.Value,
                AbstractUnion<int, string, long>.Second f => int.Parse(f.Value),
                AbstractUnion<int, string, long>.Third f => f.Value,
                _ => 0
            };
        }

        return sum;
    }

    [Benchmark]
    public long StructMatch()
    {
        long sum = 0;
        for (int i = 0; i < Iterations; ++i)
        {
            sum += _strFirst.Index switch
            {
                0 => _strFirst.AsT1,
                1 => int.Parse(_strFirst.AsT2),
                2 => _strFirst.AsT3,
                _ => 0
            };
            sum += _strSecond.Index switch
            {
                0 => _strSecond.AsT1,
                1 => int.Parse(_strSecond.AsT2),
                2 => _strSecond.AsT3,
                _ => 0
            };
            sum += _strThird.Index switch
            {
                0 => _strThird.AsT1,
                1 => int.Parse(_strThird.AsT2),
                2 => _strThird.AsT3,
                _ => 0
            };
        }

        return sum;
    }
}
