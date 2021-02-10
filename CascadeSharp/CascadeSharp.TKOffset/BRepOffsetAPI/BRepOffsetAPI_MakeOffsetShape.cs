//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKOffset.BRepOffset;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKOffset.BRepOffsetAPI
{
	//---------------------------------------------------------------------
	//  Class  BRepOffsetAPI_MakeOffsetShape
	//---------------------------------------------------------------------
	public  class BRepOffsetAPI_MakeOffsetShape : BRepBuilderAPI_MakeShape
	{

		public BRepOffsetAPI_MakeOffsetShape()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_MakeOffsetShape(TopoDS_Shape S, double Offset, double Tol, BRepOffset_Mode Mode, bool Intersection, bool SelfInter, GeomAbs_JoinType Join, bool RemoveIntEdges)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_MakeOffsetShape(TopoDS_Shape S, double Offset, double Tol, BRepOffset_Mode Mode, bool Intersection, bool SelfInter, GeomAbs_JoinType Join)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_MakeOffsetShape(TopoDS_Shape S, double Offset, double Tol, BRepOffset_Mode Mode, bool Intersection, bool SelfInter)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_MakeOffsetShape(TopoDS_Shape S, double Offset, double Tol, BRepOffset_Mode Mode, bool Intersection)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_MakeOffsetShape(TopoDS_Shape S, double Offset, double Tol, BRepOffset_Mode Mode)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_MakeOffsetShape(TopoDS_Shape S, double Offset, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_MakeOffsetShape(BRepOffsetAPI_MakeOffsetShape parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void PerformBySimple(TopoDS_Shape theS, double theOffsetValue)
		{
			throw new NotImplementedException();
		}

		public void PerformByJoin(TopoDS_Shape S, double Offset, double Tol, BRepOffset_Mode Mode, bool Intersection, bool SelfInter, GeomAbs_JoinType Join, bool RemoveIntEdges)
		{
			throw new NotImplementedException();
		}

		public void PerformByJoin(TopoDS_Shape S, double Offset, double Tol, BRepOffset_Mode Mode, bool Intersection, bool SelfInter, GeomAbs_JoinType Join)
		{
			throw new NotImplementedException();
		}

		public void PerformByJoin(TopoDS_Shape S, double Offset, double Tol, BRepOffset_Mode Mode, bool Intersection, bool SelfInter)
		{
			throw new NotImplementedException();
		}

		public void PerformByJoin(TopoDS_Shape S, double Offset, double Tol, BRepOffset_Mode Mode, bool Intersection)
		{
			throw new NotImplementedException();
		}

		public void PerformByJoin(TopoDS_Shape S, double Offset, double Tol, BRepOffset_Mode Mode)
		{
			throw new NotImplementedException();
		}

		public void PerformByJoin(TopoDS_Shape S, double Offset, double Tol)
		{
			throw new NotImplementedException();
		}

		public BRepOffset_MakeOffset MakeOffset()
		{
			throw new NotImplementedException();
		}

		public void Build()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Generated(TopoDS_Shape S)
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

		public GeomAbs_JoinType GetJoinType()
		{
			throw new NotImplementedException();
		}


		//---------------------------------------------------------------------
		//  Enum  OffsetAlgo_Type
		//---------------------------------------------------------------------
		public		enum OffsetAlgo_Type
		{
			OffsetAlgo_NONE = 0,
			OffsetAlgo_JOIN = 1,
			OffsetAlgo_SIMPLE = 2
		} // enum  class OffsetAlgo_Type

	}; // class BRepOffsetAPI_MakeOffsetShape

}
