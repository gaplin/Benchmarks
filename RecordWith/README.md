# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100-rc.2.24474.11\
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


| Method       | Elements | Mean          | Error       | StdDev      | Ratio | RatioSD | Allocated   | Alloc Ratio |
|------------- |--------- |--------------:|------------:|------------:|------:|--------:|------------:|------------:|
| Record       | 1000     |     19.299 us |   0.2790 us |   0.2330 us |  1.00 |    0.02 |    38.94 KB |        1.00 |
| Class        | 1000     |      9.389 us |   0.0797 us |   0.0707 us |  0.49 |    0.01 |    10.81 KB |        0.28 |
| RecordStruct | 1000     |     17.587 us |   0.1166 us |   0.1034 us |  0.91 |    0.01 |    14.33 KB |        0.37 |
| Struct       | 1000     |     17.406 us |   0.1639 us |   0.1533 us |  0.90 |    0.01 |    14.33 KB |        0.37 |
|              |          |               |             |             |       |         |             |             |
| Record       | 1000000  | 19,175.112 us | 218.1523 us | 170.3189 us |  1.00 |    0.01 | 31257.69 KB |       1.000 |
| Class        | 1000000  |  8,898.669 us |  81.2107 us |  71.9912 us |  0.46 |    0.01 |    10.82 KB |       0.000 |
| RecordStruct | 1000000  | 16,007.491 us | 194.3514 us | 181.7964 us |  0.83 |    0.01 |    14.34 KB |       0.000 |
| Struct       | 1000000  | 16,025.176 us | 159.2304 us | 148.9442 us |  0.84 |    0.01 |    14.34 KB |       0.000 |