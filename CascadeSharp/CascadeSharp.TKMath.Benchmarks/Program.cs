using System;
using BenchmarkDotNet.Running;
using CascadeSharp.TKMath.Benchmarks.math;

namespace CascadeSharp.TKMath.Benchmarks
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benchmark Runner for TKMath");

            var summary = BenchmarkRunner.Run<MathBenchmarks>();
        }
    }
}
