# Results

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)\
12th Gen Intel Core i7-12650H 2.30GHz, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.302\
  [Host]     : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX2\
  DefaultJob : .NET 9.0.7 (9.0.725.31616), X64 RyuJIT AVX2


| Method | Mean     | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|------- |---------:|----------:|----------:|------:|--------:|----------:|------------:|
| NoLinq | 3.590 ms | 0.0362 ms | 0.0321 ms |  1.00 |    0.01 |         - |          NA |
| Linq   | 9.911 ms | 0.1929 ms | 0.2369 ms |  2.76 |    0.07 |     624 B |          NA |