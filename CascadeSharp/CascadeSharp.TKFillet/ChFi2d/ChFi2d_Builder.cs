//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  ChFi2d_Builder
	//---------------------------------------------------------------------
	public  sealed class ChFi2d_Builder
	{

		public ChFi2d_Builder()
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFi2d_Builder(TopoDS_Face F)
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFi2d_Builder(ChFi2d_Builder parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Face RefFace, TopoDS_Face ModFace)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge AddFillet(TopoDS_Vertex V, double Radius)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge ModifyFillet(TopoDS_Edge Fillet, double Radius)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex RemoveFillet(TopoDS_Edge Fillet)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge AddChamfer(TopoDS_Edge E1, TopoDS_Edge E2, double D1, double D2)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge AddChamfer(TopoDS_Edge E, TopoDS_Vertex V, double D, double Ang)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge ModifyChamfer(TopoDS_Edge Chamfer, TopoDS_Edge E1, TopoDS_Edge E2, double D1, double D2)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge ModifyChamfer(TopoDS_Edge Chamfer, TopoDS_Edge E, double D, double Ang)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex RemoveChamfer(TopoDS_Edge Chamfer)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Result()
		{
			throw new NotImplementedException();
		}

		public bool IsModified(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public TopTools_SequenceOfShape FilletEdges()
		{
			throw new NotImplementedException();
		}

		public int NbFillet()
		{
			throw new NotImplementedException();
		}

		public TopTools_SequenceOfShape ChamferEdges()
		{
			throw new NotImplementedException();
		}

		public int NbChamfer()
		{
			throw new NotImplementedException();
		}

		public bool HasDescendant(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge DescendantEdge(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge BasisEdge(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.ChFi2d_ConstructionError Status()
		{
			throw new NotImplementedException();
		}

		public void ComputeFillet(TopoDS_Vertex V, TopoDS_Edge E1, TopoDS_Edge E2, double Radius, TopoDS_Edge TrimE1, TopoDS_Edge TrimE2, TopoDS_Edge Fillet)
		{
			throw new NotImplementedException();
		}

		public void ComputeChamfer(TopoDS_Vertex V, TopoDS_Edge E1, TopoDS_Edge E2, double D1, double D2, TopoDS_Edge TrimE1, TopoDS_Edge TrimE2, TopoDS_Edge Chamfer)
		{
			throw new NotImplementedException();
		}

		public void ComputeChamfer(TopoDS_Vertex V, TopoDS_Edge E1, double D, double Ang, TopoDS_Edge E2, TopoDS_Edge TrimE1, TopoDS_Edge TrimE2, TopoDS_Edge Chamfer)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge BuildFilletEdge(TopoDS_Vertex V, TopoDS_Edge AdjEdge1, TopoDS_Edge AdjEdge2, double Radius, TopoDS_Vertex NewExtr1, TopoDS_Vertex NewExtr2)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge BuildChamferEdge(TopoDS_Vertex V, TopoDS_Edge AdjEdge1, TopoDS_Edge AdjEdge2, double D1, double D2, TopoDS_Vertex NewExtr1, TopoDS_Vertex NewExtr2)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge BuildChamferEdge(TopoDS_Vertex V, TopoDS_Edge AdjEdge2, double D, double Ang, TopoDS_Edge AdjEdge1, TopoDS_Vertex NewExtr1, TopoDS_Vertex NewExtr2)
		{
			throw new NotImplementedException();
		}

		public void BuildNewWire(TopoDS_Edge OldE1, TopoDS_Edge OldE2, TopoDS_Edge E1, TopoDS_Edge Fillet, TopoDS_Edge E2)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge BuildNewEdge(TopoDS_Edge E1, TopoDS_Vertex OldExtr, TopoDS_Vertex NewExtr)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge BuildNewEdge(TopoDS_Edge E1, TopoDS_Vertex OldExtr, TopoDS_Vertex NewExtr, ref bool IsDegenerated)
		{
			throw new NotImplementedException();
		}

		public void UpDateHistory(TopoDS_Edge E1, TopoDS_Edge E2, TopoDS_Edge TrimE1, TopoDS_Edge TrimE2, TopoDS_Edge NewEdge, int Id)
		{
			throw new NotImplementedException();
		}

		public void UpDateHistory(TopoDS_Edge E1, TopoDS_Edge E2, TopoDS_Edge TrimE1, TopoDS_Edge TrimE2)
		{
			throw new NotImplementedException();
		}

		public bool IsAFillet(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public bool IsAChamfer(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}


	}; // class ChFi2d_Builder

}
