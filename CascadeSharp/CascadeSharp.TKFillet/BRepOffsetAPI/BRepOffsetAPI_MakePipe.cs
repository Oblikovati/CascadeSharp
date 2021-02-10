//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepOffsetAPI_MakePipe
	//---------------------------------------------------------------------
	public  sealed class BRepOffsetAPI_MakePipe : CascadeSharp.BRepPrimAPI_MakeSweep
	{

		public BRepOffsetAPI_MakePipe(TopoDS_Wire Spine, TopoDS_Shape Profile)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_MakePipe(TopoDS_Wire Spine, TopoDS_Shape Profile, CascadeSharp.GeomFill_Trihedron aMode, bool ForceApproxC1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_MakePipe(TopoDS_Wire Spine, TopoDS_Shape Profile, CascadeSharp.GeomFill_Trihedron aMode)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_MakePipe(BRepOffsetAPI_MakePipe parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffsetAPI_MakePipe()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Pipe Pipe()
		{
			throw new NotImplementedException();
		}

		public void Build()
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

		public TopTools_ListOfShape Generated(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Generated(TopoDS_Shape SSpine, TopoDS_Shape SProfile)
		{
			throw new NotImplementedException();
		}

		public double ErrorOnSurface()
		{
			throw new NotImplementedException();
		}


	}; // class BRepOffsetAPI_MakePipe

}
