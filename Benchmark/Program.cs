// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;

Console.WriteLine("Benchmark");

BenchmarkRunner.Run<EfBenchmark>();


