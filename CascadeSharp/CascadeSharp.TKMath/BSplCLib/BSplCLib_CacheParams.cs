//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;

namespace CascadeSharp.TKMath.BSplCLib
{
	//---------------------------------------------------------------------
	//  Class  BSplCLib_CacheParams
	//---------------------------------------------------------------------
	public  sealed class BSplCLib_CacheParams
	{

		public BSplCLib_CacheParams(int theDegree, bool thePeriodic, TColStd_Array1OfReal theFlatKnots)
			: base()
		{
			throw new NotImplementedException();
		}

		public BSplCLib_CacheParams(BSplCLib_CacheParams parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BSplCLib_CacheParams()
		{
			throw new NotImplementedException();
		}

		public double PeriodicNormalization(double theParameter)
		{
			throw new NotImplementedException();
		}

		public bool IsCacheValid(double theParameter)
		{
			throw new NotImplementedException();
		}

		public void LocateParameter(ref double theParameter, TColStd_Array1OfReal theFlatKnots)
		{
			throw new NotImplementedException();
		}


	}; // class BSplCLib_CacheParams

}
