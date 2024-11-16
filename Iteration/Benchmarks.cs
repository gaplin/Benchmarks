using BenchmarkDotNet.Attributes;

namespace Iteration;

[MemoryDiagnoser(false)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90, baseline: true)]
public class Benchmarks
{
    [Params(100, 1_000_000)]
    public int StrLength { get; set; }
    private string _str = default!;

    [GlobalSetup]
    public void Setup()
    {
        _str = string.Create(StrLength, StrLength, (chars, length) =>
        {
            for (int i = 0; i < length; ++i)
            {
                chars[i] = (char)('a' + i % 26);
            }
        });
    }

    [Benchmark(Baseline = true)]
    public bool ForeachString()
    {
        return Funcs.ForeachString(_str);
    }
    [Benchmark]
    public bool ForString()
    {
        return Funcs.ForString(_str);
    }
    [Benchmark]
    public bool ForStringLengthOutside()
    {
        return Funcs.ForStringLengthOutside(_str);
    }
    [Benchmark]
    public bool ForeachSpan()
    {
        return Funcs.ForeachSpan(_str);
    }
    [Benchmark]
    public bool ForSpan()
    {
        return Funcs.ForSpan(_str);
    }
    [Benchmark]
    public bool ForSpanLengthOutside()
    {
        return Funcs.ForSpanLengthOutside(_str);
    }
}