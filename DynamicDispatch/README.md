# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method        | ObjectCount | Mean         | Error       | StdDev      | Median       | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------- |------------ |-------------:|------------:|------------:|-------------:|------:|--------:|----------:|------------:|
| Polymorphism  | 100         |     125.0 ns |     2.01 ns |     2.06 ns |     124.5 ns |  1.00 |    0.02 |         - |          NA |
| Dynamic       | 100         |   1,500.2 ns |    29.76 ns |    54.42 ns |   1,490.9 ns | 12.01 |    0.47 |    4800 B |          NA |
| Switch        | 100         |     147.2 ns |     1.84 ns |     1.63 ns |     146.2 ns |  1.18 |    0.02 |         - |          NA |
| NoInheritance | 100         |     440.9 ns |     5.01 ns |     4.68 ns |     441.1 ns |  3.53 |    0.07 |         - |          NA |
|               |             |              |             |             |              |       |         |           |             |
| Polymorphism  | 10000       |  26,032.3 ns |   504.51 ns |   600.59 ns |  26,069.6 ns |  1.00 |    0.03 |         - |          NA |
| Dynamic       | 10000       | 187,789.9 ns | 2,732.24 ns | 2,281.55 ns | 187,567.0 ns |  7.22 |    0.18 |  480000 B |          NA |
| Switch        | 10000       |  20,637.1 ns |   403.95 ns |   525.24 ns |  20,963.1 ns |  0.79 |    0.03 |         - |          NA |
| NoInheritance | 10000       |  52,983.6 ns |   705.50 ns |   659.93 ns |  53,062.5 ns |  2.04 |    0.05 |         - |          NA |