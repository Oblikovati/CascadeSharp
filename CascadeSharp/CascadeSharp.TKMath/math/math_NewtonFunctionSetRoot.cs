//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
	//---------------------------------------------------------------------
	//  Class  math_NewtonFunctionSetRoot
	//---------------------------------------------------------------------
	public  sealed class math_NewtonFunctionSetRoot
	{

		public math_NewtonFunctionSetRoot(math_FunctionSetWithDerivatives theFunction, math_Vector theXTolerance, double theFTolerance, int tehNbIterations)
			: base()
		{
			throw new NotImplementedException();
		}

		public math_NewtonFunctionSetRoot(math_FunctionSetWithDerivatives theFunction, math_Vector theXTolerance, double theFTolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public math_NewtonFunctionSetRoot(math_FunctionSetWithDerivatives theFunction, double theFTolerance, int theNbIterations)
			: base()
		{
			throw new NotImplementedException();
		}

		public math_NewtonFunctionSetRoot(math_FunctionSetWithDerivatives theFunction, double theFTolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public math_NewtonFunctionSetRoot(math_NewtonFunctionSetRoot parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public math_NewtonFunctionSetRoot()
		{
			throw new NotImplementedException();
		}

		public void SetTolerance(math_Vector XTol)
		{
			throw new NotImplementedException();
		}

		public void Perform(math_FunctionSetWithDerivatives theFunction, math_Vector theStartingPoint)
		{
			throw new NotImplementedException();
		}

		public void Perform(math_FunctionSetWithDerivatives theFunction, math_Vector theStartingPoint, math_Vector theInfBound, math_Vector theSupBound)
		{
			throw new NotImplementedException();
		}

		public bool IsSolutionReached(math_FunctionSetWithDerivatives F)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
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

		public int StateNumber()
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

		public int NbIterations()
		{
			throw new NotImplementedException();
		}

		
	}; // class math_NewtonFunctionSetRoot

}
