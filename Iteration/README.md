# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 8.0 : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 9.0 : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method                 | Job      | Runtime  | StrLength | Mean          | Error        | StdDev       | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------- |--------- |--------- |---------- |--------------:|-------------:|-------------:|------:|--------:|----------:|------------:|
| ForeachString          | .NET 8.0 | .NET 8.0 | 100       |      43.90 ns |     0.441 ns |     0.413 ns |  1.13 |    0.02 |         - |          NA |
| ForString              | .NET 8.0 | .NET 8.0 | 100       |      43.83 ns |     0.622 ns |     0.582 ns |  1.13 |    0.02 |         - |          NA |
| ForStringLengthOutside | .NET 8.0 | .NET 8.0 | 100       |      43.74 ns |     0.283 ns |     0.236 ns |  1.12 |    0.02 |         - |          NA |
| ForeachSpan            | .NET 8.0 | .NET 8.0 | 100       |      38.38 ns |     0.449 ns |     0.420 ns |  0.99 |    0.02 |         - |          NA |
| ForSpan                | .NET 8.0 | .NET 8.0 | 100       |      49.59 ns |     0.603 ns |     0.564 ns |  1.27 |    0.02 |         - |          NA |
| ForSpanLengthOutside   | .NET 8.0 | .NET 8.0 | 100       |      49.51 ns |     0.785 ns |     0.735 ns |  1.27 |    0.02 |         - |          NA |
| ForeachString          | .NET 9.0 | .NET 9.0 | 100       |      38.94 ns |     0.673 ns |     0.525 ns |  1.00 |    0.02 |         - |          NA |
| ForString              | .NET 9.0 | .NET 9.0 | 100       |      39.04 ns |     0.487 ns |     1.059 ns |  1.00 |    0.03 |         - |          NA |
| ForStringLengthOutside | .NET 9.0 | .NET 9.0 | 100       |      38.72 ns |     0.397 ns |     0.372 ns |  0.99 |    0.02 |         - |          NA |
| ForeachSpan            | .NET 9.0 | .NET 9.0 | 100       |      39.12 ns |     0.558 ns |     0.466 ns |  1.00 |    0.02 |         - |          NA |
| ForSpan                | .NET 9.0 | .NET 9.0 | 100       |      41.96 ns |     0.563 ns |     0.526 ns |  1.08 |    0.02 |         - |          NA |
| ForSpanLengthOutside   | .NET 9.0 | .NET 9.0 | 100       |      41.91 ns |     0.298 ns |     0.233 ns |  1.08 |    0.02 |         - |          NA |
|                        |          |          |           |               |              |              |       |         |           |             |
| ForeachString          | .NET 8.0 | .NET 8.0 | 1000000   | 305,103.34 ns | 5,941.255 ns | 5,266.768 ns |  1.26 |    0.03 |         - |          NA |
| ForString              | .NET 8.0 | .NET 8.0 | 1000000   | 304,479.51 ns | 3,596.413 ns | 3,003.167 ns |  1.26 |    0.02 |         - |          NA |
| ForStringLengthOutside | .NET 8.0 | .NET 8.0 | 1000000   | 303,303.70 ns | 2,704.899 ns | 2,397.823 ns |  1.25 |    0.02 |         - |          NA |
| ForeachSpan            | .NET 8.0 | .NET 8.0 | 1000000   | 392,845.16 ns | 7,607.697 ns | 8,455.935 ns |  1.62 |    0.04 |         - |          NA |
| ForSpan                | .NET 8.0 | .NET 8.0 | 1000000   | 389,910.82 ns | 3,656.798 ns | 3,053.592 ns |  1.61 |    0.02 |         - |          NA |
| ForSpanLengthOutside   | .NET 8.0 | .NET 8.0 | 1000000   | 396,256.96 ns | 7,888.024 ns | 8,767.517 ns |  1.64 |    0.04 |         - |          NA |
| ForeachString          | .NET 9.0 | .NET 9.0 | 1000000   | 241,832.66 ns | 3,467.804 ns | 3,243.786 ns |  1.00 |    0.02 |         - |          NA |
| ForString              | .NET 9.0 | .NET 9.0 | 1000000   | 240,464.98 ns | 1,968.952 ns | 1,745.425 ns |  0.99 |    0.01 |         - |          NA |
| ForStringLengthOutside | .NET 9.0 | .NET 9.0 | 1000000   | 240,567.65 ns | 3,415.975 ns | 3,028.173 ns |  0.99 |    0.02 |         - |          NA |
| ForeachSpan            | .NET 9.0 | .NET 9.0 | 1000000   | 244,158.35 ns | 3,401.868 ns | 3,182.110 ns |  1.01 |    0.02 |         - |          NA |
| ForSpan                | .NET 9.0 | .NET 9.0 | 1000000   | 246,501.62 ns | 4,898.165 ns | 4,810.653 ns |  1.02 |    0.02 |         - |          NA |
| ForSpanLengthOutside   | .NET 9.0 | .NET 9.0 | 1000000   | 246,250.83 ns | 4,174.587 ns | 3,904.911 ns |  1.02 |    0.02 |         - |          NA |