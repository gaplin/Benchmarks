using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace StructVsClassArrays;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private struct StrBlob
    {
        public int A;
        public double C;
        public int B;

        public StrBlob(int a, int b, double c) => (A, B, C) = (a, b, c);
    }

    private struct StructOfArrays
    {
        public int[] A;
        public int[] B;
        public double[] C;

        public StructOfArrays()
        {
            A = [];
            B = [];
            C = [];
        }
    }

    private sealed class ClsBlob
    {
        public int A;
        public int B;
        public double C;

        public ClsBlob(int a, int b, double c) => (A, B, C) = (a, b, c);
    }

    [Params(1_000, 1_000_000)]
    public int ArrSize { get; set; }

    private StrBlob[] _strArr = default!;
    private ClsBlob[] _clsArr = default!;
    private StructOfArrays _strOfArrays = new();

    [GlobalSetup]
    public void Setup()
    {
        _strArr = new StrBlob[ArrSize];
        _clsArr = new ClsBlob[ArrSize];
        _strOfArrays.A = new int[ArrSize];
        _strOfArrays.B = new int[ArrSize];
        _strOfArrays.C = new double[ArrSize];
        for (int i = 0; i < ArrSize; i++)
        {
            int a = Random.Shared.Next() % 100;
            int b = Random.Shared.Next() % 100;
            double c = Random.Shared.NextDouble() + 0.001d;
            _strArr[i] = new StrBlob(a, b, c);
            _clsArr[i] = new ClsBlob(a, b, c);
            _strOfArrays.A[i] = a;
            _strOfArrays.B[i] = b;
            _strOfArrays.C[i] = c;
        }
    }

    [Benchmark(Baseline = true)]
    public double TestClass()
    {
        double sum = 0;
        for (int i = 0; i < ArrSize; ++i)
        {
            sum += _clsArr[i].A + _clsArr[i].B + _clsArr[i].C;
        }
        return sum;
    }

    [Benchmark]
    public double TestStruct()
    {
        double sum = 0;
        for (int i = 0; i < ArrSize; ++i)
        {
            sum += _strArr[i].A + _strArr[i].B + _strArr[i].C;
        }
        return sum;
    }

    [Benchmark]
    public double TestStructOfArrays()
    {
        double sum = 0;
        for (int i = 0; i < ArrSize; ++i)
        {
            sum += _strOfArrays.A[i] + _strOfArrays.B[i] + _strOfArrays.C[i];
        }
        return sum;
    }
}
