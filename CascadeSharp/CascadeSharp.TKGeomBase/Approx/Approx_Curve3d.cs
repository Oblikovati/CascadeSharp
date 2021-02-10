//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKGeomBase.Approx
{
    //---------------------------------------------------------------------
    //  Class  Approx_Curve3d
    //---------------------------------------------------------------------
    public sealed class Approx_Curve3d
    {
        public Approx_Curve3d(Adaptor3d_HCurve Curve, double Tol3d, GeomAbs_Shape Order, int MaxSegments, int MaxDegree)
            : base()
        {
            throw new NotImplementedException();
        }

        public Approx_Curve3d(Approx_Curve3d parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Approx_Curve3d()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve Curve()
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

        public double MaxError()
        {
            throw new NotImplementedException();
        }
    }; // class Approx_Curve3d
}