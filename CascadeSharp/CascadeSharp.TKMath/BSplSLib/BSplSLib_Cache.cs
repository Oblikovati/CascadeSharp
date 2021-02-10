//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKMath.BSplSLib
{
	//---------------------------------------------------------------------
	//  Class  BSplSLib_Cache
	//---------------------------------------------------------------------
	public  sealed class BSplSLib_Cache : Standard_Transient
	{

		public BSplSLib_Cache(int theDegreeU, bool thePeriodicU, TColStd_Array1OfReal theFlatKnotsU, int theDegreeV, bool thePeriodicV, TColStd_Array1OfReal theFlatKnotsV, TColStd_Array2OfReal theWeights)
			: base()
		{
			throw new NotImplementedException();
		}

		public BSplSLib_Cache(int theDegreeU, bool thePeriodicU, TColStd_Array1OfReal theFlatKnotsU, int theDegreeV, bool thePeriodicV, TColStd_Array1OfReal theFlatKnotsV)
			: base()
		{
			throw new NotImplementedException();
		}

		public BSplSLib_Cache(BSplSLib_Cache parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BSplSLib_Cache()
		{
			throw new NotImplementedException();
		}

		public bool IsCacheValid(double theParameterU, double theParameterV)
		{
			throw new NotImplementedException();
		}

		public void BuildCache(double theParameterU, double theParameterV, TColStd_Array1OfReal theFlatKnotsU, TColStd_Array1OfReal theFlatKnotsV, TColgp_Array2OfPnt thePoles, TColStd_Array2OfReal theWeights)
		{
			throw new NotImplementedException();
		}

		public void BuildCache(double theParameterU, double theParameterV, TColStd_Array1OfReal theFlatKnotsU, TColStd_Array1OfReal theFlatKnotsV, TColgp_Array2OfPnt thePoles)
		{
			throw new NotImplementedException();
		}

		public void D0(double theU, double theV, gp_Pnt thePoint)
		{
			throw new NotImplementedException();
		}

		public void D1(double theU, double theV, gp_Pnt thePoint, gp_Vec theTangentU, gp_Vec theTangentV)
		{
			throw new NotImplementedException();
		}

		public void D2(double theU, double theV, gp_Pnt thePoint, gp_Vec theTangentU, gp_Vec theTangentV, gp_Vec theCurvatureU, gp_Vec theCurvatureV, gp_Vec theCurvatureUV)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BSplSLib_Cache

}
