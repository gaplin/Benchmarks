# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 8.0 : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 9.0 : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method               | Job      | Runtime  | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------------- |--------- |--------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| ValueTasksInt        | .NET 8.0 | .NET 8.0 |  8.149 ns | 0.1356 ns | 0.1268 ns |  1.02 |    0.05 |         - |          NA |
| TasksInt             | .NET 8.0 | .NET 8.0 | 11.595 ns | 0.2579 ns | 0.4716 ns |  1.45 |    0.09 |     144 B |          NA |
| ValueTasksAsyncInt   | .NET 8.0 | .NET 8.0 | 23.068 ns | 0.4888 ns | 0.8031 ns |  2.88 |    0.16 |         - |          NA |
| TasksAsyncInt        | .NET 8.0 | .NET 8.0 | 40.002 ns | 0.7189 ns | 0.6724 ns |  4.99 |    0.23 |     360 B |          NA |
| ValueTasksDummy      | .NET 8.0 | .NET 8.0 | 13.203 ns | 0.3064 ns | 0.3874 ns |  1.65 |    0.09 |      96 B |          NA |
| TasksDummy           | .NET 8.0 | .NET 8.0 | 16.685 ns | 0.3738 ns | 0.4450 ns |  2.08 |    0.10 |     168 B |          NA |
| ValueTasksAsyncDummy | .NET 8.0 | .NET 8.0 | 31.222 ns | 0.6544 ns | 0.8276 ns |  3.89 |    0.20 |      96 B |          NA |
| TasksAsyncDummy      | .NET 8.0 | .NET 8.0 | 45.371 ns | 0.9379 ns | 1.5926 ns |  5.66 |    0.31 |     384 B |          NA |
| ValueTasksInt        | .NET 9.0 | .NET 9.0 |  8.035 ns | 0.1847 ns | 0.3424 ns |  1.00 |    0.06 |         - |          NA |
| TasksInt             | .NET 9.0 | .NET 9.0 | 12.061 ns | 0.2638 ns | 0.3336 ns |  1.50 |    0.08 |     144 B |          NA |
| ValueTasksAsyncInt   | .NET 9.0 | .NET 9.0 | 22.673 ns | 0.4776 ns | 1.0074 ns |  2.83 |    0.17 |         - |          NA |
| TasksAsyncInt        | .NET 9.0 | .NET 9.0 | 36.621 ns | 0.5888 ns | 0.5220 ns |  4.57 |    0.21 |     360 B |          NA |
| ValueTasksDummy      | .NET 9.0 | .NET 9.0 | 12.686 ns | 0.3009 ns | 0.3220 ns |  1.58 |    0.08 |      96 B |          NA |
| TasksDummy           | .NET 9.0 | .NET 9.0 | 18.099 ns | 0.4051 ns | 0.8366 ns |  2.26 |    0.14 |     168 B |          NA |
| ValueTasksAsyncDummy | .NET 9.0 | .NET 9.0 | 33.557 ns | 0.7132 ns | 1.4728 ns |  4.18 |    0.26 |      96 B |          NA |
| TasksAsyncDummy      | .NET 9.0 | .NET 9.0 | 49.458 ns | 1.0341 ns | 1.5478 ns |  6.17 |    0.33 |     384 B |          NA |
