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
    //  Class  Geom2dGcc_FunctionTanObl
    //---------------------------------------------------------------------
    public sealed class Geom2dGcc_FunctionTanObl : math_FunctionWithDerivative
    {
        public Geom2dGcc_FunctionTanObl(Geom2dAdaptor_Curve Curve, gp_Dir2d Dir)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanObl(Geom2dGcc_FunctionTanObl parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanObl()
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
    }; // class Geom2dGcc_FunctionTanObl
}