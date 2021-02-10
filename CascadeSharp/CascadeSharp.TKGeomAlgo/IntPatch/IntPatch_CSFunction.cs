//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
    //---------------------------------------------------------------------
    //  Class  IntPatch_CSFunction
    //---------------------------------------------------------------------
    public sealed class IntPatch_CSFunction : math_FunctionSetWithDerivatives
    {
        public IntPatch_CSFunction(Adaptor3d_HSurface S1, Adaptor2d_HCurve2d C, Adaptor3d_HSurface S2)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_CSFunction(IntPatch_CSFunction parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_CSFunction()
        {
            throw new NotImplementedException();
        }

        public int NbVariables()
        {
            throw new NotImplementedException();
        }

        public int NbEquations()
        {
            throw new NotImplementedException();
        }

        public bool Value(Vector X, Vector F)
        {
            throw new NotImplementedException();
        }

        public bool Derivatives(Vector X, math_Matrix D)
        {
            throw new NotImplementedException();
        }

        public bool Values(Vector X, Vector F, math_Matrix D)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Point()
        {
            throw new NotImplementedException();
        }

        public double Root()
        {
            throw new NotImplementedException();
        }

        public Adaptor3d_HSurface AuxillarSurface()
        {
            throw new NotImplementedException();
        }

        public Adaptor2d_HCurve2d AuxillarCurve()
        {
            throw new NotImplementedException();
        }
    }; // class IntPatch_CSFunction
}