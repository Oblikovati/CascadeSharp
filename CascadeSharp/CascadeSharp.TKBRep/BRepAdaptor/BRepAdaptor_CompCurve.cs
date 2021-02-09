//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepAdaptor_CompCurve
	//---------------------------------------------------------------------
	public  sealed class BRepAdaptor_CompCurve : CascadeSharp.Adaptor3d_Curve
	{

		public BRepAdaptor_CompCurve()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepAdaptor_CompCurve(TopoDS_Wire W, bool KnotByCurvilinearAbc_issa)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepAdaptor_CompCurve(TopoDS_Wire W)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepAdaptor_CompCurve(TopoDS_Wire W, bool KnotByCurvilinearAbc_issa, double First, double Last, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepAdaptor_CompCurve(BRepAdaptor_CompCurve parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Initialize(TopoDS_Wire W, bool KnotByCurvilinearAbc_issa)
		{
			throw new NotImplementedException();
		}

		public void Initialize(TopoDS_Wire W, bool KnotByCurvilinearAbc_issa, double First, double Last, double Tol)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire Wire()
		{
			throw new NotImplementedException();
		}

		public void Edge(double U, TopoDS_Edge E, ref double UonE)
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

		public CascadeSharp.GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public int NbIntervals(CascadeSharp.GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Intervals(TColStd_Array1OfReal T, CascadeSharp.GeomAbs_Shape S)
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

		public CascadeSharp.GeomAbs_CurveType GetGeomType()
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

		public void Prepare(ref double W, ref double D, ref int ind)
		{
			throw new NotImplementedException();
		}

		public void InvPrepare(int ind, ref double F, ref double D)
		{
			throw new NotImplementedException();
		}


	}; // class BRepAdaptor_CompCurve

}
