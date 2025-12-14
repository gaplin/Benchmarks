# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method                 | StrLength | Mean          | Error        | StdDev       | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------- |---------- |--------------:|-------------:|-------------:|------:|--------:|----------:|------------:|
| ForeachString          | 100       |      38.96 ns |     0.032 ns |     0.030 ns |  1.00 |    0.00 |         - |          NA |
| ForString              | 100       |      38.53 ns |     0.314 ns |     0.294 ns |  0.99 |    0.01 |         - |          NA |
| ForStringLengthOutside | 100       |      38.69 ns |     0.338 ns |     0.316 ns |  0.99 |    0.01 |         - |          NA |
| ForeachSpan            | 100       |      20.42 ns |     0.133 ns |     0.111 ns |  0.52 |    0.00 |         - |          NA |
| ForSpan                | 100       |      20.50 ns |     0.181 ns |     0.169 ns |  0.53 |    0.00 |         - |          NA |
| ForSpanLengthOutside   | 100       |      20.33 ns |     0.190 ns |     0.168 ns |  0.52 |    0.00 |         - |          NA |
|                        |           |               |              |              |       |         |           |             |
| ForeachString          | 1000000   | 189,685.33 ns | 1,184.355 ns |   924.667 ns |  1.00 |    0.01 |         - |          NA |
| ForString              | 1000000   | 379,230.51 ns | 2,727.782 ns | 2,551.569 ns |  2.00 |    0.02 |         - |          NA |
| ForStringLengthOutside | 1000000   | 188,292.12 ns |   996.953 ns |   883.773 ns |  0.99 |    0.01 |         - |          NA |
| ForeachSpan            | 1000000   | 189,746.32 ns | 1,604.870 ns | 1,501.197 ns |  1.00 |    0.01 |         - |          NA |
| ForSpan                | 1000000   | 188,856.82 ns | 1,439.644 ns | 1,346.644 ns |  1.00 |    0.01 |         - |          NA |
| ForSpanLengthOutside   | 1000000   | 189,317.97 ns | 1,709.003 ns | 1,598.602 ns |  1.00 |    0.01 |         - |          NA |