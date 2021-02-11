using System;
using BenchmarkDotNet.Attributes;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKMath.Benchmarks.math
{
    public class MathBenchmarks
    {
        private Vector gaussPoints;
        private Vector gaussWeights;
        private int gaussIndex;
        public MathBenchmarks()
        {
            gaussIndex = new Random().Next(3, TKMath.math.math.GaussPointsMax);
        }

        [Benchmark]
        public void GaussPoints() => TKMath.math.math.GaussPoints(gaussIndex, out gaussPoints);
        [Benchmark]
        public void GaussWeights() => TKMath.math.math.GaussWeights(gaussIndex, out gaussWeights);
        [Benchmark]
        public bool GaussPointsAndWeights() =>
            TKMath.math.math.OrderedGaussPointsAndWeights(gaussIndex, out gaussPoints, out gaussWeights);
    }
}