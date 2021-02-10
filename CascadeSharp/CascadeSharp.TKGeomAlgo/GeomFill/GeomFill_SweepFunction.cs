//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_SweepFunction
	//---------------------------------------------------------------------
	public  sealed class GeomFill_SweepFunction : CascadeSharp.Approx_SweepFunction
	{

		public GeomFill_SweepFunction(GeomFill_SectionLaw Section, GeomFill_LocationLaw Location, double FirstParameter, double FirstParameterOnS, double RatioParameterOnS)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SweepFunction(GeomFill_SweepFunction parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SweepFunction()
		{
			throw new NotImplementedException();
		}

		public bool D0(double Param, double First, double Last, TColgp_Array1OfPnt Poles, TColgp_Array1OfPnt2d Poles2d, TColStd_Array1OfReal Weigths)
		{
			throw new NotImplementedException();
		}

		public bool D1(double Param, double First, double Last, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles, TColgp_Array1OfPnt2d Poles2d, TColgp_Array1OfVec2d DPoles2d, TColStd_Array1OfReal Weigths, TColStd_Array1OfReal DWeigths)
		{
			throw new NotImplementedException();
		}

		public bool D2(double Param, double First, double Last, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles, TColgp_Array1OfVec D2Poles, TColgp_Array1OfPnt2d Poles2d, TColgp_Array1OfVec2d DPoles2d, TColgp_Array1OfVec2d D2Poles2d, TColStd_Array1OfReal Weigths, TColStd_Array1OfReal DWeigths, TColStd_Array1OfReal D2Weigths)
		{
			throw new NotImplementedException();
		}

		public int Nb2dCurves()
		{
			throw new NotImplementedException();
		}

		public void SectionShape(ref int NbPoles, ref int NbKnots, ref int Degree)
		{
			throw new NotImplementedException();
		}

		public void Knots(TColStd_Array1OfReal TKnots)
		{
			throw new NotImplementedException();
		}

		public void Mults(TColStd_Array1OfInteger TMults)
		{
			throw new NotImplementedException();
		}

		public bool IsRational()
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

		public void SetInterval(double First, double Last)
		{
			throw new NotImplementedException();
		}

		public void Resolution(int Index, double Tol, ref double TolU, ref double TolV)
		{
			throw new NotImplementedException();
		}

		public void GetTolerance(double BoundTol, double SurfTol, double AngleTol, TColStd_Array1OfReal Tol3d)
		{
			throw new NotImplementedException();
		}

		public void SetTolerance(double Tol3d, double Tol2d)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt BarycentreOfSurf()
		{
			throw new NotImplementedException();
		}

		public double MaximalSection()
		{
			throw new NotImplementedException();
		}

		public void GetMinimalWeight(TColStd_Array1OfReal Weigths)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class GeomFill_SweepFunction

}
