# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100-rc.2.24474.11\
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


| Method         | Mean     | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------- |---------:|----------:|----------:|------:|--------:|----------:|------------:|
| JustEnumerable | 1.810 ms | 0.0284 ms | 0.0265 ms |  1.00 |    0.02 |      4 MB |        1.00 |
| DoubleToList   | 2.996 ms | 0.0323 ms | 0.0302 ms |  1.66 |    0.03 |   5.91 MB |        1.48 |