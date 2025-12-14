# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method       | Elements | Mean          | Error      | StdDev     | Ratio | RatioSD | Allocated   | Alloc Ratio |
|------------- |--------- |--------------:|-----------:|-----------:|------:|--------:|------------:|------------:|
| Record       | 1000     |     11.250 us |  0.1491 us |  0.1395 us |  1.00 |    0.02 |    38.94 KB |        1.00 |
| Class        | 1000     |      5.299 us |  0.0551 us |  0.0515 us |  0.47 |    0.01 |    10.81 KB |        0.28 |
| RecordStruct | 1000     |      7.885 us |  0.0308 us |  0.0257 us |  0.70 |    0.01 |    14.33 KB |        0.37 |
| Struct       | 1000     |      7.939 us |  0.0384 us |  0.0320 us |  0.71 |    0.01 |    14.33 KB |        0.37 |
|              |          |               |            |            |       |         |             |             |
| Record       | 1000000  | 14,047.258 us | 52.8676 us | 49.4524 us |  1.00 |    0.00 | 31257.69 KB |       1.000 |
| Class        | 1000000  |  5,285.828 us |  5.6123 us |  4.9751 us |  0.38 |    0.00 |    10.81 KB |       0.000 |
| RecordStruct | 1000000  |  8,030.842 us | 25.7883 us | 22.8607 us |  0.57 |    0.00 |    14.33 KB |       0.000 |
| Struct       | 1000000  |  8,013.180 us |  4.7839 us |  3.7349 us |  0.57 |    0.00 |    14.33 KB |       0.000 |