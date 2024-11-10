# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100-rc.2.24474.11\
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


| Method        | Iterations | Mean         | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------- |----------- |-------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| AbstractMatch | 1000       |     7.542 us |  0.1499 us |  0.1604 us |  1.00 |    0.03 |         - |          NA |
| StructMatch   | 1000       |     5.990 us |  0.0637 us |  0.0596 us |  0.79 |    0.02 |         - |          NA |
|               |            |              |            |            |       |         |           |             |
| AbstractMatch | 1000000    | 7,508.921 us | 50.8484 us | 47.5636 us |  1.00 |    0.01 |         - |          NA |
| StructMatch   | 1000000    | 6,395.027 us | 61.0352 us | 57.0923 us |  0.85 |    0.01 |       3 B |          NA |