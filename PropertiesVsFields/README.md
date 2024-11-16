# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 8.0 : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 9.0 : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method         | Job      | Runtime  | Iterations | Mean         | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------- |--------- |--------- |----------- |-------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| AutoProp       | .NET 8.0 | .NET 8.0 | 100000     |     32.97 us |   0.325 us |   0.271 us |  0.99 |    0.02 |         - |          NA |
| NoInliningProp | .NET 8.0 | .NET 8.0 | 100000     |    196.49 us |   3.314 us |   3.100 us |  5.92 |    0.12 |         - |          NA |
| Field          | .NET 8.0 | .NET 8.0 | 100000     |     32.90 us |   0.360 us |   0.337 us |  0.99 |    0.02 |         - |          NA |
| AutoProp       | .NET 9.0 | .NET 9.0 | 100000     |     33.18 us |   0.487 us |   0.456 us |  1.00 |    0.02 |         - |          NA |
| NoInliningProp | .NET 9.0 | .NET 9.0 | 100000     |    195.77 us |   3.240 us |   3.031 us |  5.90 |    0.12 |         - |          NA |
| Field          | .NET 9.0 | .NET 9.0 | 100000     |     33.46 us |   0.229 us |   0.191 us |  1.01 |    0.01 |         - |          NA |
|                |          |          |            |              |            |            |       |         |           |             |
| AutoProp       | .NET 8.0 | .NET 8.0 | 10000000   |  3,334.03 us |  30.593 us |  28.617 us |  1.00 |    0.01 |       2 B |        1.00 |
| NoInliningProp | .NET 8.0 | .NET 8.0 | 10000000   | 20,824.26 us | 413.640 us | 702.392 us |  6.27 |    0.21 |      12 B |        6.00 |
| Field          | .NET 8.0 | .NET 8.0 | 10000000   |  3,315.53 us |  32.313 us |  30.225 us |  1.00 |    0.01 |       2 B |        1.00 |
| AutoProp       | .NET 9.0 | .NET 9.0 | 10000000   |  3,322.42 us |  26.481 us |  23.475 us |  1.00 |    0.01 |       2 B |        1.00 |
| NoInliningProp | .NET 9.0 | .NET 9.0 | 10000000   | 20,021.18 us | 396.580 us | 440.797 us |  6.03 |    0.14 |      12 B |        6.00 |
| Field          | .NET 9.0 | .NET 9.0 | 10000000   |  3,327.73 us |  35.722 us |  31.667 us |  1.00 |    0.01 |       2 B |        1.00 |