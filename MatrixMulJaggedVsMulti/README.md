# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.101\
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2\
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method                | N    | Mean       | Error    | StdDev   | Ratio | RatioSD |
|---------------------- |----- |-----------:|---------:|---------:|------:|--------:|
| JaggedArraysNormal    | 1000 | 1,878.0 ms | 24.38 ms | 21.61 ms |  1.00 |    0.02 |
| JaggedArraysChanged   | 1000 | 1,506.9 ms | 25.23 ms | 22.36 ms |  0.80 |    0.01 |
| MultiDimArraysNormal  | 1000 | 1,663.2 ms | 30.01 ms | 48.46 ms |  0.89 |    0.03 |
| MultiDimArraysChanged | 1000 | 1,007.9 ms | 15.39 ms | 14.40 ms |  0.54 |    0.01 |
| FlatArrayNormal       | 1000 | 1,111.2 ms | 21.74 ms | 21.35 ms |  0.59 |    0.01 |
| FlatArrayChanged      | 1000 |   827.7 ms | 16.23 ms | 15.94 ms |  0.44 |    0.01 |