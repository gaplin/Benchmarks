# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100-rc.2.24474.11\
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


| Method             | Iteration | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------- |---------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| TestAdderDirectly  | 1000000   | 633.0 us |  9.52 us | 14.25 us |  1.00 |    0.03 |         - |          NA |
| TestAdderInterface | 1000000   | 742.2 us |  7.58 us |  6.33 us |  1.17 |    0.03 |         - |          NA |
| TestAdderAbstract  | 1000000   | 749.1 us | 10.72 us | 10.02 us |  1.18 |    0.03 |         - |          NA |
