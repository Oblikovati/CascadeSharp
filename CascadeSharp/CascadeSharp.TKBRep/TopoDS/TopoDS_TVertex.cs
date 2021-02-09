//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopoDS_TVertex
	//---------------------------------------------------------------------
	public  abstract class TopoDS_TVertex : CascadeSharp.TopoDS_TShape
	{

		public TopoDS_TVertex()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public TopoDS_TVertex(TopoDS_TVertex parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public CascadeSharp.TopAbs_ShapeEnum ShapeType()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class TopoDS_TVertex

}
