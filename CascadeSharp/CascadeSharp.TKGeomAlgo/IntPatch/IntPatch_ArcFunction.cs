//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKGeomAlgo.IntSurf;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
    //---------------------------------------------------------------------
    //  Class  IntPatch_ArcFunction
    //---------------------------------------------------------------------
    public sealed class IntPatch_ArcFunction : math_FunctionWithDerivative
    {
        public IntPatch_ArcFunction()
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_ArcFunction(IntPatch_ArcFunction parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void SetQuadric(IntSurf_Quadric Q)
        {
            throw new NotImplementedException();
        }

        public void Set(Adaptor2d_HCurve2d A)
        {
            throw new NotImplementedException();
        }

        public void Set(Adaptor3d_HSurface S)
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

        public int NbSamples()
        {
            throw new NotImplementedException();
        }

        public int GetStateNumber()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Valpoint(int Index)
        {
            throw new NotImplementedException();
        }

        public IntSurf_Quadric Quadric()
        {
            throw new NotImplementedException();
        }

        public Adaptor2d_HCurve2d Arc()
        {
            throw new NotImplementedException();
        }

        public Adaptor3d_HSurface Surface()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt LastComputedPoint()
        {
            throw new NotImplementedException();
        }
    }; // class IntPatch_ArcFunction
}