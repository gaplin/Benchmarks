# Results
## Benchmarks

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 8.0 : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 9.0 : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method         | Job      | Runtime  | MaxElem | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------- |--------- |--------- |-------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| Find           | .NET 8.0 | .NET 8.0 | 1000000 | 308.3 us |  3.56 us |  2.97 us |  1.00 |    0.01 |      64 B |        1.00 |
| FirstOrDefault | .NET 8.0 | .NET 8.0 | 1000000 | 547.6 us | 10.83 us | 12.04 us |  1.78 |    0.04 |     104 B |        1.62 |
| FindDirectly   | .NET 8.0 | .NET 8.0 | 1000000 | 124.2 us |  2.44 us |  2.71 us |  0.40 |    0.01 |         - |        0.00 |
| Find           | .NET 9.0 | .NET 9.0 | 1000000 | 249.5 us |  4.66 us |  4.13 us |  0.81 |    0.01 |      64 B |        1.00 |
| FirstOrDefault | .NET 9.0 | .NET 9.0 | 1000000 | 137.2 us |  2.50 us |  2.78 us |  0.45 |    0.01 |      64 B |        1.00 |
| FindDirectly   | .NET 9.0 | .NET 9.0 | 1000000 | 122.3 us |  1.87 us |  1.75 us |  0.40 |    0.01 |         - |        0.00 |

## BenchmarksConst

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 9.0 : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=.NET 9.0  Runtime=.NET 9.0

| Method                  | MaxElem | Mean     | Error   | StdDev  | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------ |-------- |---------:|--------:|--------:|------:|--------:|----------:|------------:|
| FindWithoutElseConst    | 1000000 | 185.1 us | 2.64 us | 2.47 us |  1.00 |    0.02 |         - |          NA |
| FindWithElseConst       | 1000000 | 121.7 us | 1.76 us | 1.65 us |  0.66 |    0.01 |         - |          NA |
| FindWithoutElseVariable | 1000000 | 138.4 us | 1.94 us | 1.72 us |  0.75 |    0.01 |      64 B |          NA |
| FindWithElseVariable    | 1000000 | 135.7 us | 2.66 us | 2.73 us |  0.73 |    0.02 |      64 B |          NA |