//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.AdvApprox;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomBase.Approx
{
	//---------------------------------------------------------------------
	//  Class  Approx_SweepApproximation
	//---------------------------------------------------------------------
	public  sealed class Approx_SweepApproximation
	{

		public Approx_SweepApproximation(Approx_SweepFunction Func)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_SweepApproximation(Approx_SweepApproximation parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_SweepApproximation()
		{
			throw new NotImplementedException();
		}

		public void Perform(double First, double Last, double Tol3d, double BoundTol, double Tol2d, double TolAngular, GeomAbs_Shape Continuity, int Degmax, int Segmax)
		{
			throw new NotImplementedException();
		}

		public void Perform(double First, double Last, double Tol3d, double BoundTol, double Tol2d, double TolAngular, GeomAbs_Shape Continuity, int Degmax)
		{
			throw new NotImplementedException();
		}

		public void Perform(double First, double Last, double Tol3d, double BoundTol, double Tol2d, double TolAngular, GeomAbs_Shape Continuity)
		{
			throw new NotImplementedException();
		}

		public void Perform(double First, double Last, double Tol3d, double BoundTol, double Tol2d, double TolAngular)
		{
			throw new NotImplementedException();
		}

		public int Eval(double Parameter, int DerivativeRequest, double First, double Last, ref double Result)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public void SurfShape(ref int UDegree, ref int VDegree, ref int NbUPoles, ref int NbVPoles, ref int NbUKnots, ref int NbVKnots)
		{
			throw new NotImplementedException();
		}

		public void Surface(TColgp_Array2OfPnt TPoles, TColStd_Array2OfReal TWeights, TColStd_Array1OfReal TUKnots, TColStd_Array1OfReal TVKnots, TColStd_Array1OfInteger TUMults, TColStd_Array1OfInteger TVMults)
		{
			throw new NotImplementedException();
		}

		public int UDegree()
		{
			throw new NotImplementedException();
		}

		public int VDegree()
		{
			throw new NotImplementedException();
		}

		public TColgp_Array2OfPnt SurfPoles()
		{
			throw new NotImplementedException();
		}

		public TColStd_Array2OfReal SurfWeights()
		{
			throw new NotImplementedException();
		}

		public TColStd_Array1OfReal SurfUKnots()
		{
			throw new NotImplementedException();
		}

		public TColStd_Array1OfReal SurfVKnots()
		{
			throw new NotImplementedException();
		}

		public TColStd_Array1OfInteger SurfUMults()
		{
			throw new NotImplementedException();
		}

		public TColStd_Array1OfInteger SurfVMults()
		{
			throw new NotImplementedException();
		}

		public double MaxErrorOnSurf()
		{
			throw new NotImplementedException();
		}

		public double AverageErrorOnSurf()
		{
			throw new NotImplementedException();
		}

		public int NbCurves2d()
		{
			throw new NotImplementedException();
		}

		public void Curves2dShape(ref int Degree, ref int NbPoles, ref int NbKnots)
		{
			throw new NotImplementedException();
		}

		public void Curve2d(int Index, TColgp_Array1OfPnt2d TPoles, TColStd_Array1OfReal TKnots, TColStd_Array1OfInteger TMults)
		{
			throw new NotImplementedException();
		}

		public int Curves2dDegree()
		{
			throw new NotImplementedException();
		}

		public TColgp_Array1OfPnt2d Curve2dPoles(int Index)
		{
			throw new NotImplementedException();
		}

		public TColStd_Array1OfReal Curves2dKnots()
		{
			throw new NotImplementedException();
		}

		public TColStd_Array1OfInteger Curves2dMults()
		{
			throw new NotImplementedException();
		}

		public double Max2dError(int Index)
		{
			throw new NotImplementedException();
		}

		public double Average2dError(int Index)
		{
			throw new NotImplementedException();
		}

		public double TolCurveOnSurf(int Index)
		{
			throw new NotImplementedException();
		}

				public void Approximation(TColStd_HArray1OfReal OneDTol, TColStd_HArray1OfReal TwoDTol, TColStd_HArray1OfReal ThreeDTol, double BounTol, double First, double Last, GeomAbs_Shape Continuity, int Degmax, int Segmax, AdvApprox_EvaluatorFunction TheApproxFunction, AdvApprox_Cutting TheCuttingTool)
		{
			throw new NotImplementedException();
		}

		public bool D0(double Param, double First, double Last, ref double Result)
		{
			throw new NotImplementedException();
		}

		public bool D1(double Param, double First, double Last, ref double Result)
		{
			throw new NotImplementedException();
		}

		public bool D2(double Param, double First, double Last, ref double Result)
		{
			throw new NotImplementedException();
		}


	}; // class Approx_SweepApproximation

}
