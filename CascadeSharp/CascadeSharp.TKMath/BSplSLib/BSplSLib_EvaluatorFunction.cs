//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BSplSLib_EvaluatorFunction
	//---------------------------------------------------------------------
	public  abstract class BSplSLib_EvaluatorFunction
	{

		public BSplSLib_EvaluatorFunction()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BSplSLib_EvaluatorFunction(BSplSLib_EvaluatorFunction parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void Evaluate(int theDerivativeRequest, double theUParameter, double theVParameter, ref double theResult, ref int theErrorCode)
		{
			throw new NotImplementedException();
		}


	}; // class BSplSLib_EvaluatorFunction

}
