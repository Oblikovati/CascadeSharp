//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomBase.GeomLib
{
    //---------------------------------------------------------------------
    //  Class  GeomLib_PolyFunc
    //---------------------------------------------------------------------
    public sealed class GeomLib_PolyFunc : math_FunctionWithDerivative
    {
        public GeomLib_PolyFunc(Vector Coeffs)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomLib_PolyFunc(GeomLib_PolyFunc parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomLib_PolyFunc()
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
    }; // class GeomLib_PolyFunc
}