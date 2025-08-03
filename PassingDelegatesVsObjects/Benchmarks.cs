using BenchmarkDotNet.Attributes;

namespace PassingDelegatesVsObjects;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Params(100, 10_000)]
    public int Iterations { get; set; }

    private Calculator _calculatorWithInterface = null!;
    private Calculator _calculatorWithDirectObject = null!;
    private Calculator _calculatorWithDelegate = null!;
    private (int a, int b)[] _nums = null!;
    private readonly Random _random = new(5);

    [GlobalSetup]
    public void Setup()
    {
        static long addDelegateImpl(int a, int b) => a + b;
        _calculatorWithInterface = new((IAdder)new Adder());
        _calculatorWithDirectObject = new(new Adder());
        _calculatorWithDelegate = new(addDelegateImpl);

        _nums = new (int, int)[Iterations];
        for (int i = 0; i < Iterations; ++i)
        {
            _nums[i] = (_random.Next(1_000_000), _random.Next(1_000_000));
        }
    }

    [Benchmark(Baseline = true)]
    public long Interface()
    {
        long result = 0;
        foreach ((int a, int b) in _nums)
        {
            result += _calculatorWithInterface.AddInterface(a, b);
        }
        return result;
    }

    [Benchmark]
    public long DirectObject()
    {
        long result = 0;
        foreach ((int a, int b) in _nums)
        {
            result += _calculatorWithDirectObject.AddDirectObject(a, b);
        }
        return result;
    }

    [Benchmark]
    public long Delegate()
    {
        long result = 0;
        foreach ((int a, int b) in _nums)
        {
            result += _calculatorWithDelegate.AddDelegate(a, b);
        }
        return result;
    }
}