//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BSplCLib_EvaluatorFunction
	//---------------------------------------------------------------------
	public  abstract class BSplCLib_EvaluatorFunction
	{

		public BSplCLib_EvaluatorFunction()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BSplCLib_EvaluatorFunction(BSplCLib_EvaluatorFunction parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void Evaluate(int theDerivativeRequest, double theStartEnd, double theParameter, ref double theResult, ref int theErrorCode)
		{
			throw new NotImplementedException();
		}


	}; // class BSplCLib_EvaluatorFunction

}
