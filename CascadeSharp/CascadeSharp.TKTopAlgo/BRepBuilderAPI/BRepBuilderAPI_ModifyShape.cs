//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepTools;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKTopAlgo.BRepBuilderAPI
{
	//---------------------------------------------------------------------
	//  Class  BRepBuilderAPI_ModifyShape
	//---------------------------------------------------------------------
	public  class BRepBuilderAPI_ModifyShape : BRepBuilderAPI_MakeShape
	{

		public BRepBuilderAPI_ModifyShape()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_ModifyShape(TopoDS_Shape S)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_ModifyShape(BRepTools_Modification M)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_ModifyShape(TopoDS_Shape S, BRepTools_Modification M)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_ModifyShape(BRepBuilderAPI_ModifyShape parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Modified(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ModifiedShape(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void DoModif(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void DoModif(BRepTools_Modification M)
		{
			throw new NotImplementedException();
		}

		public void DoModif(TopoDS_Shape S, BRepTools_Modification M)
		{
			throw new NotImplementedException();
		}

		public void DoModif()
		{
			throw new NotImplementedException();
		}


	}; // class BRepBuilderAPI_ModifyShape

}
