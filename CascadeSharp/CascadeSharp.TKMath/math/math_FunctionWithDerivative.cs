//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  math_FunctionWithDerivative
	//---------------------------------------------------------------------
	public  abstract class math_FunctionWithDerivative : CascadeSharp.math_Function
	{

		public math_FunctionWithDerivative(math_FunctionWithDerivative parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public math_FunctionWithDerivative()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public bool Value(double X, ref double F)
		{
			throw new NotImplementedException();
		}

		public bool Derivative(double X, ref double D)
		{
			throw new NotImplementedException();
		}

		public bool Values(double X, ref double F, ref double D)
		{
			throw new NotImplementedException();
		}


	}; // class math_FunctionWithDerivative

}
