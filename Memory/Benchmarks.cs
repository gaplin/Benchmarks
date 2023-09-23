using BenchmarkDotNet.Attributes;
using Memory.TestCases;

namespace Memory;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Params("FirstPropositionnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnndddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddn")]
    public string Candidate { get; set; } = default!;

    [Params(20000)]
    public int TakenNamesLastNumber { get; set; }

    private List<string> _takenNames = default!;

    [GlobalSetup]
    public void Setup()
    {
        _takenNames = new()
        {
            Candidate
        };
        for (int i = 1; i <= TakenNamesLastNumber; ++i)
        {
            _takenNames.Add("Candidate" + i);
        }
    }

    [Benchmark(Baseline = true)]
    public void StringTest()
    {
        var result = Strings.NextNameWithString(Candidate, _takenNames);
    }

    [Benchmark]
    public void StringSortTest()
    {
        var result = Strings.NextNameWithStringAndSort(Candidate, _takenNames);
    }

    [Benchmark]
    public void StringHashTest()
    {
        var result = Strings.NextNameWithStringAndHashset(Candidate, _takenNames);
    }

    [Benchmark]
    public void SpanTest()
    {
        var result = Strings.NextNameWithSpan(Candidate, _takenNames);
    }
}