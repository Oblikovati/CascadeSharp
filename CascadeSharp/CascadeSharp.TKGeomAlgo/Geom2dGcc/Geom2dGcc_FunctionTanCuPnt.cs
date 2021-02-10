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
    //  Class  Geom2dGcc_FunctionTanCuPnt
    //---------------------------------------------------------------------
    public sealed class Geom2dGcc_FunctionTanCuPnt : math_FunctionWithDerivative
    {
        public Geom2dGcc_FunctionTanCuPnt(Geom2dAdaptor_Curve C, gp_Pnt2d Point)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuPnt(Geom2dGcc_FunctionTanCuPnt parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuPnt()
        {
            throw new NotImplementedException();
        }

        public bool Value(double X, ref double F)
        {
            throw new NotImplementedException();
        }

        public bool Derivative(double X, ref double Deriv)
        {
            throw new NotImplementedException();
        }

        public bool Values(double X, ref double F, ref double Deriv)
        {
            throw new NotImplementedException();
        }
    }; // class Geom2dGcc_FunctionTanCuPnt
}