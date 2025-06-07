# Results

BenchmarkDotNet v0.15.0, Windows 11 (10.0.26100.4061/24H2/2024Update/HudsonValley)\
12th Gen Intel Core i7-12650H 2.30GHz, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.300\
  [Host]     : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2\
  DefaultJob : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2


| Method               | NumberOfItems | Mean          | Error        | StdDev       | Median        | Ratio | RatioSD | Allocated    | Alloc Ratio |
|--------------------- |-------------- |--------------:|-------------:|-------------:|--------------:|------:|--------:|-------------:|------------:|
| AtTheTopWebDefault   | 1000          |      57.94 us |     1.145 us |     1.568 us |      57.82 us |  1.00 |    0.04 |    131.59 KB |        1.00 |
| AtTheBottomWebCustom | 1000          |      75.79 us |     1.244 us |     1.039 us |      76.20 us |  1.31 |    0.04 |    131.59 KB |        1.00 |
| AtTheTopWebCustom    | 1000          |      77.93 us |     1.532 us |     3.299 us |      76.11 us |  1.35 |    0.07 |    131.59 KB |        1.00 |
|                      |               |               |              |              |               |       |         |              |             |
| AtTheTopWebDefault   | 1000000       | 169,096.85 us | 3,240.272 us | 4,097.907 us | 168,003.25 us |  1.00 |    0.03 | 111958.66 KB |        1.00 |
| AtTheBottomWebCustom | 1000000       | 187,745.70 us | 3,652.531 us | 3,416.580 us | 187,723.93 us |  1.11 |    0.03 | 111958.41 KB |        1.00 |
| AtTheTopWebCustom    | 1000000       | 189,075.50 us | 3,756.131 us | 4,750.303 us | 190,037.70 us |  1.12 |    0.04 | 111958.51 KB |        1.00 |