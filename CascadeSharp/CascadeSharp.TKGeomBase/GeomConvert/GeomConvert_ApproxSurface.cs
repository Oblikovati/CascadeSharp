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
    //  Class  GeomConvert_ApproxSurface
    //---------------------------------------------------------------------
    public sealed class GeomConvert_ApproxSurface
    {
        public GeomConvert_ApproxSurface(Geom_Surface Surf, double Tol3d, GeomAbs_Shape UContinuity,
            GeomAbs_Shape VContinuity, int MaxDegU, int MaxDegV, int MaxSegments, int Prec_isCode)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomConvert_ApproxSurface(Adaptor3d_HSurface Surf, double Tol3d, GeomAbs_Shape UContinuity,
            GeomAbs_Shape VContinuity, int MaxDegU, int MaxDegV, int MaxSegments, int Prec_isCode)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomConvert_ApproxSurface(GeomConvert_ApproxSurface parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomConvert_ApproxSurface()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface Surface()
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

        public void Approximate(Adaptor3d_HSurface theSurf, double theTol3d, GeomAbs_Shape theUContinuity,
            GeomAbs_Shape theVContinuity, int theMaxDegU, int theMaxDegV, int theMaxSegments, int thePrec_isCode)
        {
            throw new NotImplementedException();
        }
    }; // class GeomConvert_ApproxSurface
}