using BenchmarkDotNet.Attributes;

namespace Virtual;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Params(1000)]
    public int Iteration { get; set; }

    [Params(100000)]
    public int A { get; set; }
    [Params(20000)]
    public int B { get; set; }

    private ITestAdder _itestAdder;
    private ATestAdder _atestAdder;
    private TestAdder _testAdder;

    [GlobalSetup]
    public void Setup()
    {
        _itestAdder = new TestAdderI();
        _atestAdder = new TestAdderA();
        _testAdder = new TestAdder();

    }

    [Benchmark(Baseline = true)]
    public void TestAdderDirectly()
    {
        for (int i = 0; i < Iteration; i++)
        {
            var result = Add(_testAdder, A, B);
        }
    }

    [Benchmark]
    public void TestAdderInterface()
    {
        for (int i = 0; i < Iteration; i++)
        {
            var result = Add(_itestAdder, A, B);
        }
    }

    [Benchmark]
    public void TestAdderAbstract()
    {
        for (int i = 0; i < Iteration; i++)
        {
            var result = Add(_atestAdder, A, B);
        }
    }

    public static int Add(ITestAdder adder, int a, int b) => adder.Add(a, b);
    public static int Add(ATestAdder adder, int a, int b) => adder.Add(a, b);
    public static int Add(TestAdder adder, int a, int b) => adder.Add(a, b);


}