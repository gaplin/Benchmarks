# Results

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)\
12th Gen Intel Core i7-12650H 2.30GHz, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.302\
  [Host]     : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX2\
  DefaultJob : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX2


| Method        | ObjectCount | Mean         | Error       | StdDev       | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------- |------------ |-------------:|------------:|-------------:|------:|--------:|----------:|------------:|
| Polymorphism  | 100         |     166.6 ns |     2.13 ns |      1.99 ns |  1.00 |    0.02 |         - |          NA |
| Dynamic       | 100         |   1,887.0 ns |    35.89 ns |     38.40 ns | 11.33 |    0.26 |    4800 B |          NA |
| Switch        | 100         |     258.9 ns |     5.10 ns |      6.63 ns |  1.55 |    0.04 |         - |          NA |
| NoInheritance | 100         |     218.6 ns |     4.39 ns |      5.71 ns |  1.31 |    0.04 |         - |          NA |
|               |             |              |             |              |       |         |           |             |
| Polymorphism  | 10000       |  58,003.1 ns | 1,063.43 ns |    888.01 ns |  1.00 |    0.02 |         - |          NA |
| Dynamic       | 10000       | 245,832.6 ns | 4,853.26 ns | 10,653.03 ns |  4.24 |    0.19 |  480000 B |          NA |
| Switch        | 10000       |  68,314.0 ns | 1,353.73 ns |  3,269.42 ns |  1.18 |    0.06 |         - |          NA |
| NoInheritance | 10000       |  66,214.2 ns | 1,319.36 ns |  2,840.06 ns |  1.14 |    0.05 |         - |          NA |