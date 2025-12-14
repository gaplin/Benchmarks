# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method                        | Count | Mean      | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------------ |------ |----------:|---------:|---------:|------:|--------:|----------:|------------:|
| SystemTextDeserialization     | 1000  | 173.90 ms | 3.373 ms | 3.884 ms |  1.00 |    0.03 | 151.56 MB |        1.00 |
| NewtonsoftJsonDeserialization | 1000  | 359.65 ms | 4.632 ms | 4.333 ms |  2.07 |    0.05 | 168.46 MB |        1.11 |
| ProtobufDeserialization       | 1000  |  98.09 ms | 1.874 ms | 2.370 ms |  0.56 |    0.02 | 144.14 MB |        0.95 |
|                               |       |           |          |          |       |         |           |             |
| SystemTextSerialization       | 1000  |  94.99 ms | 0.190 ms | 0.159 ms |  1.00 |    0.00 | 303.99 MB |        1.00 |
| NewtonsoftJsonSerialization   | 1000  | 220.49 ms | 4.233 ms | 4.705 ms |  2.32 |    0.05 |  635.9 MB |        2.09 |
| ProtobufSerialization         | 1000  |  53.82 ms | 0.255 ms | 0.239 ms |  0.57 |    0.00 | 231.77 MB |        0.76 |