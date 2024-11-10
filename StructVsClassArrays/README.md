# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100-rc.2.24474.11\
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


| Method     | ArrSize | Mean           | Error        | StdDev       | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------- |-------- |---------------:|-------------:|-------------:|------:|--------:|----------:|------------:|
| TestClass  | 1000    |       471.2 ns |      1.89 ns |      1.68 ns |  1.00 |    0.00 |         - |          NA |
| TestStruct | 1000    |       464.9 ns |      1.11 ns |      0.93 ns |  0.99 |    0.00 |         - |          NA |
|            |         |                |              |              |       |         |           |             |
| TestClass  | 1000000 | 1,288,986.5 ns | 24,691.99 ns | 24,250.83 ns |  1.00 |    0.03 |       1 B |        1.00 |
| TestStruct | 1000000 |   481,394.3 ns |  3,218.82 ns |  2,687.86 ns |  0.37 |    0.01 |         - |        0.00 |