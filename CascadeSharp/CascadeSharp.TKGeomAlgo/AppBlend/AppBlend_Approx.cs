//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomAlgo.AppBlend
{
	//---------------------------------------------------------------------
	//  Class  AppBlend_Approx
	//---------------------------------------------------------------------
	public  abstract class AppBlend_Approx
	{

		public AppBlend_Approx()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public AppBlend_Approx(AppBlend_Approx parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
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

		public void TolReached(ref double Tol3d, ref double Tol2d)
		{
			throw new NotImplementedException();
		}

		public double TolCurveOnSurf(int Index)
		{
			throw new NotImplementedException();
		}


	}; // class AppBlend_Approx

}
