using BenchmarkDotNet.Attributes;

namespace Virtual;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Params(1_000_000)]
    public int Iteration { get; set; }

    private ITestAdder _itestAdder = default!;
    private ATestAdder _atestAdder = default!;
    private TestAdder _testAdder = default!;
    private readonly Random _random = new(500);
    private List<(int first, int second)> _items = [];

    [GlobalSetup]
    public void Setup()
    {
        _itestAdder = new TestAdderI();
        _atestAdder = new TestAdderA();
        _testAdder = new TestAdder();
        for (int i = 0; i < Iteration; ++i)
        {
            _items.Add((_random.Next() % 1000, _random.Next() % 1000));
        }
    }

    [Benchmark(Baseline = true)]
    public long TestAdderDirectly()
    {
        long result = 0;
        foreach ((int a, int b) in _items)
        {
            result += Add(_testAdder, a, b);
        }
        return result;
    }

    [Benchmark]
    public long TestAdderInterface()
    {
        long result = 0;
        foreach ((int a, int b) in _items)
        {
            result += Add(_itestAdder, a, b);
        }
        return result;
    }

    [Benchmark]
    public long TestAdderAbstract()
    {
        long result = 0;
        foreach ((int a, int b) in _items)
        {
            result += Add(_atestAdder, a, b);
        }
        return result;
    }

    public static int Add(ITestAdder adder, int a, int b) => adder.Add(a, b);
    public static int Add(ATestAdder adder, int a, int b) => adder.Add(a, b);
    public static int Add(TestAdder adder, int a, int b) => adder.Add(a, b);
}