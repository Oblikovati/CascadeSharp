//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;

namespace CascadeSharp.TKBool.BRepFill
{
	//---------------------------------------------------------------------
	//  Class  BRepFill_EdgeOnSurfLaw
	//---------------------------------------------------------------------
	public  sealed class BRepFill_EdgeOnSurfLaw : BRepFill_LocationLaw
	{

		public BRepFill_EdgeOnSurfLaw(TopoDS_Wire Path, TopoDS_Shape Surf)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_EdgeOnSurfLaw(BRepFill_EdgeOnSurfLaw parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_EdgeOnSurfLaw()
		{
			throw new NotImplementedException();
		}

		public bool HasResult()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRepFill_EdgeOnSurfLaw

}
