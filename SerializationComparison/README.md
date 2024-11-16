# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 8.0 : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 9.0 : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method                        | Job      | Runtime  | Count | Mean      | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------------ |--------- |--------- |------ |----------:|---------:|---------:|------:|--------:|----------:|------------:|
| SystemTextDeserialization     | .NET 8.0 | .NET 8.0 | 1000  | 228.13 ms | 4.525 ms | 6.040 ms |  1.21 |    0.04 | 303.55 MB |        2.00 |
| NewtonsoftJsonDeserialization | .NET 8.0 | .NET 8.0 | 1000  | 382.58 ms | 6.859 ms | 6.416 ms |  2.03 |    0.05 | 168.47 MB |        1.11 |
| ProtobufDeserialization       | .NET 8.0 | .NET 8.0 | 1000  | 114.15 ms | 2.016 ms | 2.322 ms |  0.61 |    0.02 | 144.14 MB |        0.95 |
| SystemTextDeserialization     | .NET 9.0 | .NET 9.0 | 1000  | 188.45 ms | 3.468 ms | 3.244 ms |  1.00 |    0.02 | 151.56 MB |        1.00 |
| NewtonsoftJsonDeserialization | .NET 9.0 | .NET 9.0 | 1000  | 387.28 ms | 7.301 ms | 7.813 ms |  2.06 |    0.05 | 168.47 MB |        1.11 |
| ProtobufDeserialization       | .NET 9.0 | .NET 9.0 | 1000  | 111.12 ms | 2.169 ms | 3.179 ms |  0.59 |    0.02 | 144.14 MB |        0.95 |
|                               |          |          |       |           |          |          |       |         |           |             |
| SystemTextSerialization       | .NET 8.0 | .NET 8.0 | 1000  | 156.22 ms | 3.046 ms | 3.386 ms |  1.07 |    0.02 | 303.99 MB |        1.00 |
| NewtonsoftJsonSerialization   | .NET 8.0 | .NET 8.0 | 1000  | 270.18 ms | 5.235 ms | 6.232 ms |  1.86 |    0.04 |  635.9 MB |        2.09 |
| ProtobufSerialization         | .NET 8.0 | .NET 8.0 | 1000  |  73.81 ms | 1.076 ms | 1.006 ms |  0.51 |    0.01 | 231.77 MB |        0.76 |
| SystemTextSerialization       | .NET 9.0 | .NET 9.0 | 1000  | 145.56 ms | 1.423 ms | 1.261 ms |  1.00 |    0.01 | 303.99 MB |        1.00 |
| NewtonsoftJsonSerialization   | .NET 9.0 | .NET 9.0 | 1000  | 264.89 ms | 5.157 ms | 5.732 ms |  1.82 |    0.04 |  635.9 MB |        2.09 |
| ProtobufSerialization         | .NET 9.0 | .NET 9.0 | 1000  |  70.48 ms | 0.735 ms | 0.651 ms |  0.48 |    0.01 | 231.78 MB |        0.76 |