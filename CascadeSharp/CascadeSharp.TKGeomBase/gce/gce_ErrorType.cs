//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Enum  gce_ErrorType
	//---------------------------------------------------------------------
	public	enum gce_ErrorType
	{
		gce_Done = 0,
		gce_ConfusedPoints = 1,
		gce_NegativeRadius = 2,
		gce_ColinearPoints = 3,
		gce_IntersectionError = 4,
		gce_NullAxis = 5,
		gce_NullAngle = 6,
		gce_NullRadius = 7,
		gce_InvertAxis = 8,
		gce_BadAngle = 9,
		gce_InvertRadius = 10,
		gce_NullFocusLength = 11,
		gce_NullVector = 12,
		gce_BadEquation = 13
	} // enum  class gce_ErrorType

}
