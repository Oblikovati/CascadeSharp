//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
    //---------------------------------------------------------------------
    //  Class  GeomFill_FunctionDraft
    //---------------------------------------------------------------------
    public sealed class GeomFill_FunctionDraft : math_FunctionSetWithDerivatives
    {
        public GeomFill_FunctionDraft(Adaptor3d_HSurface S, Adaptor3d_HCurve C)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_FunctionDraft(GeomFill_FunctionDraft parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_FunctionDraft()
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

        public bool Value(math_Vector X, math_Vector F)
        {
            throw new NotImplementedException();
        }

        public bool Derivatives(math_Vector X, math_Matrix D)
        {
            throw new NotImplementedException();
        }

        public bool Values(math_Vector X, math_Vector F, math_Matrix D)
        {
            throw new NotImplementedException();
        }

        public bool DerivT(Adaptor3d_HCurve C, double Param, double W, gp_Vec dN, double teta, math_Vector F)
        {
            throw new NotImplementedException();
        }

        public bool Deriv2T(Adaptor3d_HCurve C, double Param, double W, gp_Vec d2N, double teta, math_Vector F)
        {
            throw new NotImplementedException();
        }

        public bool DerivTX(gp_Vec dN, double teta, math_Matrix D)
        {
            throw new NotImplementedException();
        }

        public bool Deriv2X(math_Vector X, GeomFill_Tensor T)
        {
            throw new NotImplementedException();
        }
    }; // class GeomFill_FunctionDraft
}