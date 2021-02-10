//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKGeomAlgo.GeomFill;

namespace CascadeSharp.TKBool.BRepFill
{
	//---------------------------------------------------------------------
	//  Class  BRepFill_Edge3DLaw
	//---------------------------------------------------------------------
	public  class BRepFill_Edge3DLaw : BRepFill_LocationLaw
	{

		public BRepFill_Edge3DLaw(TopoDS_Wire Path, GeomFill_LocationLaw Law)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Edge3DLaw(BRepFill_Edge3DLaw parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Edge3DLaw()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRepFill_Edge3DLaw

}
