using BenchmarkDotNet.Attributes;

namespace Iteration;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Params(100, 1000000)]
    public int StrLength { get; set; }
    private string _str { get; set; } = default!;

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
    public void ForeachString()
    {
        Funcs.ForeachString(_str);
    }
    [Benchmark]
    public void ForString()
    {
        Funcs.ForString(_str);
    }
    [Benchmark]
    public void ForStringLengthOutside()
    {
        Funcs.ForStringLengthOutside(_str);
    }
    [Benchmark]
    public void ForeachSpan()
    {
        Funcs.ForeachSpan(_str);
    }
    [Benchmark]
    public void ForSpan()
    {
        Funcs.ForSpan(_str);
    }
    [Benchmark]
    public void ForSpanLengthOutside()
    {
        Funcs.ForSpanLengthOutside(_str);
    }
}