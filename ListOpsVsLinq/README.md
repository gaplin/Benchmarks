# Results
## Benchmarks

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]    : .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v4\
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  .NET 8.0  : .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v4


| Method         | Job       | Runtime   | MaxElem | Mean     | Error   | StdDev  | Median   | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------- |---------- |---------- |-------- |---------:|--------:|--------:|---------:|------:|--------:|----------:|------------:|
| Find           | .NET 10.0 | .NET 10.0 | 1000000 | 197.5 us | 1.43 us | 1.34 us | 197.4 us |  1.00 |    0.01 |         - |          NA |
| FirstOrDefault | .NET 10.0 | .NET 10.0 | 1000000 | 191.4 us | 0.88 us | 0.78 us | 191.2 us |  0.97 |    0.01 |         - |          NA |
| FindDirectly   | .NET 10.0 | .NET 10.0 | 1000000 | 102.2 us | 0.61 us | 0.57 us | 102.0 us |  0.52 |    0.00 |         - |          NA |
| Find           | .NET 8.0  | .NET 8.0  | 1000000 | 293.9 us | 1.30 us | 1.21 us | 292.9 us |  1.49 |    0.01 |      64 B |          NA |
| FirstOrDefault | .NET 8.0  | .NET 8.0  | 1000000 | 548.9 us | 2.83 us | 2.36 us | 550.3 us |  2.78 |    0.02 |     104 B |          NA |
| FindDirectly   | .NET 8.0  | .NET 8.0  | 1000000 | 101.1 us | 0.40 us | 0.38 us | 101.0 us |  0.51 |    0.00 |         - |          NA |

## BenchmarksConst

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]    : .NET 8.0.22 (8.0.22, 8.0.2225.52707), X64 RyuJIT x86-64-v4\
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  .NET 9.0  : .NET 9.0.11 (9.0.11, 9.0.1125.51716), X64 RyuJIT x86-64-v4


| Method                  | Job       | Runtime   | MaxElem | Mean      | Error    | StdDev   | Ratio | Allocated | Alloc Ratio |
|------------------------ |---------- |---------- |-------- |----------:|---------:|---------:|------:|----------:|------------:|
| FindWithoutElseConst    | .NET 10.0 | .NET 10.0 | 1000000 |  97.92 us | 0.151 us | 0.134 us |  1.00 |         - |          NA |
| FindWithElseConst       | .NET 10.0 | .NET 10.0 | 1000000 |  95.23 us | 0.111 us | 0.093 us |  0.97 |         - |          NA |
| FindWithoutElseVariable | .NET 10.0 | .NET 10.0 | 1000000 | 101.45 us | 0.325 us | 0.288 us |  1.04 |         - |          NA |
| FindWithElseVariable    | .NET 10.0 | .NET 10.0 | 1000000 | 101.95 us | 0.739 us | 0.692 us |  1.04 |         - |          NA |
|                         |           |           |         |           |          |          |       |           |             |
| FindWithoutElseConst    | .NET 9.0  | .NET 9.0  | 1000000 | 145.31 us | 0.119 us | 0.105 us |  1.00 |         - |          NA |
| FindWithElseConst       | .NET 9.0  | .NET 9.0  | 1000000 |  95.69 us | 0.743 us | 0.695 us |  0.66 |         - |          NA |
| FindWithoutElseVariable | .NET 9.0  | .NET 9.0  | 1000000 | 107.08 us | 0.269 us | 0.210 us |  0.74 |      64 B |          NA |
| FindWithElseVariable    | .NET 9.0  | .NET 9.0  | 1000000 | 107.57 us | 0.573 us | 0.536 us |  0.74 |      64 B |          NA |