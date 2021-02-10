//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepFeat_RibSlot
	//---------------------------------------------------------------------
	public  class BRepFeat_RibSlot : CascadeSharp.BRepBuilderAPI_MakeShape
	{

		public BRepFeat_RibSlot()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFeat_RibSlot(BRepFeat_RibSlot parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public bool IsDeleted(TopoDS_Shape F)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Modified(TopoDS_Shape F)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Generated(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape FirstShape()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape LastShape()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape FacesForDraft()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape NewEdges()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape TgtEdges()
		{
			throw new NotImplementedException();
		}

		public double IntPar(Geom_Curve C, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face ChoiceOfFaces(TopTools_ListOfShape faces, Geom_Curve cc, double par, double bnd, Geom_Plane Pln)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.BRepFeat_StatusError CurrentStatusError()
		{
			throw new NotImplementedException();
		}

		public void LFPerform()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt CheckPoint(TopoDS_Edge e, double bnd, Geom_Plane Pln)
		{
			throw new NotImplementedException();
		}

		public gp_Dir Normal(TopoDS_Face F, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void EdgeExtention(TopoDS_Edge e, double bnd, bool FirstLast)
		{
			throw new NotImplementedException();
		}

		public double HeightMax(TopoDS_Shape theSbase, TopoDS_Shape theSUntil, gp_Pnt p1, gp_Pnt p2)
		{
			throw new NotImplementedException();
		}

		public bool ExtremeFaces(bool RevolRib, double bnd, Geom_Plane Pln, TopoDS_Edge FirstEdge, TopoDS_Edge LastEdge, TopoDS_Face FirstFace, TopoDS_Face LastFace, TopoDS_Vertex FirstVertex, TopoDS_Vertex LastVertex, ref bool OnFirstFace, ref bool OnLastFace, ref bool PtOnFirstEdge, ref bool PtOnLastEdge, TopoDS_Edge OnFirstEdge, TopoDS_Edge OnLastEdge)
		{
			throw new NotImplementedException();
		}

		public void PtOnEdgeVertex(bool RevolRib, TopoDS_Shape shape, gp_Pnt point, TopoDS_Vertex FirstVertex, TopoDS_Vertex LastVertex, ref bool PtOnEdge, TopoDS_Edge OnEdge, ref bool PtOnVertex, TopoDS_Vertex OnVertex)
		{
			throw new NotImplementedException();
		}

		public bool SlidingProfile(TopoDS_Face Prof, bool RevolRib, double myTol, ref int Concavite, Geom_Plane myPln, TopoDS_Face BndFace, gp_Pnt CheckPnt, TopoDS_Face FirstFace, TopoDS_Face LastFace, TopoDS_Vertex FirstVertex, TopoDS_Vertex LastVertex, TopoDS_Edge FirstEdge, TopoDS_Edge LastEdge)
		{
			throw new NotImplementedException();
		}

		public bool NoSlidingProfile(TopoDS_Face Prof, bool RevolRib, double myTol, ref int Concavite, Geom_Plane myPln, double bnd, TopoDS_Face BndFace, gp_Pnt CheckPnt, TopoDS_Face FirstFace, TopoDS_Face LastFace, TopoDS_Vertex FirstVertex, TopoDS_Vertex LastVertex, TopoDS_Edge FirstEdge, TopoDS_Edge LastEdge, bool OnFirstFace, bool OnLastFace)
		{
			throw new NotImplementedException();
		}

		public void UpdateDescendants(LocOpe_Gluer G)
		{
			throw new NotImplementedException();
		}

		public void UpdateDescendants(BRepAlgoAPI_BooleanOperation aBOP, TopoDS_Shape SResult, bool SkipFace)
		{
			throw new NotImplementedException();
		}

		public void UpdateDescendants(BRepAlgoAPI_BooleanOperation aBOP, TopoDS_Shape SResult)
		{
			throw new NotImplementedException();
		}


	}; // class BRepFeat_RibSlot

}
