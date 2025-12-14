# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method | Mean     | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|------- |---------:|----------:|----------:|------:|--------:|----------:|------------:|
| NoLinq | 2.306 ms | 0.0022 ms | 0.0019 ms |  1.00 |    0.00 |         - |          NA |
| Linq   | 6.832 ms | 0.1218 ms | 0.1196 ms |  2.96 |    0.05 |     624 B |          NA |