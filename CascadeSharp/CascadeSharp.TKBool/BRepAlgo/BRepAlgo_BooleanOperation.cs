//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBool.TopOpeBRepBuild;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKBool.BRepAlgo
{
	//---------------------------------------------------------------------
	//  Class  BRepAlgo_BooleanOperation
	//---------------------------------------------------------------------
	public  class BRepAlgo_BooleanOperation : BRepBuilderAPI_MakeShape
	{

		public BRepAlgo_BooleanOperation(TopoDS_Shape S1, TopoDS_Shape S2)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepAlgo_BooleanOperation(BRepAlgo_BooleanOperation parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepAlgo_BooleanOperation()
		{
			throw new NotImplementedException();
		}

		public void PerformDS()
		{
			throw new NotImplementedException();
		}

		public void Perform(TopAbs_State St1, TopAbs_State St2)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_HBuilder Builder()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape1()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape2()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Modified(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public bool IsDeleted(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void BuilderCanWork(bool B)
		{
			throw new NotImplementedException();
		}

		public bool BuilderCanWork()
		{
			throw new NotImplementedException();
		}

		public void InitParameters()
		{
			throw new NotImplementedException();
		}


	}; // class BRepAlgo_BooleanOperation

}
