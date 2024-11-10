# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100-rc.2.24474.11\
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


| Method         | Iterations | Mean         | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------- |----------- |-------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| AutoProp       | 100000     |     32.56 us |   0.136 us |   0.121 us |  1.00 |    0.01 |         - |          NA |
| NoInliningProp | 100000     |    192.26 us |   1.336 us |   1.249 us |  5.91 |    0.04 |         - |          NA |
| Field          | 100000     |     32.33 us |   0.050 us |   0.039 us |  0.99 |    0.00 |         - |          NA |
|                |            |              |            |            |       |         |           |             |
| AutoProp       | 10000000   |  3,240.69 us |  11.581 us |  10.833 us |  1.00 |    0.00 |       2 B |        1.00 |
| NoInliningProp | 10000000   | 20,627.09 us | 125.225 us | 117.136 us |  6.37 |    0.04 |      12 B |        6.00 |
| Field          | 10000000   |  3,269.36 us |  18.707 us |  17.499 us |  1.01 |    0.01 |       2 B |        1.00 |