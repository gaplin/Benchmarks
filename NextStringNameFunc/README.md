# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4391/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100-rc.2.24474.11\
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2\
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


| Method         | Candidate           | TakenNamesLastNumber | Mean       | Error      | StdDev     | Ratio | Allocated | Alloc Ratio |
|--------------- |-------------------- |--------------------- |-----------:|-----------:|-----------:|------:|----------:|------------:|
| StringTest     | Firs(...)dddn [135] | 20000                | 964.123 ms | 11.0433 ms |  9.7896 ms | 1.000 | 6710376 B |       1.000 |
| StringHashTest | Firs(...)dddn [135] | 20000                |   2.915 ms |  0.0580 ms |  0.0596 ms | 0.003 | 7130748 B |       1.063 |
| SpanTest       | Firs(...)dddn [135] | 20000                | 886.265 ms | 11.9651 ms | 11.1922 ms | 0.919 |     704 B |       0.000 |