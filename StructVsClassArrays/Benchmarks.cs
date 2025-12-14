using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace StructVsClassArrays;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private struct StrBlob
    {
        public int A;
        public int B;

        public StrBlob(int a, int b) => (A, B) = (a, b);
    }

    private sealed class ClsBlob
    {
        public int A;
        public int B;

        public ClsBlob(int a, int b) => (A, B) = (a, b);
    }

    [Params(1_000, 1_000_000)]
    public int ArrSize { get; set; }

    private StrBlob[] _strArr = default!;
    private ClsBlob[] _clsArr = default!;

    [GlobalSetup]
    public void Setup()
    {
        _strArr = new StrBlob[ArrSize];
        _clsArr = new ClsBlob[ArrSize];
        for (int i = 0; i < ArrSize; i++)
        {
            int a = Random.Shared.Next() % 100;
            int b = Random.Shared.Next() % 100;
            _strArr[i] = new StrBlob(a, b);
            _clsArr[i] = new ClsBlob(a, b);
        }
    }

    [Benchmark(Baseline = true)]
    public int TestClass()
    {
        int sum = 0;
        for (int i = 0; i < ArrSize; ++i)
        {
            sum += _clsArr[i].A + _clsArr[i].B;
        }
        return sum;
    }

    [Benchmark]
    public int TestStruct()
    {
        int sum = 0;
        for (int i = 0; i < ArrSize; ++i)
        {
            sum += _strArr[i].A + _strArr[i].B;
        }
        return sum;
    }
}
