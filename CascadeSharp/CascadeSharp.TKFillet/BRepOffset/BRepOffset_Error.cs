//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Enum  BRepOffset_Error
	//---------------------------------------------------------------------
	public	enum BRepOffset_Error
	{
		BRepOffset_NoError = 0,
		BRepOffset_UnknownError = 1,
		BRepOffset_BadNormalsOnGeometry = 2,
		BRepOffset_C0Geometry = 3,
		BRepOffset_NullOffset = 4,
		BRepOffset_NotConnectedShell = 5,
		BRepOffset_CannotTrimEdges = 6,
		BRepOffset_CannotFuseVertices = 7,
		BRepOffset_CannotExtentEdge = 8
	} // enum  class BRepOffset_Error

}
