//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  math_MultipleVarFunctionWithHessian
	//---------------------------------------------------------------------
	public  abstract class math_MultipleVarFunctionWithHessian : CascadeSharp.math_MultipleVarFunctionWithGradient
	{

		public math_MultipleVarFunctionWithHessian()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public math_MultipleVarFunctionWithHessian(math_MultipleVarFunctionWithHessian parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public int NbVariables()
		{
			throw new NotImplementedException();
		}

		public bool Value(math_Vector X, ref double F)
		{
			throw new NotImplementedException();
		}

		public bool Gradient(math_Vector X, math_Vector G)
		{
			throw new NotImplementedException();
		}

		public bool Values(math_Vector X, ref double F, math_Vector G)
		{
			throw new NotImplementedException();
		}

		public bool Values(math_Vector X, ref double F, math_Vector G, math_Matrix H)
		{
			throw new NotImplementedException();
		}


	}; // class math_MultipleVarFunctionWithHessian

}
