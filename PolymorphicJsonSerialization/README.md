# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores0\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method               | NumberOfItems | Mean          | Error        | StdDev       | Ratio | RatioSD | Allocated    | Alloc Ratio |
|--------------------- |-------------- |--------------:|-------------:|-------------:|------:|--------:|-------------:|------------:|
| AtTheTopWebDefault   | 1000          |      45.71 us |     0.686 us |     0.642 us |  1.00 |    0.02 |    131.59 KB |        1.00 |
| AtTheBottomWebCustom | 1000          |      61.33 us |     0.372 us |     0.348 us |  1.34 |    0.02 |    131.59 KB |        1.00 |
| AtTheTopWebCustom    | 1000          |      61.71 us |     0.442 us |     0.369 us |  1.35 |    0.02 |    131.59 KB |        1.00 |
|                      |               |               |              |              |       |         |              |             |
| AtTheTopWebDefault   | 1000000       | 126,167.76 us | 2,489.620 us | 2,556.656 us |  1.00 |    0.03 | 111957.91 KB |        1.00 |
| AtTheBottomWebCustom | 1000000       | 139,326.21 us | 2,574.667 us | 3,931.788 us |  1.10 |    0.04 | 111957.67 KB |        1.00 |
| AtTheTopWebCustom    | 1000000       | 139,224.50 us | 1,528.475 us | 1,429.737 us |  1.10 |    0.02 | 111957.67 KB |        1.00 |