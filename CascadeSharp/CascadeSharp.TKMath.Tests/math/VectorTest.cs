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
        public void ShouldReturnMinimum()
        {
            var v = new Vector();
            
            v.Add(8);
            v.Add(100);
            v.Add(5);
            Assert.True(v.Min() == 2);
        }
        [Fact]
        public void ShouldReturnMaximum()
        {
            var v = new Vector();
            v.Add(8);
            v.Add(100);
            v.Add(5);
            Assert.True(v.Max() == 1);
        }
    }
}
