//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKGeomBase.AppParCurves;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomBase.ProjLib
{
	//---------------------------------------------------------------------
	//  Class  ProjLib_ProjectedCurve
	//---------------------------------------------------------------------
	public  sealed class ProjLib_ProjectedCurve : Adaptor2d_Curve2d
	{

		public ProjLib_ProjectedCurve()
			: base()
		{
			throw new NotImplementedException();
		}

		public ProjLib_ProjectedCurve(Adaptor3d_HSurface S)
			: base()
		{
			throw new NotImplementedException();
		}

		public ProjLib_ProjectedCurve(Adaptor3d_HSurface S, Adaptor3d_HCurve C)
			: base()
		{
			throw new NotImplementedException();
		}

		public ProjLib_ProjectedCurve(Adaptor3d_HSurface S, Adaptor3d_HCurve C, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public ProjLib_ProjectedCurve(ProjLib_ProjectedCurve parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Load(double Tolerance)
		{
			throw new NotImplementedException();
		}

		public void Load(Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HCurve C)
		{
			throw new NotImplementedException();
		}

		public void SetDegree(int theDegMin, int theDegMax)
		{
			throw new NotImplementedException();
		}

		public void SetMaxSegments(int theMaxSegments)
		{
			throw new NotImplementedException();
		}

		public void SetBndPnt(AppParCurves_Constraint theBndPnt)
		{
			throw new NotImplementedException();
		}

		public void SetMaxDist(double theMaxD_ist)
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HSurface GetSurface()
		{
			throw new NotImplementedException();
		}

		public Adaptor3d_HCurve GetCurve()
		{
			throw new NotImplementedException();
		}

		public double GetTolerance()
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

		public double Resolution(double R3d)
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

		public Geom2d_BezierCurve Bezier()
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve BSpline()
		{
			throw new NotImplementedException();
		}


	}; // class ProjLib_ProjectedCurve

}
