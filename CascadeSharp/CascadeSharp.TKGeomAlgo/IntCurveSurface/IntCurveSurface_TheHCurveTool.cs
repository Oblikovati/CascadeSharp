//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.IntCurveSurface
{
    //---------------------------------------------------------------------
    //  Class  IntCurveSurface_TheHCurveTool
    //---------------------------------------------------------------------
    public sealed class IntCurveSurface_TheHCurveTool
    {
        public IntCurveSurface_TheHCurveTool()
            : base()
        {
            throw new NotImplementedException();
        }

        public IntCurveSurface_TheHCurveTool(IntCurveSurface_TheHCurveTool parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public double FirstParameter(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public double LastParameter(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public int NbIntervals(Adaptor3d_HCurve C, GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public void Intervals(Adaptor3d_HCurve C, TColStd_Array1OfReal T, GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool IsClosed(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public bool IsPeriodic(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public double Period(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Value(Adaptor3d_HCurve C, double U)
        {
            throw new NotImplementedException();
        }

        public void D0(Adaptor3d_HCurve C, double U, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void D1(Adaptor3d_HCurve C, double U, gp_Pnt P, gp_Vec V)
        {
            throw new NotImplementedException();
        }

        public void D2(Adaptor3d_HCurve C, double U, gp_Pnt P, gp_Vec V1, gp_Vec V2)
        {
            throw new NotImplementedException();
        }

        public void D3(Adaptor3d_HCurve C, double U, gp_Pnt P, gp_Vec V1, gp_Vec V2, gp_Vec V3)
        {
            throw new NotImplementedException();
        }

        public gp_Vec DN(Adaptor3d_HCurve C, double U, int N)
        {
            throw new NotImplementedException();
        }

        public double Resolution(Adaptor3d_HCurve C, double R3d)
        {
            throw new NotImplementedException();
        }

        public GeomAbs_CurveType GetGeomType(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public gp_Lin Line(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public gp_Circ Circle(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public gp_Elips Ellipse(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public gp_Hypr Hyperbola(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public gp_Parab Parabola(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public Geom_BezierCurve Bezier(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve BSpline(Adaptor3d_HCurve C)
        {
            throw new NotImplementedException();
        }

        public int NbSamples(Adaptor3d_HCurve C, double U0, double U1)
        {
            throw new NotImplementedException();
        }

        public void SamplePars(Adaptor3d_HCurve C, double U0, double U1, double Defl, int NbMin,
            TColStd_HArray1OfReal Pars)
        {
            throw new NotImplementedException();
        }
    }; // class IntCurveSurface_TheHCurveTool
}