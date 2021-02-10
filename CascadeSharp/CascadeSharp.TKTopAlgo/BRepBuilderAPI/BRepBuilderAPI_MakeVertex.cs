//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.BRepBuilderAPI
{
	//---------------------------------------------------------------------
	//  Class  BRepBuilderAPI_MakeVertex
	//---------------------------------------------------------------------
	public  sealed class BRepBuilderAPI_MakeVertex : BRepBuilderAPI_MakeShape
	{

		public BRepBuilderAPI_MakeVertex(gp_Pnt P)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_MakeVertex(BRepBuilderAPI_MakeVertex parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_MakeVertex()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex Vertex()
		{
			throw new NotImplementedException();
		}


	}; // class BRepBuilderAPI_MakeVertex

}
