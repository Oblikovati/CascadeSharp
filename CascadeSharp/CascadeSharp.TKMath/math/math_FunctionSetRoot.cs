//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  math_FunctionSetRoot
	//---------------------------------------------------------------------
	public  sealed class math_FunctionSetRoot
	{

		public math_FunctionSetRoot(math_FunctionSetWithDerivatives F, math_Vector Tolerance, int NbIterations)
			: base()
		{
			throw new NotImplementedException();
		}

		public math_FunctionSetRoot(math_FunctionSetWithDerivatives F, math_Vector Tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public math_FunctionSetRoot(math_FunctionSetWithDerivatives F, int NbIterations)
			: base()
		{
			throw new NotImplementedException();
		}

		public math_FunctionSetRoot(math_FunctionSetWithDerivatives F)
			: base()
		{
			throw new NotImplementedException();
		}

		public math_FunctionSetRoot(math_FunctionSetRoot parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public math_FunctionSetRoot()
		{
			throw new NotImplementedException();
		}

		public void SetTolerance(math_Vector Tolerance)
		{
			throw new NotImplementedException();
		}

		public bool IsSolutionReached(math_FunctionSetWithDerivatives F)
		{
			throw new NotImplementedException();
		}

		public void Perform(math_FunctionSetWithDerivatives theFunction, math_Vector theStartingPoint, bool theStopOnDivergent)
		{
			throw new NotImplementedException();
		}

		public void Perform(math_FunctionSetWithDerivatives theFunction, math_Vector theStartingPoint)
		{
			throw new NotImplementedException();
		}

		public void Perform(math_FunctionSetWithDerivatives theFunction, math_Vector theStartingPoint, math_Vector theInfBound, math_Vector theSupBound, bool theStopOnDivergent)
		{
			throw new NotImplementedException();
		}

		public void Perform(math_FunctionSetWithDerivatives theFunction, math_Vector theStartingPoint, math_Vector theInfBound, math_Vector theSupBound)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public int NbIterations()
		{
			throw new NotImplementedException();
		}

		public int StateNumber()
		{
			throw new NotImplementedException();
		}

		public math_Vector Root()
		{
			throw new NotImplementedException();
		}

		public void Root(math_Vector Root)
		{
			throw new NotImplementedException();
		}

		public math_Matrix Derivative()
		{
			throw new NotImplementedException();
		}

		public void Derivative(math_Matrix Der)
		{
			throw new NotImplementedException();
		}

		public math_Vector FunctionSetErrors()
		{
			throw new NotImplementedException();
		}

		public void FunctionSetErrors(math_Vector Err)
		{
			throw new NotImplementedException();
		}

				public bool IsDivergent()
		{
			throw new NotImplementedException();
		}


	}; // class math_FunctionSetRoot

}
