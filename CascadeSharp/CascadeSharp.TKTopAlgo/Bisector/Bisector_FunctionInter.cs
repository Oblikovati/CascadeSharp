//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKTopAlgo.Bisector
{
    //---------------------------------------------------------------------
    //  Class  Bisector_FunctionInter
    //---------------------------------------------------------------------
    public sealed class Bisector_FunctionInter : math_FunctionWithDerivative
    {
        public Bisector_FunctionInter()
            : base()
        {
            throw new NotImplementedException();
        }

        public Bisector_FunctionInter(Geom2d_Curve C, Bisector_Curve B_is1, Bisector_Curve B_is2)
            : base()
        {
            throw new NotImplementedException();
        }

        public Bisector_FunctionInter(Bisector_FunctionInter parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Perform(Geom2d_Curve C, Bisector_Curve B_is1, Bisector_Curve B_is2)
        {
            throw new NotImplementedException();
        }

        public bool Value(double X, ref double F)
        {
            throw new NotImplementedException();
        }

        public bool Derivative(double X, ref double D)
        {
            throw new NotImplementedException();
        }

        public bool Values(double X, ref double F, ref double D)
        {
            throw new NotImplementedException();
        }
    }; // class Bisector_FunctionInter
}