# Results

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3)\
12th Gen Intel Core i7-12650H, 1 CPU, 16 logical and 10 physical cores\
.NET SDK 9.0.100\
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 8.0 : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2\
  .NET 9.0 : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method     | Job      | Runtime  | ArrSize | Mean           | Error        | StdDev       | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------- |--------- |--------- |-------- |---------------:|-------------:|-------------:|------:|--------:|----------:|------------:|
| TestClass  | .NET 8.0 | .NET 8.0 | 1000    |       478.5 ns |      3.74 ns |      3.12 ns |  1.01 |    0.01 |         - |          NA |
| TestStruct | .NET 8.0 | .NET 8.0 | 1000    |       476.1 ns |      4.83 ns |      4.52 ns |  1.00 |    0.01 |         - |          NA |
| TestClass  | .NET 9.0 | .NET 9.0 | 1000    |       476.0 ns |      6.09 ns |      5.69 ns |  1.00 |    0.02 |			- |          NA |
| TestStruct | .NET 9.0 | .NET 9.0 | 1000    |       474.7 ns |      6.62 ns |      5.87 ns |  1.00 |    0.02 |			- |          NA |
|            |          |          |         |                |              |              |       |         |			  |             |
| TestClass  | .NET 8.0 | .NET 8.0 | 1000000 | 1,176,336.9 ns | 12,607.59 ns | 10,527.91 ns |  1.00 |    0.01 |       1 B |          NA |
| TestStruct | .NET 8.0 | .NET 8.0 | 1000000 |   482,755.4 ns |  6,905.24 ns |  6,459.16 ns |  0.41 |    0.01 |			- |          NA |
| TestClass  | .NET 9.0 | .NET 9.0 | 1000000 | 1,174,594.1 ns |  8,111.06 ns |  7,190.24 ns |  1.00 |    0.01 |			- |          NA |
| TestStruct | .NET 9.0 | .NET 9.0 | 1000000 |   481,934.3 ns |  2,966.23 ns |  2,629.48 ns |  0.41 |    0.00 |			- |          NA |