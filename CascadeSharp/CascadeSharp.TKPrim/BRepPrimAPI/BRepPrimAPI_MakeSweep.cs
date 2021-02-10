//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepPrimAPI_MakeSweep
	//---------------------------------------------------------------------
	public  abstract class BRepPrimAPI_MakeSweep : CascadeSharp.BRepBuilderAPI_MakeShape
	{

		public BRepPrimAPI_MakeSweep(BRepPrimAPI_MakeSweep parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BRepPrimAPI_MakeSweep()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public TopoDS_Shape FirstShape()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape LastShape()
		{
			throw new NotImplementedException();
		}


	}; // class BRepPrimAPI_MakeSweep

}
