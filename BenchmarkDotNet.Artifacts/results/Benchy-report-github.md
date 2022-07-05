``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 20.04
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.301
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                                      Method |       Mean |    Error |   StdDev |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|-------------------------------------------- |-----------:|---------:|---------:|---------:|---------:|---------:|----------:|
| CalculateSmallestWorthwhileChangeCollection | 2,336.7 μs | 14.16 μs | 12.55 μs | 246.0938 | 246.0938 | 246.0938 |    782 KB |
|     CalculateSmallestWorthwhileChangeStream |   910.4 μs |  3.42 μs |  3.03 μs | 249.0234 | 249.0234 | 249.0234 |    782 KB |
