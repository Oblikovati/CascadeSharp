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
	//  Class  BRepBuilderAPI_GTransform
	//---------------------------------------------------------------------
	public  sealed class BRepBuilderAPI_GTransform : BRepBuilderAPI_ModifyShape
	{

		public BRepBuilderAPI_GTransform(gp_GTrsf T)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_GTransform(TopoDS_Shape S, gp_GTrsf T, bool Copy)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_GTransform(TopoDS_Shape S, gp_GTrsf T)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_GTransform(BRepBuilderAPI_GTransform parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_GTransform()
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

		public TopTools_ListOfShape Modified(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ModifiedShape(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}


	}; // class BRepBuilderAPI_GTransform

}
