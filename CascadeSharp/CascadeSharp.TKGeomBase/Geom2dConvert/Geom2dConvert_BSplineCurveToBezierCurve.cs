//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG2d.TColGeom2d;

namespace CascadeSharp.TKGeomBase.Geom2dConvert
{
    //---------------------------------------------------------------------
    //  Class  Geom2dConvert_BSplineCurveToBezierCurve
    //---------------------------------------------------------------------
    public sealed class Geom2dConvert_BSplineCurveToBezierCurve
    {
        public Geom2dConvert_BSplineCurveToBezierCurve(Geom2d_BSplineCurve Bas_isCurve)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dConvert_BSplineCurveToBezierCurve(Geom2d_BSplineCurve Bas_isCurve, double U1, double U2,
            double ParametricTolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dConvert_BSplineCurveToBezierCurve(Geom2dConvert_BSplineCurveToBezierCurve parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dConvert_BSplineCurveToBezierCurve()
        {
            throw new NotImplementedException();
        }

        public Geom2d_BezierCurve Arc(int Index)
        {
            throw new NotImplementedException();
        }

        public void Arcs(TColGeom2d_Array1OfBezierCurve Curves)
        {
            throw new NotImplementedException();
        }

        public void Knots(TColStd_Array1OfReal TKnots)
        {
            throw new NotImplementedException();
        }

        public int NbArcs()
        {
            throw new NotImplementedException();
        }
    }; // class Geom2dConvert_BSplineCurveToBezierCurve
}