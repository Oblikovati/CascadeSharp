//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.BRepBuilderAPI
{
	//---------------------------------------------------------------------
	//  Class  BRepBuilderAPI_Transform
	//---------------------------------------------------------------------
	public  sealed class BRepBuilderAPI_Transform : BRepBuilderAPI_ModifyShape
	{

		public BRepBuilderAPI_Transform(gp_Trsf T)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_Transform(TopoDS_Shape S, gp_Trsf T, bool Copy)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_Transform(TopoDS_Shape S, gp_Trsf T)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_Transform(BRepBuilderAPI_Transform parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_Transform()
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Shape S, bool Copy)
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ModifiedShape(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Modified(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}


	}; // class BRepBuilderAPI_Transform

}
