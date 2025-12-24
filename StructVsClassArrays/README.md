# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method             | ArrSize | Mean         | Error       | StdDev      | Ratio | Allocated | Alloc Ratio |
|------------------- |-------- |-------------:|------------:|------------:|------:|----------:|------------:|
| TestClass          | 1000    |     643.0 ns |     5.24 ns |     4.64 ns |  1.00 |         - |          NA |
| TestStruct         | 1000    |     645.8 ns |     8.34 ns |     7.80 ns |  1.00 |         - |          NA |
| TestStructOfArrays | 1000    |     719.1 ns |     4.55 ns |     4.03 ns |  1.12 |         - |          NA |
|                    |         |              |             |             |       |           |             |
| TestClass          | 1000000 | 882,346.9 ns | 6,850.75 ns | 5,720.69 ns |  1.00 |         - |          NA |
| TestStruct         | 1000000 | 676,211.6 ns | 1,340.46 ns | 1,046.54 ns |  0.77 |         - |          NA |
| TestStructOfArrays | 1000000 | 743,414.4 ns | 5,591.43 ns | 5,230.22 ns |  0.84 |         - |          NA |