# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100-rc.2.24474.11\
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


| Method               | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| ValueTasksInt        |  7.933 ns | 0.1855 ns | 0.2540 ns |  1.00 |    0.04 |         - |          NA |
| TasksInt             | 11.911 ns | 0.2582 ns | 0.2416 ns |  1.50 |    0.06 |     144 B |          NA |
| ValueTasksAsyncInt   | 20.986 ns | 0.1419 ns | 0.1327 ns |  2.65 |    0.09 |         - |          NA |
| TasksAsyncInt        | 39.124 ns | 0.2842 ns | 0.2519 ns |  4.94 |    0.16 |     360 B |          NA |
| ValueTasksDummy      | 12.232 ns | 0.0846 ns | 0.0706 ns |  1.54 |    0.05 |      96 B |          NA |
| TasksDummy           | 15.935 ns | 0.1509 ns | 0.1412 ns |  2.01 |    0.07 |     168 B |          NA |
| ValueTasksAsyncDummy | 31.034 ns | 0.2920 ns | 0.2732 ns |  3.92 |    0.13 |      96 B |          NA |
| TasksAsyncDummy      | 44.812 ns | 0.7714 ns | 0.6442 ns |  5.65 |    0.20 |     384 B |          NA |
