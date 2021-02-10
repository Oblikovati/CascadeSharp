//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
	//---------------------------------------------------------------------
	//  Class  math_FunctionSetWithDerivatives
	//---------------------------------------------------------------------
	public  abstract class math_FunctionSetWithDerivatives : math_FunctionSet
	{

		public math_FunctionSetWithDerivatives(math_FunctionSetWithDerivatives parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public math_FunctionSetWithDerivatives()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public int NbVariables()
		{
			throw new NotImplementedException();
		}

		public int NbEquations()
		{
			throw new NotImplementedException();
		}

		public bool Value(math_Vector X, math_Vector F)
		{
			throw new NotImplementedException();
		}

		public bool Derivatives(math_Vector X, math_Matrix D)
		{
			throw new NotImplementedException();
		}

		public bool Values(math_Vector X, math_Vector F, math_Matrix D)
		{
			throw new NotImplementedException();
		}


	}; // class math_FunctionSetWithDerivatives

}
