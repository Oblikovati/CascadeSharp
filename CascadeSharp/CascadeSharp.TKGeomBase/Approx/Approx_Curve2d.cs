//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKGeomBase.Approx
{
    //---------------------------------------------------------------------
    //  Class  Approx_Curve2d
    //---------------------------------------------------------------------
    public sealed class Approx_Curve2d
    {
        public Approx_Curve2d(Adaptor2d_HCurve2d C2D, double First, double Last, double TolU, double TolV,
            GeomAbs_Shape Continuity, int MaxDegree, int MaxSegments)
            : base()
        {
            throw new NotImplementedException();
        }

        public Approx_Curve2d(Approx_Curve2d parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Approx_Curve2d()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public bool HasResult()
        {
            throw new NotImplementedException();
        }

        public Geom2d_BSplineCurve Curve()
        {
            throw new NotImplementedException();
        }

        public double MaxError2dU()
        {
            throw new NotImplementedException();
        }

        public double MaxError2dV()
        {
            throw new NotImplementedException();
        }
    }; // class Approx_Curve2d
}