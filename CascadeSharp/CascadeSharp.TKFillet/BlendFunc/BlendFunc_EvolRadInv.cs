//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKFillet.Blend;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKGeomAlgo.Law;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKFillet.BlendFunc
{
    //---------------------------------------------------------------------
    //  Class  BlendFunc_EvolRadInv
    //---------------------------------------------------------------------
    public sealed class BlendFunc_EvolRadInv : Blend_FuncInv
    {
        public BlendFunc_EvolRadInv(Adaptor3d_HSurface S1, Adaptor3d_HSurface S2, Adaptor3d_HCurve C, Law_Function Law)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_EvolRadInv(BlendFunc_EvolRadInv parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_EvolRadInv()
        {
            throw new NotImplementedException();
        }

        public void Set(bool OnFirst, Adaptor2d_HCurve2d COnSurf)
        {
            throw new NotImplementedException();
        }

        public void GetTolerance(Vector Tolerance, double Tol)
        {
            throw new NotImplementedException();
        }

        public void GetBounds(Vector InfBound, Vector SupBound)
        {
            throw new NotImplementedException();
        }

        public bool IsSolution(Vector Sol, double Tol)
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

        public void Set(int Choix)
        {
            throw new NotImplementedException();
        }
    }; // class BlendFunc_EvolRadInv
}