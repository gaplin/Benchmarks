using BenchmarkDotNet.Attributes;

namespace Async.TaskVsValueTask;

[MemoryDiagnoser(false)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90, baseline: true)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
public class Benchmarks
{
    [Benchmark(Baseline = true)]
    public async ValueTask<int> ValueTasksInt()
    {
        return await ValueTaskDeepInt.F1();
    }

    [Benchmark]
    public async Task<int> TasksInt()
    {
        return await TaskDeepInt.G1();
    }

    [Benchmark]
    public async ValueTask<int> ValueTasksAsyncInt()
    {
        return await ValueTaskAsyncDeepInt.F1();
    }

    [Benchmark]
    public async Task<int> TasksAsyncInt()
    {
        return await TaskAsyncDeepInt.G1();
    }

    [Benchmark]
    public async Task<Dummy> ValueTasksDummy()
    {
        return await ValueTaskDeepDummy.F1();
    }

    [Benchmark]
    public async Task<Dummy> TasksDummy()
    {
        return await TaskDeepDummy.G1();
    }

    [Benchmark]
    public async Task<Dummy> ValueTasksAsyncDummy()
    {
        return await ValueTaskAsyncDeepDummy.F1();
    }

    [Benchmark]
    public async Task<Dummy> TasksAsyncDummy()
    {
        return await TaskAsyncDeepDummy.G1();
    }
}