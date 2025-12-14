# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method           | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| WhereLinq        | 746.3 us | 12.24 us | 11.45 us |  1.00 |    0.02 |      48 B |        1.00 |
| WhereZlinq       | 462.3 us |  2.95 us |  2.76 us |  0.62 |    0.01 |         - |        0.00 |
|                  |          |          |          |       |         |           |             |
| WhereToListLinq  | 641.3 us |  5.01 us |  4.69 us |  1.00 |    0.01 | 2000265 B |        1.00 |
| WhereToListZlinq | 734.9 us |  3.19 us |  2.98 us |  1.15 |    0.01 | 2000216 B |        1.00 |