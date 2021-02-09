//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  AdvApprox_SimpleApprox
	//---------------------------------------------------------------------
	public  sealed class AdvApprox_SimpleApprox
	{

		public AdvApprox_SimpleApprox(int TotalDimension, int TotalNumSS, CascadeSharp.GeomAbs_Shape Continuity, int WorkDegree, int NbGaussPoints, PLib_JacobiPolynomial JacobiBase, AdvApprox_EvaluatorFunction Func)
			: base()
		{
			throw new NotImplementedException();
		}

		public AdvApprox_SimpleApprox(AdvApprox_SimpleApprox parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AdvApprox_SimpleApprox()
		{
			throw new NotImplementedException();
		}

		public void Perform(TColStd_Array1OfInteger LocalDimension, TColStd_Array1OfReal LocalTolerancesArray, double First, double Last, int MaxDegree)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public int Degree()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfReal Coefficients()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray2OfReal FirstConstr()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray2OfReal LastConstr()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfReal SomTab()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfReal DifTab()
		{
			throw new NotImplementedException();
		}

		public double MaxError(int Index)
		{
			throw new NotImplementedException();
		}

		public double AverageError(int Index)
		{
			throw new NotImplementedException();
		}

		
	}; // class AdvApprox_SimpleApprox

}
