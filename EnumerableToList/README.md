# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 8.0 : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 9.0 : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method         | Job      | Runtime  | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------- |--------- |--------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| JustEnumerable | .NET 8.0 | .NET 8.0 | 1,724.5 us | 28.15 us | 26.33 us |  1.83 |    0.04 |      4 MB |        2.10 |
| DoubleToList   | .NET 8.0 | .NET 8.0 | 2,933.7 us | 32.98 us | 30.85 us |  3.12 |    0.05 |   5.91 MB |        3.10 |
| JustEnumerable | .NET 9.0 | .NET 9.0 |   941.1 us | 12.78 us | 11.95 us |  1.00 |    0.02 |   1.91 MB |        1.00 |
| DoubleToList   | .NET 9.0 | .NET 9.0 | 1,561.7 us | 29.81 us | 31.89 us |  1.66 |    0.04 |   3.82 MB |        2.00 |