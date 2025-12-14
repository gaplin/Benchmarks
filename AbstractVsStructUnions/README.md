# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method        | Iterations | Mean     | Error     | StdDev    | Ratio | Allocated | Alloc Ratio |
|-------------- |----------- |---------:|----------:|----------:|------:|----------:|------------:|
| AbstractMatch | 1000000    | 6.342 ms | 0.0603 ms | 0.0564 ms |  1.00 |         - |          NA |
| StructMatch   | 1000000    | 5.394 ms | 0.0501 ms | 0.0468 ms |  0.85 |         - |          NA |