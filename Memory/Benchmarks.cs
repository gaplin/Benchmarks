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

    private IEnumerable<string> _takenNames = default!;

    [GlobalSetup]
    public void Setup()
    {
        List<string>? takenNames =
        [
            Candidate
        ];
        for (int i = 1; i <= TakenNamesLastNumber; ++i)
        {
            takenNames.Add("Candidate" + i);
        }
        _takenNames = takenNames;
    }

    [Benchmark(Baseline = true)]
    public void StringTest()
    {
        var result = Strings.NextNameWithString(Candidate, _takenNames.ToList());
    }

    [Benchmark]
    public void StringSortTest()
    {
        var result = Strings.NextNameWithStringAndSort(Candidate, _takenNames.ToList());
    }

    [Benchmark]
    public void StringHashTest()
    {
        var result = Strings.NextNameWithStringAndHashset(Candidate, _takenNames.ToList());
    }

    [Benchmark]
    public void SpanTest()
    {
        var result = Strings.NextNameWithSpan(Candidate, _takenNames.ToList());
    }
}