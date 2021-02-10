//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

namespace CascadeSharp.TKMath.CSLib
{
	//---------------------------------------------------------------------
	//  Enum  CSLib_DerivativeStatus
	//---------------------------------------------------------------------
	public	enum CSLib_DerivativeStatus
	{
		CSLib_Done = 0,
		CSLib_D1uIsNull = 1,
		CSLib_D1vIsNull = 2,
		CSLib_D1IsNull = 3,
		CSLib_D1uD1vRatioIsNull = 4,
		CSLib_D1vD1uRatioIsNull = 5,
		CSLib_D1uIsParallelD1v = 6
	} // enum  class CSLib_DerivativeStatus

}
