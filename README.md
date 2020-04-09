# JsonSerializerBenchmark
A custom benchmark where I test multiple JSON serializers to check how quickly they can serialize and deserialize a UserProfile object with some data in a million times. 

Everything in .NET Core 3.1.2. The serializers tested are:

1. NewtonSoft
1. ServiceStack.Text
1. Jil
1. System.Text.Json
1. Utf8Json

## Build and run

Go to the solution folder via command line and execute the following

```
dotnet build --configuration Release
```

After that go to and execute

```
JsonSerializerBenchmark\bin\Release\netcoreapp3.1\JsonSerializerBenchmark.exe
```

This will take roughly 30 minutes to complete. After it's done, it will automatically close the cli and put the results in 

```
JsonSerializerBenchmark\bin\Release\netcoreapp3.1\BenchmarkDotNet.Artifacts\results
```

## Results

Results are specific to my setup

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.720 (1909/November2018Update/19H2)
Intel Core i7-5820K CPU 3.30GHz (Broadwell), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  DefaultJob : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT


```
|                                    Method |     Mean |    Error |   StdDev |      Min |      Max | Ratio | RatioSD |        Gen 0 |      Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |---------:|---------:|---------:|---------:|---------:|------:|--------:|-------------:|-----------:|------:|----------:|
|       SerializeAndDeserializeInNewtonSoft | 28.749 s | 0.3093 s | 0.2893 s | 28.243 s | 29.062 s |  2.32 |    0.04 | 1571000.0000 | 29000.0000 |     - |  11.47 GB |
| SerializeAndDeserializeInServiceStackText | 16.455 s | 0.1847 s | 0.1728 s | 16.218 s | 16.736 s |  1.33 |    0.02 |  586000.0000 |  1000.0000 |     - |   4.28 GB |
|              SerializeAndDeserializeInJil |  9.824 s | 0.1102 s | 0.0977 s |  9.697 s | 10.054 s |  0.79 |    0.01 |  863000.0000 | 10000.0000 |     - |    6.3 GB |
|         SerializeAndDeserializeInTextJson | 12.396 s | 0.1048 s | 0.0875 s | 12.220 s | 12.546 s |  1.00 |    0.00 |  488000.0000 |  3000.0000 |     - |   3.57 GB |
|         SerializeAndDeserializeInUtf8Json |  6.787 s | 0.0493 s | 0.0437 s |  6.729 s |  6.880 s |  0.55 |    0.00 |  247000.0000 |          - |     - |   1.81 GB |
