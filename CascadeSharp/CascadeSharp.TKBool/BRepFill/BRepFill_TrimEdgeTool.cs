//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepFill_TrimEdgeTool
	//---------------------------------------------------------------------
	public  sealed class BRepFill_TrimEdgeTool
	{

		public BRepFill_TrimEdgeTool()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_TrimEdgeTool(Bisector_Bisec B_isec, Geom2d_Geometry S1, Geom2d_Geometry S2, double Offset)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_TrimEdgeTool(BRepFill_TrimEdgeTool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void IntersectWith(TopoDS_Edge Edge1, TopoDS_Edge Edge2, TopoDS_Shape InitShape1, TopoDS_Shape InitShape2, TopoDS_Vertex End1, TopoDS_Vertex End2, CascadeSharp.GeomAbs_JoinType theJoinType, bool IsOpenResult, TColgp_SequenceOfPnt Params)
		{
			throw new NotImplementedException();
		}

		public void AddOrConfuse(bool Start, TopoDS_Edge Edge1, TopoDS_Edge Edge2, TColgp_SequenceOfPnt Params)
		{
			throw new NotImplementedException();
		}

		public bool IsInside(gp_Pnt2d P)
		{
			throw new NotImplementedException();
		}


	}; // class BRepFill_TrimEdgeTool

}
