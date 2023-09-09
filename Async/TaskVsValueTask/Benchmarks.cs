using BenchmarkDotNet.Attributes;

namespace Async.TaskVsValueTask;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Benchmark(Baseline = true)]
    public async Task ValueTasksInt()
    {
        var result = await ValueTaskDeepInt.F1();
    }

    [Benchmark]
    public async Task TasksInt()
    {
        var result = await TaskDeepInt.G1();
    }

    [Benchmark]
    public async Task ValueTasksAsyncInt()
    {
        var result = await ValueTaskAsyncDeepInt.F1();
    }

    [Benchmark]
    public async Task TasksAsyncInt()
    {
        var result = await TaskAsyncDeepInt.G1();
    }

    [Benchmark]
    public async Task ValueTasksDummy()
    {
        var result = await ValueTaskDeepDummy.F1();
    }

    [Benchmark]
    public async Task TasksDummy()
    {
        var result = await TaskDeepDummy.G1();
    }

    [Benchmark]
    public async Task ValueTasksAsyncDummy()
    {
        var result = await ValueTaskAsyncDeepDummy.F1();
    }

    [Benchmark]
    public async Task TasksAsyncDummy()
    {
        var result = await TaskAsyncDeepDummy.G1();
    }
}