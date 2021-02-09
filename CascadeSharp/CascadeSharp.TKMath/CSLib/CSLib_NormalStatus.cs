//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Enum  CSLib_NormalStatus
	//---------------------------------------------------------------------
	public	enum CSLib_NormalStatus
	{
		CSLib_Singular = 0,
		CSLib_Defined = 1,
		CSLib_InfinityOfSolutions = 2,
		CSLib_D1NuIsNull = 3,
		CSLib_D1NvIsNull = 4,
		CSLib_D1NIsNull = 5,
		CSLib_D1NuNvRatioIsNull = 6,
		CSLib_D1NvNuRatioIsNull = 7,
		CSLib_D1NuIsParallelD1Nv = 8
	} // enum  class CSLib_NormalStatus

}
