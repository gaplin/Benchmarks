# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.102\
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2\
  DefaultJob : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2


| Method                     | Count   | Mean          | Error         | StdDev        | Ratio | RatioSD | Allocated   | Alloc Ratio |
|--------------------------- |-------- |--------------:|--------------:|--------------:|------:|--------:|------------:|------------:|
| EnumerableToList           | 1000    |      6.617 us |     0.0522 us |     0.0488 us |  1.00 |    0.01 |    29.83 KB |        1.00 |
| ListAdd                    | 1000    |      4.312 us |     0.0554 us |     0.0491 us |  0.65 |    0.01 |    38.09 KB |        1.28 |
| ListAddWithCorrectCapacity | 1000    |      3.682 us |     0.0393 us |     0.0368 us |  0.56 |    0.01 |    29.74 KB |        1.00 |
| EnumerableToArray          | 1000    |      6.662 us |     0.0762 us |     0.0676 us |  1.01 |    0.01 |     29.8 KB |        1.00 |
| ArrayFill                  | 1000    |      3.434 us |     0.0282 us |     0.0264 us |  0.52 |    0.01 |    29.71 KB |        1.00 |
|                            |         |               |               |               |       |         |             |             |
| EnumerableToList           | 1000000 | 70,228.658 us | 1,382.9785 us | 2,385.5702 us |  1.00 |    0.05 |  46086.1 KB |        1.00 |
| ListAdd                    | 1000000 | 73,428.632 us | 1,445.5069 us | 3,172.9229 us |  1.05 |    0.06 | 54656.85 KB |        1.19 |
| ListAddWithCorrectCapacity | 1000000 | 67,154.797 us | 1,316.5543 us | 2,163.1367 us |  0.96 |    0.04 | 46084.96 KB |        1.00 |
| EnumerableToArray          | 1000000 | 69,325.305 us | 1,322.2516 us | 1,623.8439 us |  0.99 |    0.04 | 46084.99 KB |        1.00 |
| ArrayFill                  | 1000000 | 66,031.688 us | 1,318.6447 us | 2,663.7275 us |  0.94 |    0.05 | 46084.91 KB |        1.00 |