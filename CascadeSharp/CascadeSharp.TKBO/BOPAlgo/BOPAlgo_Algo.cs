//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BOPAlgo_Algo
	//---------------------------------------------------------------------
	public  abstract class BOPAlgo_Algo : CascadeSharp.BOPAlgo_Options
	{

		public BOPAlgo_Algo()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BOPAlgo_Algo(NCollection_BaseAllocator theAllocator)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BOPAlgo_Algo(BOPAlgo_Algo parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void Perform()
		{
			throw new NotImplementedException();
		}

		public void CheckData()
		{
			throw new NotImplementedException();
		}

		public void CheckResult()
		{
			throw new NotImplementedException();
		}


	}; // class BOPAlgo_Algo

}
