//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Adaptor3d
{
	//---------------------------------------------------------------------
	//  Class  Adaptor3d_CurveOnSurface
	//---------------------------------------------------------------------
	public  sealed class Adaptor3d_CurveOnSurface : Adaptor3d_Curve
	{

		public Adaptor3d_CurveOnSurface()
			: base()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_CurveOnSurface(Adaptor3d_HSurface S)
			: base()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_CurveOnSurface(Adaptor2d_HCurve2d C, Adaptor3d_HSurface S)
			: base()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_CurveOnSurface(Adaptor3d_CurveOnSurface parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Load(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public void Load(Adaptor2d_HCurve2d C)
		{
			throw new NotImplementedException();
		}

		public void Load(Adaptor2d_HCurve2d C, Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public Adaptor2d_HCurve2d GetCurve()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HSurface GetSurface()
		{
			throw new NotImplementedException();
		}

		public Adaptor2d_HCurve2d ChangeCurve()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HSurface ChangeSurface()
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

		public void EvalKPart()
		{
			throw new NotImplementedException();
		}

		public void EvalFirstLastSurf()
		{
			throw new NotImplementedException();
		}

		public void LocatePart(gp_Pnt2d UV, gp_Vec2d DUV, Adaptor3d_HSurface S, gp_Pnt2d LeftBot, gp_Pnt2d RightTop)
		{
			throw new NotImplementedException();
		}

		public bool LocatePart_RevExt(gp_Pnt2d UV, gp_Vec2d DUV, Adaptor3d_HSurface S, gp_Pnt2d LeftBot, gp_Pnt2d RightTop)
		{
			throw new NotImplementedException();
		}

		public bool LocatePart_Offset(gp_Pnt2d UV, gp_Vec2d DUV, Adaptor3d_HSurface S, gp_Pnt2d LeftBot, gp_Pnt2d RightTop)
		{
			throw new NotImplementedException();
		}

		public void FindBounds(TColStd_Array1OfReal Arr, double XYComp, double DUVComp, ref int Bnd1, ref int Bnd2, ref bool DerIsNull)
		{
			throw new NotImplementedException();
		}


	}; // class Adaptor3d_CurveOnSurface

}
