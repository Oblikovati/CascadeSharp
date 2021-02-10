//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKMath.BSplCLib
{
	//---------------------------------------------------------------------
	//  Class  BSplCLib_Cache
	//---------------------------------------------------------------------
	public  sealed class BSplCLib_Cache : Standard_Transient
	{

		public BSplCLib_Cache(int theDegree, bool thePeriodic, TColStd_Array1OfReal theFlatKnots, TColgp_Array1OfPnt2d thePoles2d, TColStd_Array1OfReal theWeights)
			: base()
		{
			throw new NotImplementedException();
		}

		public BSplCLib_Cache(int theDegree, bool thePeriodic, TColStd_Array1OfReal theFlatKnots, TColgp_Array1OfPnt2d thePoles2d)
			: base()
		{
			throw new NotImplementedException();
		}

		public BSplCLib_Cache(int theDegree, bool thePeriodic, TColStd_Array1OfReal theFlatKnots, TColgp_Array1OfPnt thePoles, TColStd_Array1OfReal theWeights)
			: base()
		{
			throw new NotImplementedException();
		}

		public BSplCLib_Cache(int theDegree, bool thePeriodic, TColStd_Array1OfReal theFlatKnots, TColgp_Array1OfPnt thePoles)
			: base()
		{
			throw new NotImplementedException();
		}

		public BSplCLib_Cache(BSplCLib_Cache parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BSplCLib_Cache()
		{
			throw new NotImplementedException();
		}

		public bool IsCacheValid(double theParameter)
		{
			throw new NotImplementedException();
		}

		public void BuildCache(double theParameter, TColStd_Array1OfReal theFlatKnots, TColgp_Array1OfPnt2d thePoles2d, TColStd_Array1OfReal theWeights)
		{
			throw new NotImplementedException();
		}

		public void BuildCache(double theParameter, TColStd_Array1OfReal theFlatKnots, TColgp_Array1OfPnt thePoles, TColStd_Array1OfReal theWeights)
		{
			throw new NotImplementedException();
		}

		public void BuildCache(double theParameter, TColStd_Array1OfReal theFlatKnots, TColgp_Array1OfPnt thePoles)
		{
			throw new NotImplementedException();
		}

		public void D0(double theParameter, gp_Pnt2d thePoint)
		{
			throw new NotImplementedException();
		}

		public void D0(double theParameter, gp_Pnt thePoint)
		{
			throw new NotImplementedException();
		}

		public void D1(double theParameter, gp_Pnt2d thePoint, gp_Vec2d theTangent)
		{
			throw new NotImplementedException();
		}

		public void D1(double theParameter, gp_Pnt thePoint, gp_Vec theTangent)
		{
			throw new NotImplementedException();
		}

		public void D2(double theParameter, gp_Pnt2d thePoint, gp_Vec2d theTangent, gp_Vec2d theCurvature)
		{
			throw new NotImplementedException();
		}

		public void D2(double theParameter, gp_Pnt thePoint, gp_Vec theTangent, gp_Vec theCurvature)
		{
			throw new NotImplementedException();
		}

		public void D3(double theParameter, gp_Pnt2d thePoint, gp_Vec2d theTangent, gp_Vec2d theCurvature, gp_Vec2d theTorsion)
		{
			throw new NotImplementedException();
		}

		public void D3(double theParameter, gp_Pnt thePoint, gp_Vec theTangent, gp_Vec theCurvature, gp_Vec theTorsion)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void CalculateDerivative(double theParameter, int theDerivative, ref double theDerivArray)
		{
			throw new NotImplementedException();
		}


	}; // class BSplCLib_Cache

}
