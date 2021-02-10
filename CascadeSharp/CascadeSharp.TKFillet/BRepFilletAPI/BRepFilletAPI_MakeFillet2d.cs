//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKFillet.ChFi2d;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKFillet.BRepFilletAPI
{
	//---------------------------------------------------------------------
	//  Class  BRepFilletAPI_MakeFillet2d
	//---------------------------------------------------------------------
	public  sealed class BRepFilletAPI_MakeFillet2d : BRepBuilderAPI_MakeShape
	{

		public BRepFilletAPI_MakeFillet2d()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFilletAPI_MakeFillet2d(TopoDS_Face F)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFilletAPI_MakeFillet2d(BRepFilletAPI_MakeFillet2d parameter1)
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

		public TopTools_ListOfShape Modified(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public int NbCurves()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape NewEdges(int I)
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

		public ChFi2d_ConstructionError Status()
		{
			throw new NotImplementedException();
		}

		public void Build()
		{
			throw new NotImplementedException();
		}


	}; // class BRepFilletAPI_MakeFillet2d

}
