# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method             | Iteration | Mean     | Error   | StdDev  | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------- |---------- |---------:|--------:|--------:|------:|--------:|----------:|------------:|
| TestAdderDirectly  | 1000000   | 558.7 us | 7.57 us | 7.08 us |  1.00 |    0.02 |         - |          NA |
| TestAdderInterface | 1000000   | 661.2 us | 0.54 us | 0.45 us |  1.18 |    0.01 |         - |          NA |
| TestAdderAbstract  | 1000000   | 670.9 us | 5.00 us | 4.43 us |  1.20 |    0.02 |         - |          NA |
