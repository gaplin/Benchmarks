# Results

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)\
12th Gen Intel Core i7-12650H 2.30GHz, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.302\
  [Host]     : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX2\
  DefaultJob : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX2\

[MethodImpl(MethodImplOptions.NoInlining)]
| Method       | Iterations | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------- |----------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| Interface    | 100        |    176.6 ns |   2.17 ns |   1.93 ns |  1.00 |    0.01 |         - |          NA |
| DirectObject | 100        |    107.3 ns |   0.79 ns |   0.66 ns |  0.61 |    0.01 |         - |          NA |
| Delegate     | 100        |    237.7 ns |   4.61 ns |   5.12 ns |  1.35 |    0.03 |         - |          NA |
|              |            |             |           |           |       |         |           |             |
| Interface    | 10000      | 17,791.7 ns | 351.63 ns | 469.41 ns |  1.00 |    0.04 |         - |          NA |
| DirectObject | 10000      | 10,725.5 ns | 211.16 ns | 364.23 ns |  0.60 |    0.03 |         - |          NA |
| Delegate     | 10000      | 23,120.3 ns | 407.57 ns | 381.24 ns |  1.30 |    0.04 |         - |          NA |


[Default]
| Method       | Iterations | Mean         | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------- |----------- |-------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| Interface    | 100        |     59.89 ns |   1.169 ns |   0.912 ns |  1.00 |    0.02 |         - |          NA |
| DirectObject | 100        |     58.55 ns |   1.213 ns |   1.534 ns |  0.98 |    0.03 |         - |          NA |
| Delegate     | 100        |    232.14 ns |   4.420 ns |   4.729 ns |  3.88 |    0.10 |         - |          NA |
|              |            |              |            |            |       |         |           |             |
| Interface    | 10000      |  6,087.92 ns | 121.083 ns | 134.583 ns |  1.00 |    0.03 |         - |          NA |
| DirectObject | 10000      |  5,418.43 ns | 105.899 ns | 173.994 ns |  0.89 |    0.03 |         - |          NA |
| Delegate     | 10000      | 23,199.74 ns | 383.928 ns | 340.342 ns |  3.81 |    0.10 |         - |          NA |
