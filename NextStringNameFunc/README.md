# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2\
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method                  | Candidate           | TakenNamesLastNumber | Mean         | Error        | StdDev       | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------ |-------------------- |--------------------- |-------------:|-------------:|-------------:|------:|--------:|----------:|------------:|
| StringTest              | Firs(...)dddn [135] | 20000                | 862,544.5 us | 16,777.37 us | 22,965.05 us | 1.001 |    0.04 | 6710376 B |       1.000 |
| StringHashTest          | Firs(...)dddn [135] | 20000                |   2,852.2 us |     45.84 us |     42.88 us | 0.003 |    0.00 | 7130745 B |       1.063 |
| StringHashTestNewLookup | Firs(...)dddn [135] | 20000                |     822.2 us |     14.95 us |     13.99 us | 0.001 |    0.00 |  421432 B |       0.063 |
| SpanTest                | Firs(...)dddn [135] | 20000                | 911,242.1 us | 17,998.22 us | 35,944.40 us | 1.057 |    0.05 |     416 B |       0.000 |