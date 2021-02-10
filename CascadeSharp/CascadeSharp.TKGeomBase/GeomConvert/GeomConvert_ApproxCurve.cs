//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKGeomBase.GeomConvert
{
    //---------------------------------------------------------------------
    //  Class  GeomConvert_ApproxCurve
    //---------------------------------------------------------------------
    public sealed class GeomConvert_ApproxCurve
    {
        public GeomConvert_ApproxCurve(Geom_Curve Curve, double Tol3d, GeomAbs_Shape Order, int MaxSegments,
            int MaxDegree)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomConvert_ApproxCurve(Adaptor3d_HCurve Curve, double Tol3d, GeomAbs_Shape Order, int MaxSegments,
            int MaxDegree)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomConvert_ApproxCurve(GeomConvert_ApproxCurve parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomConvert_ApproxCurve()
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

        public void Approximate(Adaptor3d_HCurve theCurve, double theTol3d, GeomAbs_Shape theOrder, int theMaxSegments,
            int theMaxDegree)
        {
            throw new NotImplementedException();
        }
    }; // class GeomConvert_ApproxCurve
}