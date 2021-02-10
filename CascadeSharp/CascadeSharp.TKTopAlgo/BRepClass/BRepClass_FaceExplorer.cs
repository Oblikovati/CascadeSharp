//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepClass_FaceExplorer
	//---------------------------------------------------------------------
	public  sealed class BRepClass_FaceExplorer
	{

		public BRepClass_FaceExplorer(TopoDS_Face F)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepClass_FaceExplorer(BRepClass_FaceExplorer parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepClass_FaceExplorer()
		{
			throw new NotImplementedException();
		}

		public bool CheckPoint(gp_Pnt2d thePoint)
		{
			throw new NotImplementedException();
		}

		public bool Reject(gp_Pnt2d P)
		{
			throw new NotImplementedException();
		}

		public bool Segment(gp_Pnt2d P, gp_Lin2d L, ref double Par)
		{
			throw new NotImplementedException();
		}

		public bool OtherSegment(gp_Pnt2d P, gp_Lin2d L, ref double Par)
		{
			throw new NotImplementedException();
		}

		public void InitWires()
		{
			throw new NotImplementedException();
		}

		public bool MoreWires()
		{
			throw new NotImplementedException();
		}

		public void NextWire()
		{
			throw new NotImplementedException();
		}

		public bool RejectWire(gp_Lin2d L, double Par)
		{
			throw new NotImplementedException();
		}

		public void InitEdges()
		{
			throw new NotImplementedException();
		}

		public bool MoreEdges()
		{
			throw new NotImplementedException();
		}

		public void NextEdge()
		{
			throw new NotImplementedException();
		}

		public bool RejectEdge(gp_Lin2d L, double Par)
		{
			throw new NotImplementedException();
		}

		public void CurrentEdge(BRepClass_Edge E,  ref CascadeSharp.TopAbs_Orientation Or)
		{
			throw new NotImplementedException();
		}

		public void ComputeFaceBounds()
		{
			throw new NotImplementedException();
		}


	}; // class BRepClass_FaceExplorer

}
