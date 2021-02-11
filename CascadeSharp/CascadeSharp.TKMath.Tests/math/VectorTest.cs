using System;
using System.Collections.Generic;
using System.Text;
using CascadeSharp.TKMath.math;
using Xunit;

namespace CascadeSharp.TKMath.Tests.math
{
    public class VectorTest
    {
        [Fact]
        public void ShouldReturnMinimumValueIndex()
        {
            var v = new Vector();
            
            v.Add(8);
            v.Add(100);
            v.Add(-5);
            v.Add(5);
            Assert.True(v.Min() == 2);
        }
        [Fact]
        public void ShouldReturnMaximumValueIndex()
        {
            var v = new Vector();
            v.Add(8);
            v.Add(100);
            v.Add(-5);
            v.Add(5);
            Assert.True(v.Max() == 1);
        }

        [Fact]
        public void ShouldNormalize()
        {
            var v = new Vector();
            v.Add(8);
            v.Add(100);
            v.Add(-5);
            v.Add(5);
            var n = v.Normalized();
            Assert.Equal( 0.079547862127108571, n[0]);
            Assert.Equal( 0.99434827658885716,n[1]);
            Assert.Equal( -0.049717413829442864, n[2]);
            Assert.Equal( 0.049717413829442864, n[3]);
        }

        [Fact]
        public void ShouldInitWithDefinedValue()
        {
            var v = new Vector(10);
            v.Init(10);
            foreach (var vi in v)
            {
                Assert.Equal(10,vi);
            }
        }
        
    }
}
