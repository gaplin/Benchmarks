# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method     | ArrSize | Mean         | Error       | StdDev      | Ratio | Allocated | Alloc Ratio |
|----------- |-------- |-------------:|------------:|------------:|------:|----------:|------------:|
| TestClass  | 1000    |     425.1 ns |     3.19 ns |     2.98 ns |  1.00 |         - |          NA |
| TestStruct | 1000    |     399.5 ns |     0.39 ns |     0.35 ns |  0.94 |         - |          NA |
|            |         |              |             |             |       |           |             |
| TestClass  | 1000000 | 591,601.2 ns | 1,430.63 ns | 1,268.21 ns |  1.00 |         - |          NA |
| TestStruct | 1000000 | 413,740.3 ns | 1,651.29 ns | 1,544.62 ns |  0.70 |         - |          NA |