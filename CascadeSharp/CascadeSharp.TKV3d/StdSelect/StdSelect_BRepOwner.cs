//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKMath.TopLoc;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.StdSelect
{
	//---------------------------------------------------------------------
	//  Class  StdSelect_BRepOwner
	//---------------------------------------------------------------------
	public  sealed class StdSelect_BRepOwner : SelectMgr_EntityOwner
	{

		public StdSelect_BRepOwner(int aPriority)
			: base()
		{
			throw new NotImplementedException();
		}

		public StdSelect_BRepOwner(TopoDS_Shape aShape, int aPriority, bool ComesFromDecomposition)
			: base()
		{
			throw new NotImplementedException();
		}

		public StdSelect_BRepOwner(TopoDS_Shape aShape, int aPriority)
			: base()
		{
			throw new NotImplementedException();
		}

		public StdSelect_BRepOwner(TopoDS_Shape aShape)
			: base()
		{
			throw new NotImplementedException();
		}

		public StdSelect_BRepOwner(TopoDS_Shape aShape, SelectMgr_SelectableObject theOrigin, int aPriority, bool FromDecomposition)
			: base()
		{
			throw new NotImplementedException();
		}

		public StdSelect_BRepOwner(TopoDS_Shape aShape, SelectMgr_SelectableObject theOrigin, int aPriority)
			: base()
		{
			throw new NotImplementedException();
		}

		public StdSelect_BRepOwner(TopoDS_Shape aShape, SelectMgr_SelectableObject theOrigin)
			: base()
		{
			throw new NotImplementedException();
		}

		public StdSelect_BRepOwner(StdSelect_BRepOwner parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public StdSelect_BRepOwner()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool HasShape()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public bool HasHilightMode()
		{
			throw new NotImplementedException();
		}

		public void SetHilightMode(int theMode)
		{
			throw new NotImplementedException();
		}

		public void ResetHilightMode()
		{
			throw new NotImplementedException();
		}

		public int HilightMode()
		{
			throw new NotImplementedException();
		}

																		public void SetLocation(TopLoc_Location aLoc)
		{
			throw new NotImplementedException();
		}

						
	}; // class StdSelect_BRepOwner

}
