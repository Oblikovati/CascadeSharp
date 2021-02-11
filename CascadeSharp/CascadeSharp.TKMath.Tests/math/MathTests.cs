using System;
using CascadeSharp.TKMath.math;
using Xunit;

namespace CascadeSharp.TKMath.Tests.math
{
    public class MathTests
    {
        [Fact]
        public void ShouldCalculateGaussPoints()
        {
            TKMath.math.math.GaussPoints(10, out var points);
        }

        [Fact]
        public void ShouldCalculateOrderedGaussPointsAndWeights()
        {
            //https://keisan.casio.com/exec/system/1329114617
            //Gauss - Legendre quadrature
            var expP = new Vector(10);
            expP.Add(-0.973906528517171720078);
            expP.Add(- 0.8650633666889845107321);
            expP.Add(- 0.6794095682990244062343);
            expP.Add(- 0.4333953941292471907993);
            expP.Add(- 0.1488743389816312108848);
            expP.Add(0.1488743389816312108848);
            expP.Add(0.4333953941292471907993);
            expP.Add(0.6794095682990244062343);
            expP.Add(0.8650633666889845107321);
            expP.Add(0.973906528517171720078);
            
            var expW = new Vector(10);
            expW.Add(0.0666713443086881375936);
            expW.Add(0.149451349150580593146);
            expW.Add(0.219086362515982043996);
            expW.Add(0.2692667193099963550912);
            expW.Add(0.2955242247147528701739);
            expW.Add(0.295524224714752870174);
            expW.Add(0.269266719309996355091);
            expW.Add(0.2190863625159820439955);
            expW.Add(0.1494513491505805931458);
            expW.Add(0.0666713443086881375936);

            TKMath.math.math.OrderedGaussPointsAndWeights(10, out var points,out var weights);
            for (int i = 0; i < 10; i++)
            {
                Assert.Equal(Math.Round(expP[i],14),Math.Round(points[i],14));
                Assert.Equal(Math.Round(expW[i], 14), Math.Round(weights[i], 14));
            }
        }
        [Fact]
        public void ShouldCalculateKronrodPointsAndWeightsFromTable()
        {
            //https://keisan.casio.com/exec/system/1289382036
            //Kronrod xi wi Order 9
            var expectedp = new Vector(9);
                              
            expectedp.Add(-0.97656025073757);
            expectedp.Add(-0.86113631159405);
            expectedp.Add(-0.64028621749630);
            expectedp.Add(-0.33998104358485);
            expectedp.Add( 0);
            expectedp.Add( 0.33998104358485);
            expectedp.Add( 0.64028621749630);
            expectedp.Add( 0.86113631159405);
            expectedp.Add( 0.97656025073757);

            var expectedw = new Vector(9);
            expectedw.Add( 0.06297737366547);
            expectedw.Add( 0.17005360533572);
            expectedw.Add( 0.26679834045228);
            expectedw.Add( 0.32694918960145);
            expectedw.Add( 0.34644298189013);
            expectedw.Add( 0.32694918960145);
            expectedw.Add( 0.26679834045228);
            expectedw.Add( 0.17005360533572);
            expectedw.Add( 0.06297737366547);

            var p = new Vector(9);
            p.Init(0);
            var w = new Vector(9);
            w.Init(0);

            TKMath.math.math.KronrodPointsAndWeights(9,ref p,ref w);

            for (var i = 0; i < p.Count; i++)
            {
                //Rounded to avoid testing errors because of divergence in the casio calculator and this code
                Assert.Equal(Math.Round(expectedp[i],12),Math.Round(p[i],12));
                Assert.Equal(Math.Round(expectedw[i],12),Math.Round(w[i],12));
            }
        }
    }
}
