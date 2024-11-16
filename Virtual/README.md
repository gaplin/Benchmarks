# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 8.0 : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 9.0 : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method             | Job      | Runtime  | Iteration | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------- |--------- |--------- |---------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| TestAdderDirectly  | .NET 8.0 | .NET 8.0 | 1000000   | 662.0 us | 12.93 us | 12.10 us |  1.03 |    0.02 |         - |          NA |
| TestAdderInterface | .NET 8.0 | .NET 8.0 | 1000000   | 751.7 us | 14.42 us | 16.61 us |  1.17 |    0.03 |         - |          NA |
| TestAdderAbstract  | .NET 8.0 | .NET 8.0 | 1000000   | 753.0 us | 13.19 us | 12.34 us |  1.17 |    0.02 |         - |          NA |
| TestAdderDirectly  | .NET 9.0 | .NET 9.0 | 1000000   | 644.8 us | 10.43 us |  9.24 us |  1.00 |    0.02 |         - |          NA |
| TestAdderInterface | .NET 9.0 | .NET 9.0 | 1000000   | 747.0 us | 13.90 us | 13.00 us |  1.16 |    0.03 |         - |          NA |
| TestAdderAbstract  | .NET 9.0 | .NET 9.0 | 1000000   | 710.8 us | 14.19 us | 17.95 us |  1.10 |    0.03 |         - |          NA |
