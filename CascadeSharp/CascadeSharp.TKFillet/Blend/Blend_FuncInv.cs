//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKFillet.Blend
{
    //---------------------------------------------------------------------
    //  Class  Blend_FuncInv
    //---------------------------------------------------------------------
    public abstract class Blend_FuncInv : math_FunctionSetWithDerivatives
    {
        public Blend_FuncInv()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Blend_FuncInv(Blend_FuncInv parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
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
    }; // class Blend_FuncInv
}