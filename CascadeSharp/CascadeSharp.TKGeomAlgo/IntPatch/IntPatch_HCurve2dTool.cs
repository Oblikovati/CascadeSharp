//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
    //---------------------------------------------------------------------
    //  Class  IntPatch_HCurve2dTool
    //---------------------------------------------------------------------
    public sealed class IntPatch_HCurve2dTool
    {
        public IntPatch_HCurve2dTool()
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_HCurve2dTool(IntPatch_HCurve2dTool parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public double FirstParameter(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public double LastParameter(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public int NbIntervals(Adaptor2d_HCurve2d C, GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public void Intervals(Adaptor2d_HCurve2d C, TColStd_Array1OfReal T, GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public bool IsClosed(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public bool IsPeriodic(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public double Period(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d Value(Adaptor2d_HCurve2d C, double U)
        {
            throw new NotImplementedException();
        }

        public void D0(Adaptor2d_HCurve2d C, double U, gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public void D1(Adaptor2d_HCurve2d C, double U, gp_Pnt2d P, gp_Vec2d V)
        {
            throw new NotImplementedException();
        }

        public void D2(Adaptor2d_HCurve2d C, double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2)
        {
            throw new NotImplementedException();
        }

        public void D3(Adaptor2d_HCurve2d C, double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, gp_Vec2d V3)
        {
            throw new NotImplementedException();
        }

        public gp_Vec2d DN(Adaptor2d_HCurve2d C, double U, int N)
        {
            throw new NotImplementedException();
        }

        public double Resolution(Adaptor2d_HCurve2d C, double R3d)
        {
            throw new NotImplementedException();
        }

        public GeomAbs_CurveType GetGeomType(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public gp_Lin2d Line(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public gp_Circ2d Circle(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public gp_Elips2d Ellipse(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public gp_Hypr2d Hyperbola(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public gp_Parab2d Parabola(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public Geom2d_BezierCurve Bezier(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public Geom2d_BSplineCurve BSpline(Adaptor2d_HCurve2d C)
        {
            throw new NotImplementedException();
        }

        public int NbSamples(Adaptor2d_HCurve2d C, double U0, double U1)
        {
            throw new NotImplementedException();
        }
    }; // class IntPatch_HCurve2dTool
}