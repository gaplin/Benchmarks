# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 8.0 : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 9.0 : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method        | Job      | Runtime  | Mean     | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------- |--------- |--------- |---------:|----------:|----------:|------:|--------:|----------:|------------:|
| Lambda        | .NET 8.0 | .NET 8.0 | 6.676 ms | 0.1305 ms | 0.1450 ms |  1.65 |    0.06 |     579 B |        1.00 |
| LocalFunction | .NET 8.0 | .NET 8.0 | 4.576 ms | 0.0898 ms | 0.1642 ms |  1.13 |    0.05 |     579 B |        1.00 |
| Lambda        | .NET 9.0 | .NET 9.0 | 4.051 ms | 0.0798 ms | 0.1093 ms |  1.00 |    0.04 |     579 B |        1.00 |
| LocalFunction | .NET 9.0 | .NET 9.0 | 4.746 ms | 0.0936 ms | 0.0875 ms |  1.17 |    0.04 |     577 B |        1.00 |