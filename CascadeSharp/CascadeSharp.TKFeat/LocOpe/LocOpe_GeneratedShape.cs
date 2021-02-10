//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  LocOpe_GeneratedShape
	//---------------------------------------------------------------------
	public  abstract class LocOpe_GeneratedShape : Standard_Transient
	{

		public LocOpe_GeneratedShape(LocOpe_GeneratedShape parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public LocOpe_GeneratedShape()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public TopTools_ListOfShape GeneratingEdges()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge Generated(TopoDS_Vertex V)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Generated(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape OrientedFaces()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class LocOpe_GeneratedShape

}
