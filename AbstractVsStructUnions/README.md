# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 8.0 : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 9.0 : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method        | Job      | Runtime  | Iterations | Mean     | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------- |--------- |--------- |----------- |---------:|----------:|----------:|------:|--------:|----------:|------------:|
| AbstractMatch | .NET 8.0 | .NET 8.0 | 1000000    | 7.932 ms | 0.1551 ms | 0.1451 ms |  0.96 |    0.02 |       6 B |        6.00 |
| StructMatch   | .NET 8.0 | .NET 8.0 | 1000000    | 6.169 ms | 0.1226 ms | 0.1594 ms |  0.75 |    0.02 |         - |        0.00 |
| AbstractMatch | .NET 9.0 | .NET 9.0 | 1000000    | 8.237 ms | 0.1289 ms | 0.1206 ms |  1.00 |    0.02 |       1 B |        1.00 |
| StructMatch   | .NET 9.0 | .NET 9.0 | 1000000    | 6.002 ms | 0.1249 ms | 0.1168 ms |  0.73 |    0.02 |       1 B |        1.00 |