# Results

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)\
12th Gen Intel Core i7-12650H 2.30GHz, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.302\
  [Host]     : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX2\
  DefaultJob : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX2


| Method                        | ListSize | Mean      | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------------ |--------- |----------:|---------:|---------:|------:|--------:|----------:|------------:|
| SortWithLookupInt             | 1000     | 124.19 us | 1.374 us | 1.285 us |  1.00 |    0.01 |   7.93 KB |        1.00 |
| SortWithPropertyFillingInt    | 1000     |  35.33 us | 0.432 us | 0.404 us |  0.28 |    0.00 |   7.87 KB |        0.99 |
|                               |          |           |          |          |       |         |           |             |
| SortWithLookupString          | 1000     | 356.06 us | 6.848 us | 6.725 us |  1.00 |    0.03 |   7.93 KB |        1.00 |
| SortWithPropertyFillingString | 1000     |  47.34 us | 0.347 us | 0.290 us |  0.13 |    0.00 |   7.87 KB |        0.99 |