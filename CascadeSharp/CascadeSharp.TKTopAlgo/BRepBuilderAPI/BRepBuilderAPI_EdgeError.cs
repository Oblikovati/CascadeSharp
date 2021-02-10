//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Enum  BRepBuilderAPI_EdgeError
	//---------------------------------------------------------------------
	public	enum BRepBuilderAPI_EdgeError
	{
		BRepBuilderAPI_EdgeDone = 0,
		BRepBuilderAPI_PointProjectionFailed = 1,
		BRepBuilderAPI_ParameterOutOfRange = 2,
		BRepBuilderAPI_DifferentPointsOnClosedCurve = 3,
		BRepBuilderAPI_PointWithInfiniteParameter = 4,
		BRepBuilderAPI_DifferentsPointAndParameter = 5,
		BRepBuilderAPI_LineThroughIdenticPoints = 6
	} // enum  class BRepBuilderAPI_EdgeError

}
