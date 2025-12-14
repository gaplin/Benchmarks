# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method         | Iterations | Mean         | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------- |----------- |-------------:|----------:|----------:|------:|--------:|----------:|------------:|
| AutoProp       | 100000     |     39.53 us |  0.437 us |  0.387 us |  1.00 |    0.01 |         - |          NA |
| NoInliningProp | 100000     |    175.32 us |  0.112 us |  0.093 us |  4.44 |    0.04 |         - |          NA |
| Field          | 100000     |     32.98 us |  0.380 us |  0.337 us |  0.83 |    0.01 |         - |          NA |
|                |            |              |           |           |       |         |           |             |
| AutoProp       | 10000000   |  3,904.90 us | 17.854 us | 14.909 us |  1.00 |    0.01 |         - |          NA |
| NoInliningProp | 10000000   | 17,488.91 us | 53.803 us | 47.695 us |  4.48 |    0.02 |         - |          NA |
| Field          | 10000000   |  3,295.33 us | 24.416 us | 22.839 us |  0.84 |    0.01 |         - |          NA |