//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  AdvApprox_EvaluatorFunction
	//---------------------------------------------------------------------
	public  abstract class AdvApprox_EvaluatorFunction
	{

		public AdvApprox_EvaluatorFunction()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public AdvApprox_EvaluatorFunction(AdvApprox_EvaluatorFunction parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void Evaluate(ref int Dimension, ref double StartEnd, ref double Parameter, ref int DerivativeRequest, ref double Result, ref int ErrorCode)
		{
			throw new NotImplementedException();
		}


	}; // class AdvApprox_EvaluatorFunction

}
