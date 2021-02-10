//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

namespace CascadeSharp.TKOffset.BRepOffset
{
	//---------------------------------------------------------------------
	//  Enum  BRepOffsetSimple_Status
	//---------------------------------------------------------------------
	public	enum BRepOffsetSimple_Status
	{
		BRepOffsetSimple_OK = 0,
		BRepOffsetSimple_NullInputShape = 1,
		BRepOffsetSimple_ErrorOffsetComputation = 2,
		BRepOffsetSimple_ErrorWallFaceComputation = 3,
		BRepOffsetSimple_ErrorInvalidNbShells = 4,
		BRepOffsetSimple_ErrorNonClosedShell = 5
	} // enum  class BRepOffsetSimple_Status

}
