//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Enum  HatchGen_ErrorStatus
	//---------------------------------------------------------------------
	public	enum HatchGen_ErrorStatus
	{
		HatchGen_NoProblem = 0,
		HatchGen_TrimFailure = 1,
		HatchGen_TransitionFailure = 2,
		HatchGen_IncoherentParity = 3,
		HatchGen_IncompatibleStates = 4
	} // enum  class HatchGen_ErrorStatus

}
