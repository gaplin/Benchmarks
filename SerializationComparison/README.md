# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100-rc.2.24474.11\
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


| Method                        | Count | Mean      | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------------ |------ |----------:|---------:|---------:|------:|--------:|----------:|------------:|
| SystemTextDeserialization     | 1000  | 227.41 ms | 4.499 ms | 7.517 ms |  1.00 |    0.05 | 303.55 MB |        1.00 |
| NewtonsoftJsonDeserialization | 1000  | 382.70 ms | 3.506 ms | 3.108 ms |  1.68 |    0.06 | 168.46 MB |        0.55 |
| ProtobufDeserialization       | 1000  | 115.45 ms | 2.272 ms | 3.733 ms |  0.51 |    0.02 | 144.14 MB |        0.47 |
|                               |       |           |          |          |       |         |           |             |
| SystemTextSerialization       | 1000  | 154.99 ms | 3.082 ms | 2.732 ms |  1.00 |    0.02 | 303.99 MB |        1.00 |
| NewtonsoftJsonSerialization   | 1000  | 268.79 ms | 4.148 ms | 3.238 ms |  1.73 |    0.04 |  635.9 MB |        2.09 |
| ProtobufSerialization         | 1000  |  75.00 ms | 1.412 ms | 1.251 ms |  0.48 |    0.01 | 231.77 MB |        0.76 |