//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_CircularBlendFunc
	//---------------------------------------------------------------------
	public  sealed class GeomFill_CircularBlendFunc : CascadeSharp.Approx_SweepFunction
	{

		public GeomFill_CircularBlendFunc(Adaptor3d_HCurve Path, Adaptor3d_HCurve Curve1, Adaptor3d_HCurve Curve2, double Radius, bool Polynomial)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_CircularBlendFunc(Adaptor3d_HCurve Path, Adaptor3d_HCurve Curve1, Adaptor3d_HCurve Curve2, double Radius)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_CircularBlendFunc(GeomFill_CircularBlendFunc parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_CircularBlendFunc()
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

						public void Discret()
		{
			throw new NotImplementedException();
		}


	}; // class GeomFill_CircularBlendFunc

}
