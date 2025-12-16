# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method          | Count   | Mean          | Error       | StdDev      | Ratio | RatioSD | Allocated | Alloc Ratio |
|---------------- |-------- |--------------:|------------:|------------:|------:|--------:|----------:|------------:|
| Visitor10       | 1000    |      8.203 us |   0.0456 us |   0.0426 us |  1.00 |    0.01 |      32 B |        1.00 |
| PatternSwitch10 | 1000    |      7.739 us |   0.0426 us |   0.0398 us |  0.94 |    0.01 |      32 B |        1.00 |
|                 |         |               |             |             |       |         |           |             |
| Visitor10       | 1000000 | 23,008.396 us | 154.1032 us | 136.6085 us |  1.00 |    0.01 |      32 B |        1.00 |
| PatternSwitch10 | 1000000 | 25,761.966 us | 466.0375 us | 435.9318 us |  1.12 |    0.02 |      32 B |        1.00 |
|                 |         |               |             |             |       |         |           |             |
| Visitor4        | 1000    |      9.399 us |   0.0460 us |   0.0407 us |  1.00 |    0.01 |      32 B |        1.00 |
| PatternSwitch4  | 1000    |      4.080 us |   0.0379 us |   0.0354 us |  0.43 |    0.00 |         - |        0.00 |
|                 |         |               |             |             |       |         |           |             |
| Visitor4        | 1000000 | 26,295.041 us | 251.0095 us | 209.6043 us |  1.00 |    0.01 |      32 B |        1.00 |
| PatternSwitch4  | 1000000 | 24,609.845 us | 416.8102 us | 369.4914 us |  0.94 |    0.02 |         - |        0.00 |