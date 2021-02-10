//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomBase.GeomLib
{
    //---------------------------------------------------------------------
    //  Class  GeomLib_Interpolate
    //---------------------------------------------------------------------
    public sealed class GeomLib_Interpolate
    {
        public GeomLib_Interpolate(int Degree, int NumPoints, TColgp_Array1OfPnt Points,
            TColStd_Array1OfReal Parameters)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomLib_Interpolate(GeomLib_Interpolate parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomLib_Interpolate()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public GeomLib_InterpolationErrors Error()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve Curve()
        {
            throw new NotImplementedException();
        }
    }; // class GeomLib_Interpolate
}