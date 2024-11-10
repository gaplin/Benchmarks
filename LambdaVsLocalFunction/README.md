# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100-rc.2.24474.11\
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


| Method        | Mean     | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------- |---------:|----------:|----------:|------:|--------:|----------:|------------:|
| Lambda        | 3.929 ms | 0.0416 ms | 0.0389 ms |  1.00 |    0.01 |     579 B |        1.00 |
| LocalFunction | 4.560 ms | 0.0587 ms | 0.0521 ms |  1.16 |    0.02 |     579 B |        1.00 |