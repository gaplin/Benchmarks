using BenchmarkDotNet.Attributes;
using NextStringNameFunc.TestCases;

namespace NextStringNameFunc;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Params("FirstPropositionnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnndddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddn")]
    public string Candidate { get; set; } = default!;

    [Params(20_000)]
    public int TakenNamesLastNumber { get; set; }

    private List<string> _takenNames = default!;

    [GlobalSetup]
    public void Setup()
    {
        List<string>? takenNames =
        [
            Candidate
        ];
        for (int i = 1; i <= TakenNamesLastNumber; ++i)
        {
            takenNames.Add(Candidate + i);
        }
        _takenNames = takenNames;
    }

    [Benchmark(Baseline = true)]
    public string StringTest()
    {
        return Strings.NextNameWithString(Candidate, _takenNames);
    }

    [Benchmark]
    public string StringHashTest()
    {
        return Strings.NextNameWithStringAndHashset(Candidate, _takenNames);
    }

    [Benchmark]
    public string StringHashTestNewLookup()
    {
        return Strings.NextNameWithStringAndHashsetWithNewLookup(Candidate, _takenNames);
    }

    [Benchmark]
    public string SpanTest()
    {
        return Strings.NextNameWithSpan(Candidate, _takenNames);
    }
}