//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKOffset.BiTgte
{
    //---------------------------------------------------------------------
    //  Class  BiTgte_CurveOnEdge
    //---------------------------------------------------------------------
    public sealed class BiTgte_CurveOnEdge : Adaptor3d_Curve
    {
        public BiTgte_CurveOnEdge()
            : base()
        {
            throw new NotImplementedException();
        }

        public BiTgte_CurveOnEdge(TopoDS_Edge EonF, TopoDS_Edge Edge)
            : base()
        {
            throw new NotImplementedException();
        }

        public BiTgte_CurveOnEdge(BiTgte_CurveOnEdge parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Edge EonF, TopoDS_Edge Edge)
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

        public Adaptor3d_HCurve Trim(double First, double Last, double Tol)
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

        public gp_Pnt Value(double U)
        {
            throw new NotImplementedException();
        }

        public void D0(double U, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, gp_Pnt P, gp_Vec V)
        {
            throw new NotImplementedException();
        }

        public void D2(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2)
        {
            throw new NotImplementedException();
        }

        public void D3(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2, gp_Vec V3)
        {
            throw new NotImplementedException();
        }

        public gp_Vec DN(double U, int N)
        {
            throw new NotImplementedException();
        }

        public double Resolution(double R3d)
        {
            throw new NotImplementedException();
        }

        public GeomAbs_CurveType GetGeomType()
        {
            throw new NotImplementedException();
        }

        public gp_Lin Line()
        {
            throw new NotImplementedException();
        }

        public gp_Circ Circle()
        {
            throw new NotImplementedException();
        }

        public gp_Elips Ellipse()
        {
            throw new NotImplementedException();
        }

        public gp_Hypr Hyperbola()
        {
            throw new NotImplementedException();
        }

        public gp_Parab Parabola()
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

        public Geom_BezierCurve Bezier()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve BSpline()
        {
            throw new NotImplementedException();
        }
    }; // class BiTgte_CurveOnEdge
}