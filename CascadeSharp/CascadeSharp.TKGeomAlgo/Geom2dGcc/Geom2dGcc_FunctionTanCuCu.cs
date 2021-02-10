//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2dAdaptor;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomAlgo.Geom2dGcc
{
    //---------------------------------------------------------------------
    //  Class  Geom2dGcc_FunctionTanCuCu
    //---------------------------------------------------------------------
    public sealed class Geom2dGcc_FunctionTanCuCu : math_FunctionSetWithDerivatives
    {
        public Geom2dGcc_FunctionTanCuCu(Geom2dAdaptor_Curve Curv1, Geom2dAdaptor_Curve Curv2)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuCu(gp_Circ2d Circ1, Geom2dAdaptor_Curve Curv2)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuCu(Geom2dGcc_FunctionTanCuCu parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuCu()
        {
            throw new NotImplementedException();
        }

        public void InitDerivative(math_Vector X, gp_Pnt2d Point1, gp_Pnt2d Point2, gp_Vec2d Tan1, gp_Vec2d Tan2,
            gp_Vec2d D21, gp_Vec2d D22)
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

        public bool Derivatives(math_Vector X, math_Matrix Deriv)
        {
            throw new NotImplementedException();
        }

        public bool Values(math_Vector X, math_Vector F, math_Matrix Deriv)
        {
            throw new NotImplementedException();
        }
    }; // class Geom2dGcc_FunctionTanCuCu
}