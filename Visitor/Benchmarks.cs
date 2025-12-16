using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Visitor._10Targets;
using Visitor._4Targets;

namespace Visitor;

[MemoryDiagnoser(false), GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory, BenchmarkLogicalGroupRule.ByParams)]
public class Benchmarks
{
    private readonly Random _rand = new(555);

    [Params(1_000, 1_000_000)]
    public int Count { get; set; }

    private Base4Target[] _targets4 = null!; // set in GlobalSetup
    private Base10Target[] _targets10 = null!; // set in GlobalSetup

    [GlobalSetup]
    public void Init()
    {
        _targets4 = new Base4Target[Count];
        _targets10 = new Base10Target[Count];
        for (int i = 0; i < Count; i += 4)
        {
            _targets4[i] = new Target4_1 { Value = _rand.Next() % 100 };
            _targets4[i + 1] = new Target4_2 { Value = _rand.Next() % 100 };
            _targets4[i + 2] = new Target4_3 { Value = _rand.Next() % 100 };
            _targets4[i + 3] = new Target4_4 { Value = _rand.Next() % 100 };
        }
        for (int i = 0; i < Count; i += 10)
        {
            _targets10[i] = new Target10_1 { Value = _rand.Next() % 100 };
            _targets10[i + 1] = new Target10_2 { Value = _rand.Next() % 100 };
            _targets10[i + 2] = new Target10_3 { Value = _rand.Next() % 100 };
            _targets10[i + 3] = new Target10_4 { Value = _rand.Next() % 100 };
            _targets10[i + 4] = new Target10_5 { Value = (short)(_rand.Next() % 100) };
            _targets10[i + 5] = new Target10_6 { Value = (char)(_rand.Next() % 100) };
            _targets10[i + 6] = new Target10_7 { Value = (byte)(_rand.Next() % 100) };
            _targets10[i + 7] = new Target10_8 { Value = _rand.Next() % 100 };
            _targets10[i + 8] = new Target10_9 { Value = _rand.Next() % 100 };
            _targets10[i + 9] = new Target10_10 { Value = _rand.Next() % 100 };
        }
        _rand.Shuffle(_targets4);
        _rand.Shuffle(_targets10);
    }

    [Benchmark(Baseline = true), BenchmarkCategory("4")]
    public decimal Visitor4()
    {
        var visitor = new Sum4Visitor();
        foreach (var target in _targets4)
        {
            target.Accept(visitor);
        }

        return visitor.RollingSum;
    }

    [Benchmark, BenchmarkCategory("4")]
    public decimal PatternSwitch4()
    {
        var calc = new Base4Sum();
        foreach (var target in _targets4)
        {
            calc.Process(target);
        }

        return calc.RollingSum;
    }

    [Benchmark(Baseline = true), BenchmarkCategory("10")]
    public decimal Visitor10()
    {
        var visitor = new Sum10Visitor();
        foreach (var target in _targets10)
        {
            target.Accept(visitor);
        }

        return visitor.RollingSum;
    }

    [Benchmark, BenchmarkCategory("10")]
    public decimal PatternSwitch10()
    {
        var calc = new Base10Sum();
        foreach (var target in _targets10)
        {
            calc.Process(target);
        }

        return calc.RollingSum;
    }
}