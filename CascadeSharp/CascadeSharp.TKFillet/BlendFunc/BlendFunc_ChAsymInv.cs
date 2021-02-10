//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKFillet.Blend;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKFillet.BlendFunc
{
    //---------------------------------------------------------------------
    //  Class  BlendFunc_ChAsymInv
    //---------------------------------------------------------------------
    public sealed class BlendFunc_ChAsymInv : Blend_FuncInv
    {
        public BlendFunc_ChAsymInv(Adaptor3d_HSurface S1, Adaptor3d_HSurface S2, Adaptor3d_HCurve C)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_ChAsymInv(BlendFunc_ChAsymInv parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_ChAsymInv()
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

        public bool ComputeValues(Vector X, int DegF, int DegL)
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

        public void Set(double D_ist1, double Angle, int Choix)
        {
            throw new NotImplementedException();
        }
    }; // class BlendFunc_ChAsymInv
}