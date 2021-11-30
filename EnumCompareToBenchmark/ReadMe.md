``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1348 (20H2/October2020Update)
Intel Core i7-6700HQ CPU 2.60GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.403
  [Host]             : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT  [AttachedDebugger]
  .NET 5.0           : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT


```
| Method |                Job |            Runtime |      Mean |    Error |    StdDev |    Median | Code Size |
|------- |------------------- |------------------- |----------:|---------:|----------:|----------:|----------:|
| Simple |           .NET 5.0 |           .NET 5.0 |  50.32 μs | 0.729 μs |  0.682 μs |  50.10 μs |     363 B |
|    Box |           .NET 5.0 |           .NET 5.0 | 148.50 μs | 3.929 μs | 11.272 μs | 146.12 μs |     410 B |
| Simple | .NET Framework 4.8 | .NET Framework 4.8 |  71.03 μs | 1.398 μs |  2.824 μs |  70.62 μs |     305 B |
|    Box | .NET Framework 4.8 | .NET Framework 4.8 | 179.40 μs | 5.314 μs | 15.247 μs | 174.89 μs |     351 B |
