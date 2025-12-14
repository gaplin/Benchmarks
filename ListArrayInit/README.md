# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method                     | Count   | Mean          | Error       | StdDev        | Median        | Ratio | RatioSD | Allocated   | Alloc Ratio |
|--------------------------- |-------- |--------------:|------------:|--------------:|--------------:|------:|--------:|------------:|------------:|
| EnumerableToList           | 1000    |      4.676 us |   0.0931 us |     0.2610 us |      4.781 us |  1.00 |    0.08 |    29.83 KB |        1.00 |
| ListAdd                    | 1000    |      3.529 us |   0.0312 us |     0.0291 us |      3.517 us |  0.76 |    0.05 |    38.09 KB |        1.28 |
| ListAddWithCorrectCapacity | 1000    |      3.161 us |   0.0425 us |     0.0397 us |      3.171 us |  0.68 |    0.04 |    29.74 KB |        1.00 |
| EnumerableToArray          | 1000    |      4.157 us |   0.0828 us |     0.2210 us |      4.200 us |  0.89 |    0.07 |     29.8 KB |        1.00 |
| ArrayFill                  | 1000    |      3.017 us |   0.0373 us |     0.0349 us |      3.017 us |  0.65 |    0.04 |    29.71 KB |        1.00 |
|                            |         |               |             |               |               |       |         |             |             |
| EnumerableToList           | 1000000 | 41,452.118 us | 793.5986 us |   882.0827 us | 41,395.015 us |  1.00 |    0.03 | 46084.87 KB |        1.00 |
| ListAdd                    | 1000000 | 55,074.111 us | 932.2979 us |   872.0720 us | 55,185.920 us |  1.33 |    0.04 |  54656.8 KB |        1.19 |
| ListAddWithCorrectCapacity | 1000000 | 39,225.484 us | 587.9757 us |   521.2251 us | 39,004.938 us |  0.95 |    0.02 | 46084.79 KB |        1.00 |
| EnumerableToArray          | 1000000 | 40,747.357 us | 766.4143 us | 1,049.0766 us | 40,749.735 us |  0.98 |    0.03 | 46084.84 KB |        1.00 |
| ArrayFill                  | 1000000 | 39,076.276 us | 634.3944 us |   562.3741 us | 38,997.338 us |  0.94 |    0.02 | 46084.75 KB |        1.00 |