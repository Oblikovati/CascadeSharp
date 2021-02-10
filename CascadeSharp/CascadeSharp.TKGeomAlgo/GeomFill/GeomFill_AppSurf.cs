//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKGeomAlgo.AppBlend;
using CascadeSharp.TKGeomBase.Approx;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_AppSurf
	//---------------------------------------------------------------------
	public  sealed class GeomFill_AppSurf : AppBlend_Approx
	{

		public GeomFill_AppSurf()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_AppSurf(int Degmin, int Degmax, double Tol3d, double Tol2d, int NbIt, bool KnownParameters)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_AppSurf(int Degmin, int Degmax, double Tol3d, double Tol2d, int NbIt)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_AppSurf(GeomFill_AppSurf parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(int Degmin, int Degmax, double Tol3d, double Tol2d, int NbIt, bool KnownParameters)
		{
			throw new NotImplementedException();
		}

		public void Init(int Degmin, int Degmax, double Tol3d, double Tol2d, int NbIt)
		{
			throw new NotImplementedException();
		}

		public void SetParType(Approx_ParametrizationType ParType)
		{
			throw new NotImplementedException();
		}

		public void SetContinuity(GeomAbs_Shape C)
		{
			throw new NotImplementedException();
		}

		public void SetCriteriumWeight(double W1, double W2, double W3)
		{
			throw new NotImplementedException();
		}

		public Approx_ParametrizationType ParType()
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public void CriteriumWeight(ref double W1, ref double W2, ref double W3)
		{
			throw new NotImplementedException();
		}

		public void Perform(GeomFill_Line Lin, GeomFill_SectionGenerator SecGen, bool SpApprox)
		{
			throw new NotImplementedException();
		}

		public void Perform(GeomFill_Line Lin, GeomFill_SectionGenerator SecGen)
		{
			throw new NotImplementedException();
		}

		public void PerformSmoothing(GeomFill_Line Lin, GeomFill_SectionGenerator SecGen)
		{
			throw new NotImplementedException();
		}

		public void Perform(GeomFill_Line Lin, GeomFill_SectionGenerator SecGen, int NbMaxP)
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

		public void InternalPerform(GeomFill_Line Lin, GeomFill_SectionGenerator SecGen, bool SpApprox, bool UseVariational)
		{
			throw new NotImplementedException();
		}


	}; // class GeomFill_AppSurf

}
