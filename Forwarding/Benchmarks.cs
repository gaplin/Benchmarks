﻿using BenchmarkDotNet.Attributes;

namespace Forwading;

[MemoryDiagnoser(false)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90, baseline: true)]
public class Benchmarks
{
    [Params(10, 100, 1_000)]
    public int Iterations { get; set; }

    [Params(10, 100, 1_000)]
    public int TaskSize { get; set; }

    [Benchmark(Baseline = true)]
    public async Task AwaitStuff()
    {
        await PlayGround.AwaitStuff(Iterations, TaskSize);
    }

    [Benchmark]
    public async Task PassStuff()
    {
        await PlayGround.PassToStuff(Iterations, TaskSize);
    }
}