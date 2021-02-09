//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Adaptor2d_Curve2d
	//---------------------------------------------------------------------
	public  class Adaptor2d_Curve2d
	{

		public Adaptor2d_Curve2d(Adaptor2d_Curve2d parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Adaptor2d_Curve2d()
			: base()
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

		public double Resolution(double R3d)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_CurveType GetGeomType()
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


	}; // class Adaptor2d_Curve2d

}
