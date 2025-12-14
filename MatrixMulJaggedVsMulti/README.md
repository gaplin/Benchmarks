# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method                | N    | Mean       | Error    | StdDev   | Ratio |
|---------------------- |----- |-----------:|---------:|---------:|------:|
| JaggedArraysNormal    | 1000 | 1,761.2 ms | 14.02 ms | 13.11 ms |  1.00 |
| JaggedArraysChanged   | 1000 | 1,521.8 ms | 10.54 ms |  9.86 ms |  0.86 |
| MultiDimArraysNormal  | 1000 | 1,370.2 ms | 10.34 ms |  9.67 ms |  0.78 |
| MultiDimArraysChanged | 1000 | 1,019.7 ms |  2.63 ms |  2.19 ms |  0.58 |
| FlatArrayNormal       | 1000 | 1,100.8 ms |  4.92 ms |  4.10 ms |  0.63 |
| FlatArrayChanged      | 1000 |   969.7 ms |  1.58 ms |  1.32 ms |  0.55 |