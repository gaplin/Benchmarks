# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method        | Mean     | Error     | StdDev    | Ratio | Allocated | Alloc Ratio |
|-------------- |---------:|----------:|----------:|------:|----------:|------------:|
| Lambda        | 4.091 ms | 0.0375 ms | 0.0351 ms |  1.00 |     576 B |        1.00 |
| LocalFunction | 4.013 ms | 0.0286 ms | 0.0239 ms |  0.98 |     576 B |        1.00 |