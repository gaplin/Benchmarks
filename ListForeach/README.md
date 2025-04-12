# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.203\
  [Host]     : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2\
  DefaultJob : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2


| Method            | Mean     | Error   | StdDev  | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------ |---------:|--------:|--------:|------:|--------:|----------:|------------:|
| ForeachList       | 439.6 us | 4.90 us | 4.58 us |  1.00 |    0.01 |         - |          NA |
| ForeachEnumerable | 867.4 us | 6.34 us | 5.93 us |  1.97 |    0.02 |      40 B |          NA |