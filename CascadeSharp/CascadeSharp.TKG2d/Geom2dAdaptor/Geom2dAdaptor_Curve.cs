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

namespace CascadeSharp.TKG2d.Geom2dAdaptor
{
    //---------------------------------------------------------------------
    //  Class  Geom2dAdaptor_Curve
    //---------------------------------------------------------------------
    public class Geom2dAdaptor_Curve : Adaptor2d_Curve2d
    {
        public Geom2dAdaptor_Curve()
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dAdaptor_Curve(Geom2d_Curve C)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dAdaptor_Curve(Geom2d_Curve C, double UFirst, double ULast)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dAdaptor_Curve(Geom2dAdaptor_Curve parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Load(Geom2d_Curve C)
        {
            throw new NotImplementedException();
        }

        public void Load(Geom2d_Curve C, double UFirst, double ULast)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve Curve()
        {
            throw new NotImplementedException();
        }

        public double FirstParameter()
        {
            throw new NotImplementedException();
        }

        public double LastParameter()
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity()
        {
            throw new NotImplementedException();
        }

        public int NbIntervals(GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public void Intervals(TColStd_Array1OfReal T, GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public Adaptor2d_HCurve2d Trim(double First, double Last, double Tol)
        {
            throw new NotImplementedException();
        }

        public bool IsClosed()
        {
            throw new NotImplementedException();
        }

        public bool IsPeriodic()
        {
            throw new NotImplementedException();
        }

        public double Period()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d Value(double U)
        {
            throw new NotImplementedException();
        }

        public void D0(double U, gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, gp_Pnt2d P, gp_Vec2d V)
        {
            throw new NotImplementedException();
        }

        public void D2(double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2)
        {
            throw new NotImplementedException();
        }

        public void D3(double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, gp_Vec2d V3)
        {
            throw new NotImplementedException();
        }

        public gp_Vec2d DN(double U, int N)
        {
            throw new NotImplementedException();
        }

        public double Resolution(double Ruv)
        {
            throw new NotImplementedException();
        }

        public GeomAbs_CurveType GetGeomType()
        {
            throw new NotImplementedException();
        }

        public gp_Lin2d Line()
        {
            throw new NotImplementedException();
        }

        public gp_Circ2d Circle()
        {
            throw new NotImplementedException();
        }

        public gp_Elips2d Ellipse()
        {
            throw new NotImplementedException();
        }

        public gp_Hypr2d Hyperbola()
        {
            throw new NotImplementedException();
        }

        public gp_Parab2d Parabola()
        {
            throw new NotImplementedException();
        }

        public int Degree()
        {
            throw new NotImplementedException();
        }

        public bool IsRational()
        {
            throw new NotImplementedException();
        }

        public int NbPoles()
        {
            throw new NotImplementedException();
        }

        public int NbKnots()
        {
            throw new NotImplementedException();
        }

        public int NbSamples()
        {
            throw new NotImplementedException();
        }

        public Geom2d_BezierCurve Bezier()
        {
            throw new NotImplementedException();
        }

        public Geom2d_BSplineCurve BSpline()
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape LocalContinuity(double U1, double U2)
        {
            throw new NotImplementedException();
        }

        public void load(Geom2d_Curve C, double UFirst, double ULast)
        {
            throw new NotImplementedException();
        }

        public bool IsBoundary(double theU, ref int theSpanStart, ref int theSpanFin_ish)
        {
            throw new NotImplementedException();
        }

        public void RebuildCache(double theParameter)
        {
            throw new NotImplementedException();
        }
    }; // class Geom2dAdaptor_Curve
}