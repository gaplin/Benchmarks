# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method               | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| ValueTasksInt        |  4.543 ns | 0.0503 ns | 0.0470 ns |  1.00 |    0.01 |         - |          NA |
| TasksInt             |  8.549 ns | 0.0480 ns | 0.0449 ns |  1.88 |    0.02 |     144 B |          NA |
| ValueTasksAsyncInt   | 18.369 ns | 0.1596 ns | 0.1493 ns |  4.04 |    0.05 |         - |          NA |
| TasksAsyncInt        | 27.283 ns | 0.1734 ns | 0.1622 ns |  6.01 |    0.07 |     360 B |          NA |
| ValueTasksDummy      |  8.646 ns | 0.0886 ns | 0.0740 ns |  1.90 |    0.02 |      96 B |          NA |
| TasksDummy           | 10.876 ns | 0.1799 ns | 0.1683 ns |  2.39 |    0.04 |     168 B |          NA |
| ValueTasksAsyncDummy | 23.602 ns | 0.0911 ns | 0.0852 ns |  5.20 |    0.06 |      96 B |          NA |
| TasksAsyncDummy      | 30.743 ns | 0.1854 ns | 0.1644 ns |  6.77 |    0.08 |     384 B |          NA |