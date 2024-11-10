# Results
## Benchmarks

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100-rc.2.24474.11\
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  .NET 8.0 : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  .NET 9.0 : .NET 9.0.0 (9.0.24.47305), X64 RyuJIT AVX2


| Method         | Job      | Runtime  | MaxElem | Mean         | Error       | StdDev       | Median       | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------- |--------- |--------- |-------- |-------------:|------------:|-------------:|-------------:|------:|--------:|----------:|------------:|
| Find           | .NET 8.0 | .NET 8.0 | 1000    |     300.3 ns |     5.28 ns |      4.68 ns |     299.9 ns |  1.00 |    0.02 |      64 B |        1.00 |
| FirstOrDefault | .NET 8.0 | .NET 8.0 | 1000    |     544.3 ns |     7.99 ns |      7.08 ns |     544.8 ns |  1.81 |    0.04 |     104 B |        1.62 |
| Find           | .NET 9.0 | .NET 9.0 | 1000    |     250.6 ns |     0.99 ns |      0.93 ns |     250.6 ns |  0.83 |    0.01 |      64 B |        1.00 |
| FirstOrDefault | .NET 9.0 | .NET 9.0 | 1000    |     137.8 ns |     0.80 ns |      0.75 ns |     137.8 ns |  0.46 |    0.01 |      64 B |        1.00 |
|                |          |          |         |              |             |              |              |       |         |           |             |
| Find           | .NET 8.0 | .NET 8.0 | 1000000 | 292,587.6 ns | 4,785.23 ns |  4,476.10 ns | 291,977.9 ns |  1.00 |    0.02 |      64 B |        1.00 |
| FirstOrDefault | .NET 8.0 | .NET 8.0 | 1000000 | 527,426.1 ns | 6,527.59 ns |  6,105.91 ns | 526,715.9 ns |  1.80 |    0.03 |     104 B |        1.62 |
| Find           | .NET 9.0 | .NET 9.0 | 1000000 | 244,642.0 ns | 4,298.42 ns |  3,810.44 ns | 243,109.9 ns |  0.84 |    0.02 |      64 B |        1.00 |
| FirstOrDefault | .NET 9.0 | .NET 9.0 | 1000000 | 143,791.6 ns | 4,949.63 ns | 14,516.42 ns | 139,707.5 ns |  0.49 |    0.05 |      64 B |        1.00 |

## BenchmarksConst

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100-rc.2.24474.11\
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  .NET 9.0 : .NET 9.0.0 (9.0.24.47305), X64 RyuJIT AVX2

Job=.NET 9.0  Runtime=.NET 9.0

| Method                  | MaxElem | Mean     | Error   | StdDev  | Ratio | Allocated | Alloc Ratio |
|------------------------ |-------- |---------:|--------:|--------:|------:|----------:|------------:|
| FindWithoutElseConst    | 1000    | 189.1 ns | 1.20 ns | 1.48 ns |  1.00 |         - |          NA |
| FindWithElseConst       | 1000    | 130.4 ns | 0.60 ns | 0.56 ns |  0.69 |         - |          NA |
| FindWithoutElseVariable | 1000    | 137.8 ns | 0.60 ns | 0.53 ns |  0.73 |      64 B |          NA |
| FindWithElseVariable    | 1000    | 137.7 ns | 0.27 ns | 0.25 ns |  0.73 |      64 B |          NA |