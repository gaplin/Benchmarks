# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4061)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.300\
  [Host]     : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2\
  DefaultJob : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2\


| Method           | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| WhereLinq        | 916.7 us | 10.43 us | 11.59 us |  1.00 |    0.02 |      48 B |        1.00 |
| WhereZlinq       | 500.2 us |  8.42 us |  7.87 us |  0.55 |    0.01 |         - |        0.00 |
|                  |          |          |          |       |         |           |             |
| WhereToListLinq  | 796.2 us |  6.54 us |  5.46 us |  1.00 |    0.01 | 2000273 B |        1.00 |
| WhereToListZlinq | 911.8 us |  3.45 us |  3.06 us |  1.15 |    0.01 | 2000217 B |        1.00 |
