# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method         | Mean     | Error   | StdDev  | Ratio | Allocated | Alloc Ratio |
|--------------- |---------:|--------:|--------:|------:|----------:|------------:|
| JustEnumerable | 752.0 us | 5.40 us | 5.05 us |  1.00 |   1.91 MB |        1.00 |
| DoubleToList   | 934.2 us | 2.52 us | 2.24 us |  1.24 |   3.82 MB |        2.00 |