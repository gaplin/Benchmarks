# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method                        | ListSize | Mean      | Error    | StdDev   | Ratio | Allocated | Alloc Ratio |
|------------------------------ |--------- |----------:|---------:|---------:|------:|----------:|------------:|
| SortWithLookupInt             | 1000     |  70.34 us | 0.742 us | 0.694 us |  1.00 |   7.93 KB |        1.00 |
| SortWithPropertyFillingInt    | 1000     |  27.41 us | 0.541 us | 0.873 us |  0.39 |   7.87 KB |        0.99 |
|                               |          |           |          |          |       |           |             |
| SortWithLookupString          | 1000     | 177.58 us | 1.262 us | 1.181 us |  1.00 |   7.93 KB |        1.00 |
| SortWithPropertyFillingString | 1000     |  31.97 us | 0.633 us | 1.263 us |  0.18 |   7.87 KB |        0.99 |