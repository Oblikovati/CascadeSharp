//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  ChFi2d_AnaFilletAlgo
	//---------------------------------------------------------------------
	public  sealed class ChFi2d_AnaFilletAlgo
	{

		public ChFi2d_AnaFilletAlgo()
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFi2d_AnaFilletAlgo(TopoDS_Wire theWire, gp_Pln thePlane)
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFi2d_AnaFilletAlgo(TopoDS_Edge theEdge1, TopoDS_Edge theEdge2, gp_Pln thePlane)
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFi2d_AnaFilletAlgo(ChFi2d_AnaFilletAlgo parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Wire theWire, gp_Pln thePlane)
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Edge theEdge1, TopoDS_Edge theEdge2, gp_Pln thePlane)
		{
			throw new NotImplementedException();
		}

		public bool Perform(double radius)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge Result(TopoDS_Edge e1, TopoDS_Edge e2)
		{
			throw new NotImplementedException();
		}

		public bool SegmentFilletSegment(double radius, ref double xc, ref double yc, ref bool cw, ref double start, ref double end)
		{
			throw new NotImplementedException();
		}

		public bool SegmentFilletArc(double radius, ref double xc, ref double yc, ref bool cw, ref double start, ref double end, ref double xend, ref double yend)
		{
			throw new NotImplementedException();
		}

		public bool ArcFilletSegment(double radius, ref double xc, ref double yc, ref bool cw, ref double start, ref double end, ref double xstart, ref double ystart)
		{
			throw new NotImplementedException();
		}

		public bool ArcFilletArc(double radius, ref double xc, ref double yc, ref bool cw, ref double start, ref double end)
		{
			throw new NotImplementedException();
		}

		public bool Cut(gp_Pln plane, TopoDS_Edge e1, TopoDS_Edge e2)
		{
			throw new NotImplementedException();
		}


	}; // class ChFi2d_AnaFilletAlgo

}
