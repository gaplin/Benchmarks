# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100-rc.2.24474.11\
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


| Method                 | StrLength | Mean          | Error        | StdDev       | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------- |---------- |--------------:|-------------:|-------------:|------:|--------:|----------:|------------:|
| ForeachString          | 100       |      42.53 ns |     0.251 ns |     0.222 ns |  1.00 |    0.01 |         - |          NA |
| ForString              | 100       |      42.34 ns |     0.184 ns |     0.172 ns |  1.00 |    0.01 |         - |          NA |
| ForStringLengthOutside | 100       |      42.29 ns |     0.111 ns |     0.104 ns |  0.99 |    0.01 |         - |          NA |
| ForeachSpan            | 100       |      37.62 ns |     0.178 ns |     0.166 ns |  0.88 |    0.01 |         - |          NA |
| ForSpan                | 100       |      47.63 ns |     0.390 ns |     0.365 ns |  1.12 |    0.01 |         - |          NA |
| ForSpanLengthOutside   | 100       |      47.51 ns |     0.755 ns |     0.706 ns |  1.12 |    0.02 |         - |          NA |
|                        |           |               |              |              |       |         |           |             |
| ForeachString          | 1000000   | 311,546.74 ns | 6,145.357 ns | 7,077.002 ns |  1.00 |    0.03 |         - |          NA |
| ForString              | 1000000   | 312,055.30 ns | 6,116.932 ns | 5,721.782 ns |  1.00 |    0.03 |         - |          NA |
| ForStringLengthOutside | 1000000   | 300,714.40 ns | 2,242.093 ns | 1,872.249 ns |  0.97 |    0.02 |         - |          NA |
| ForeachSpan            | 1000000   | 381,350.48 ns | 1,693.416 ns | 1,584.022 ns |  1.22 |    0.03 |         - |          NA |
| ForSpan                | 1000000   | 381,737.03 ns | 4,883.698 ns | 4,329.271 ns |  1.23 |    0.03 |         - |          NA |
| ForSpanLengthOutside   | 1000000   | 381,851.39 ns | 2,258.910 ns | 1,886.292 ns |  1.23 |    0.03 |         - |          NA |