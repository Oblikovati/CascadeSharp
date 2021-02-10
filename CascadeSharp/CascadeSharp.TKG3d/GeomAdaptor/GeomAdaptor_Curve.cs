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

namespace CascadeSharp.TKG3d.GeomAdaptor
{
	//---------------------------------------------------------------------
	//  Class  GeomAdaptor_Curve
	//---------------------------------------------------------------------
	public  sealed class GeomAdaptor_Curve : Adaptor3d_Curve
	{

		public GeomAdaptor_Curve()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAdaptor_Curve(Geom_Curve C)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAdaptor_Curve(Geom_Curve C, double UFirst, double ULast)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomAdaptor_Curve(GeomAdaptor_Curve parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}

		public void Load(Geom_Curve C)
		{
			throw new NotImplementedException();
		}

		public void Load(Geom_Curve C, double UFirst, double ULast)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve Curve()
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

		public Geom_OffsetCurve OffsetCurve()
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape LocalContinuity(double U1, double U2)
		{
			throw new NotImplementedException();
		}

		public void load(Geom_Curve C, double UFirst, double ULast)
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


	}; // class GeomAdaptor_Curve

}
