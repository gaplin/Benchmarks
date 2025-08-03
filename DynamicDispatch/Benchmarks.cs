using BenchmarkDotNet.Attributes;

namespace DynamicDispatch;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Params(100, 10_000)]
    public int ObjectCount { get; set; }
    public ITest[] ITestObjects { get; set; } = null!;
    public NoInheritance[] NoInheritanceObjects { get; set; } = null!;
    public Random random = new(5);

    [GlobalSetup]
    public void Setup()
    {
        ITestObjects = new ITest[ObjectCount];
        NoInheritanceObjects = new NoInheritance[ObjectCount];
        foreach (var idx in Enumerable.Range(0, ObjectCount))
        {
            var value = random.Next(10_000);
            var objType = random.Next(4);
            ITest itestObj = objType switch
            {
                0 => new ATest { Value = value },
                1 => new AATest { Value = value },
                2 or 3 => new BTest { Value = value },
                _ => throw new InvalidOperationException($"Not recognized type {objType}")
            };
            NoInheritance noInheritanceObj = objType switch
            {
                0 => new() { Type = 0, Value = value },
                1 => new() { Type = 1, Value = value },
                2 or 3 => new() { Type = 2, Value = value },
                _ => throw new InvalidOperationException($"Not recognized type {objType}")
            };
            ITestObjects[idx] = itestObj;
            NoInheritanceObjects[idx] = noInheritanceObj;
        }
    }

    [Benchmark(Baseline = true)]
    public long Polymorphism()
    {
        long result = 0;
        foreach (var obj in ITestObjects)
        {
            result += obj.GetValue();
        }
        return result;
    }

    [Benchmark]
    public long Dynamic()
    {
        long result = 0;
        foreach (var obj in ITestObjects)
        {
            result += Functions.GetCorrectValue((dynamic)obj);
        }
        return result;
    }

    [Benchmark]
    public long Switch()
    {
        long result = 0;
        foreach (var obj in ITestObjects)
        {
            result += obj switch
            {
                AATest aa => Functions.GetCorrectValue(aa),
                ATest a => Functions.GetCorrectValue(a),
                BTest b => Functions.GetCorrectValue(b),
                _ => throw new InvalidOperationException($"Unsupported type {obj.GetType().Name}")
            };
        }
        return result;
    }

    [Benchmark]
    public long NoInheritance()
    {
        long result = 0;
        foreach (var obj in NoInheritanceObjects)
        {
            result += obj.GetValue();
        }
        return result;
    }
}
