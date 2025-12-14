# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method                     | MaxElement | Mean     | Error   | StdDev  | Ratio | Allocated | Alloc Ratio |
|--------------------------- |----------- |---------:|--------:|--------:|------:|----------:|------------:|
| EnumerableToListIteration  | 1000000    | 995.8 us | 9.54 us | 8.92 us |  1.00 |   3.81 MB |        1.00 |
| EnumerableToArrayIteration | 1000000    | 952.5 us | 5.37 us | 4.48 us |  0.96 |   3.81 MB |        1.00 |
|                            |            |          |         |         |       |           |             |
| ListToListIteration        | 1000000    | 957.6 us | 1.84 us | 1.54 us |  1.00 |   3.81 MB |        1.00 |
| ListToArrayIteration       | 1000000    | 958.4 us | 2.00 us | 1.87 us |  1.00 |   3.81 MB |        1.00 |