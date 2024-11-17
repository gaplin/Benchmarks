# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2\
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method                     | MaxElement | Mean     | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------------------- |----------- |---------:|----------:|----------:|------:|--------:|----------:|------------:|
| EnumerableToListIteration  | 1000000    | 1.556 ms | 0.0215 ms | 0.0201 ms |  1.00 |    0.02 |   3.81 MB |        1.00 |
| EnumerableToArrayIteration | 1000000    | 1.398 ms | 0.0237 ms | 0.0221 ms |  0.90 |    0.02 |   3.81 MB |        1.00 |
|                            |            |          |           |           |       |         |           |             |
| ListToListIteration        | 1000000    | 1.488 ms | 0.0294 ms | 0.0314 ms |  1.00 |    0.03 |   3.81 MB |        1.00 |
| ListToArrayIteration       | 1000000    | 1.386 ms | 0.0259 ms | 0.0254 ms |  0.93 |    0.03 |   3.81 MB |        1.00 |