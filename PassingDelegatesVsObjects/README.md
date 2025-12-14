# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4

| Method       | Iterations | Mean         | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------- |----------- |-------------:|----------:|----------:|------:|--------:|----------:|------------:|
| Interface    | 100        |     43.60 ns |  0.441 ns |  0.413 ns |  1.00 |    0.01 |         - |          NA |
| DirectObject | 100        |     40.66 ns |  0.231 ns |  0.216 ns |  0.93 |    0.01 |         - |          NA |
| Delegate     | 100        |    154.66 ns |  1.061 ns |  0.993 ns |  3.55 |    0.04 |         - |          NA |
|              |            |              |           |           |       |         |           |             |
| Interface    | 10000      |  4,154.40 ns | 30.351 ns | 25.344 ns |  1.00 |    0.01 |         - |          NA |
| DirectObject | 10000      |  4,007.68 ns | 24.802 ns | 23.199 ns |  0.96 |    0.01 |         - |          NA |
| Delegate     | 10000      | 13,510.45 ns |  2.004 ns |  1.565 ns |  3.25 |    0.02 |         - |          NA |
