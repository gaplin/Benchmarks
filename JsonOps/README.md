# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method                      | Properties | Mean          | Error      | StdDev     | Ratio | Gen0     | Gen1     | Gen2     | Allocated | Alloc Ratio |
|---------------------------- |----------- |--------------:|-----------:|-----------:|------:|---------:|---------:|---------:|----------:|------------:|
| JsonSerializer_Deserlialize | 100        |      8.086 us |  0.0768 us |  0.0718 us |  1.00 |   0.0763 |        - |        - |    1424 B |        1.00 |
| JsonReader_Buffered         | 100        |      2.058 us |  0.0189 us |  0.0167 us |  0.25 |   0.1488 |        - |        - |    2496 B |        1.75 |
| JsonReader_Streamed         | 100        |      2.332 us |  0.0200 us |  0.0187 us |  0.29 |        - |        - |        - |      24 B |        0.02 |
|                             |            |               |            |            |       |          |          |          |           |             |
| JsonSerializer_Deserlialize | 100000     | 18,842.868 us | 98.5991 us | 82.3347 us |  1.00 | 218.7500 |        - |        - | 3997424 B |       1.000 |
| JsonReader_Buffered         | 100000     |  2,345.837 us | 11.7795 us | 10.4423 us |  0.12 | 324.2188 | 324.2188 | 324.2188 | 2737490 B |       0.685 |
| JsonReader_Streamed         | 100000     |  2,643.738 us | 20.5112 us | 19.1862 us |  0.14 |        - |        - |        - |      24 B |       0.000 |