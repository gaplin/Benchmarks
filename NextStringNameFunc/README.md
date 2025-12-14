# Results

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)\
AMD Ryzen 9 7945HX with Radeon Graphics 2.50GHz, 1 CPU, 32 logical and 16 physical cores\
.NET SDK 10.0.101\
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4\
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4


| Method                  | Candidate           | TakenNamesLastNumber | Mean         | Error       | StdDev       | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------ |-------------------- |--------------------- |-------------:|------------:|-------------:|------:|--------:|----------:|------------:|
| StringTest              | Firs(...)dddn [135] | 20000                | 471,244.2 us | 9,144.88 us | 12,819.84 us | 1.001 |    0.04 | 6709976 B |       1.000 |
| StringHashTest          | Firs(...)dddn [135] | 20000                |   1,982.6 us |    39.56 us |     43.97 us | 0.004 |    0.00 | 7130995 B |       1.063 |
| StringHashTestNewLookup | Firs(...)dddn [135] | 20000                |     621.2 us |     1.83 us |      1.52 us | 0.001 |    0.00 |  421408 B |       0.063 |
| SpanTest                | Firs(...)dddn [135] | 20000                | 493,354.1 us | 3,858.04 us |  3,608.81 us | 1.048 |    0.03 |     304 B |       0.000 |