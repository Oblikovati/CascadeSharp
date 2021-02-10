//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Enum  BRepCheck_Status
	//---------------------------------------------------------------------
	public	enum BRepCheck_Status
	{
		BRepCheck_NoError = 0,
		BRepCheck_InvalidPointOnCurve = 1,
		BRepCheck_InvalidPointOnCurveOnSurface = 2,
		BRepCheck_InvalidPointOnSurface = 3,
		BRepCheck_No3DCurve = 4,
		BRepCheck_Multiple3DCurve = 5,
		BRepCheck_Invalid3DCurve = 6,
		BRepCheck_NoCurveOnSurface = 7,
		BRepCheck_InvalidCurveOnSurface = 8,
		BRepCheck_InvalidCurveOnClosedSurface = 9,
		BRepCheck_InvalidSameRangeFlag = 10,
		BRepCheck_InvalidSameParameterFlag = 11,
		BRepCheck_InvalidDegeneratedFlag = 12,
		BRepCheck_FreeEdge = 13,
		BRepCheck_InvalidMultiConnexity = 14,
		BRepCheck_InvalidRange = 15,
		BRepCheck_EmptyWire = 16,
		BRepCheck_RedundantEdge = 17,
		BRepCheck_SelfIntersectingWire = 18,
		BRepCheck_NoSurface = 19,
		BRepCheck_InvalidWire = 20,
		BRepCheck_RedundantWire = 21,
		BRepCheck_IntersectingWires = 22,
		BRepCheck_InvalidImbricationOfWires = 23,
		BRepCheck_EmptyShell = 24,
		BRepCheck_RedundantFace = 25,
		BRepCheck_InvalidImbricationOfShells = 26,
		BRepCheck_UnorientableShape = 27,
		BRepCheck_NotClosed = 28,
		BRepCheck_NotConnected = 29,
		BRepCheck_SubshapeNotInShape = 30,
		BRepCheck_BadOrientation = 31,
		BRepCheck_BadOrientationOfSubshape = 32,
		BRepCheck_InvalidPolygonOnTriangulation = 33,
		BRepCheck_InvalidToleranceValue = 34,
		BRepCheck_EnclosedRegion = 35,
		BRepCheck_CheckFail = 36
	} // enum  class BRepCheck_Status

}
