# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2\
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method         | Candidate           | TakenNamesLastNumber | Mean       | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------- |-------------------- |--------------------- |-----------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| StringTest     | Firs(...)dddn [135] | 20000                | 887.876 ms | 17.6677 ms | 33.1842 ms | 1.001 |    0.05 | 6710376 B |       1.000 |
| StringHashTest | Firs(...)dddn [135] | 20000                |   2.892 ms |  0.0370 ms |  0.0346 ms | 0.003 |    0.00 | 7130748 B |       1.063 |
| SpanTest       | Firs(...)dddn [135] | 20000                | 894.361 ms | 16.3457 ms | 26.8565 ms | 1.009 |    0.05 |     704 B |       0.000 |