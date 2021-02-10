//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepFill_Pipe
	//---------------------------------------------------------------------
	public  sealed class BRepFill_Pipe
	{

		public BRepFill_Pipe()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Pipe(TopoDS_Wire Spine, TopoDS_Shape Profile, CascadeSharp.GeomFill_Trihedron aMode, bool ForceApproxC1, bool GeneratePartCase)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Pipe(TopoDS_Wire Spine, TopoDS_Shape Profile, CascadeSharp.GeomFill_Trihedron aMode, bool ForceApproxC1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Pipe(TopoDS_Wire Spine, TopoDS_Shape Profile, CascadeSharp.GeomFill_Trihedron aMode)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Pipe(TopoDS_Wire Spine, TopoDS_Shape Profile)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Pipe(BRepFill_Pipe parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Wire Spine, TopoDS_Shape Profile, bool GeneratePartCase)
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Wire Spine, TopoDS_Shape Profile)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Spine()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Profile()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public double ErrorOnSurface()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape FirstShape()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape LastShape()
		{
			throw new NotImplementedException();
		}

		public void Generated(TopoDS_Shape S, TopTools_ListOfShape L)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Face(TopoDS_Edge ESpine, TopoDS_Edge EProfile)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge Edge(TopoDS_Edge ESpine, TopoDS_Vertex VProfile)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Section(TopoDS_Vertex VSpine)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire PipeLine(gp_Pnt Point)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape MakeShape(TopoDS_Shape S, TopoDS_Shape theOriginalS, TopoDS_Shape FirstShape, TopoDS_Shape LastShape)
		{
			throw new NotImplementedException();
		}

		public int FindEdge(TopoDS_Shape S, TopoDS_Edge E, ref int Init)
		{
			throw new NotImplementedException();
		}

		public int FindVertex(TopoDS_Shape S, TopoDS_Vertex V, ref int Init)
		{
			throw new NotImplementedException();
		}

		public void DefineRealSegmax()
		{
			throw new NotImplementedException();
		}

		public void RebuildTopOrBottomFace(TopoDS_Shape aFace, bool IsTop)
		{
			throw new NotImplementedException();
		}

		public void BuildHistory(BRepFill_Sweep theSweep, TopoDS_Shape theSection)
		{
			throw new NotImplementedException();
		}


	}; // class BRepFill_Pipe

}
