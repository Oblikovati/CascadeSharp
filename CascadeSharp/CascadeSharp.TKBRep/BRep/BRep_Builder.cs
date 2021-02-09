//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRep_Builder
	//---------------------------------------------------------------------
	public  sealed class BRep_Builder : CascadeSharp.TopoDS_Builder
	{

		public BRep_Builder()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRep_Builder(BRep_Builder parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void MakeFace(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void MakeFace(TopoDS_Face F, Geom_Surface S, double Tol)
		{
			throw new NotImplementedException();
		}

		public void MakeFace(TopoDS_Face F, Geom_Surface S, TopLoc_Location L, double Tol)
		{
			throw new NotImplementedException();
		}

				public void UpdateFace(TopoDS_Face F, Geom_Surface S, TopLoc_Location L, double Tol)
		{
			throw new NotImplementedException();
		}

				public void UpdateFace(TopoDS_Face F, double Tol)
		{
			throw new NotImplementedException();
		}

		public void NaturalRestriction(TopoDS_Face F, bool N)
		{
			throw new NotImplementedException();
		}

		public void MakeEdge(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void MakeEdge(TopoDS_Edge E, Geom_Curve C, double Tol)
		{
			throw new NotImplementedException();
		}

		public void MakeEdge(TopoDS_Edge E, Geom_Curve C, TopLoc_Location L, double Tol)
		{
			throw new NotImplementedException();
		}

								public void UpdateEdge(TopoDS_Edge E, Geom_Curve C, double Tol)
		{
			throw new NotImplementedException();
		}

		public void UpdateEdge(TopoDS_Edge E, Geom_Curve C, TopLoc_Location L, double Tol)
		{
			throw new NotImplementedException();
		}

		public void UpdateEdge(TopoDS_Edge E, Geom2d_Curve C, TopoDS_Face F, double Tol)
		{
			throw new NotImplementedException();
		}

		public void UpdateEdge(TopoDS_Edge E, Geom2d_Curve C1, Geom2d_Curve C2, TopoDS_Face F, double Tol)
		{
			throw new NotImplementedException();
		}

		public void UpdateEdge(TopoDS_Edge E, Geom2d_Curve C, Geom_Surface S, TopLoc_Location L, double Tol)
		{
			throw new NotImplementedException();
		}

		public void UpdateEdge(TopoDS_Edge E, Geom2d_Curve C, Geom_Surface S, TopLoc_Location L, double Tol, gp_Pnt2d Pf, gp_Pnt2d Pl)
		{
			throw new NotImplementedException();
		}

		public void UpdateEdge(TopoDS_Edge E, Geom2d_Curve C1, Geom2d_Curve C2, Geom_Surface S, TopLoc_Location L, double Tol)
		{
			throw new NotImplementedException();
		}

		public void UpdateEdge(TopoDS_Edge E, Geom2d_Curve C1, Geom2d_Curve C2, Geom_Surface S, TopLoc_Location L, double Tol, gp_Pnt2d Pf, gp_Pnt2d Pl)
		{
			throw new NotImplementedException();
		}

																						public void UpdateEdge(TopoDS_Edge E, double Tol)
		{
			throw new NotImplementedException();
		}

		public void Continuity(TopoDS_Edge E, TopoDS_Face F1, TopoDS_Face F2, CascadeSharp.GeomAbs_Shape C)
		{
			throw new NotImplementedException();
		}

		public void Continuity(TopoDS_Edge E, Geom_Surface S1, Geom_Surface S2, TopLoc_Location L1, TopLoc_Location L2, CascadeSharp.GeomAbs_Shape C)
		{
			throw new NotImplementedException();
		}

		public void SameParameter(TopoDS_Edge E, bool S)
		{
			throw new NotImplementedException();
		}

		public void SameRange(TopoDS_Edge E, bool S)
		{
			throw new NotImplementedException();
		}

		public void Degenerated(TopoDS_Edge E, bool D)
		{
			throw new NotImplementedException();
		}

		public void Range(TopoDS_Edge E, double First, double Last, bool Only3d)
		{
			throw new NotImplementedException();
		}

		public void Range(TopoDS_Edge E, double First, double Last)
		{
			throw new NotImplementedException();
		}

		public void Range(TopoDS_Edge E, Geom_Surface S, TopLoc_Location L, double First, double Last)
		{
			throw new NotImplementedException();
		}

		public void Range(TopoDS_Edge E, TopoDS_Face F, double First, double Last)
		{
			throw new NotImplementedException();
		}

		public void Transfert(TopoDS_Edge Ein, TopoDS_Edge Eout)
		{
			throw new NotImplementedException();
		}

		public void MakeVertex(TopoDS_Vertex V)
		{
			throw new NotImplementedException();
		}

		public void MakeVertex(TopoDS_Vertex V, gp_Pnt P, double Tol)
		{
			throw new NotImplementedException();
		}

		public void UpdateVertex(TopoDS_Vertex V, gp_Pnt P, double Tol)
		{
			throw new NotImplementedException();
		}

		public void UpdateVertex(TopoDS_Vertex V, double P, TopoDS_Edge E, double Tol)
		{
			throw new NotImplementedException();
		}

		public void UpdateVertex(TopoDS_Vertex V, double P, TopoDS_Edge E, TopoDS_Face F, double Tol)
		{
			throw new NotImplementedException();
		}

		public void UpdateVertex(TopoDS_Vertex V, double P, TopoDS_Edge E, Geom_Surface S, TopLoc_Location L, double Tol)
		{
			throw new NotImplementedException();
		}

		public void UpdateVertex(TopoDS_Vertex Ve, double U, double V, TopoDS_Face F, double Tol)
		{
			throw new NotImplementedException();
		}

		public void UpdateVertex(TopoDS_Vertex V, double Tol)
		{
			throw new NotImplementedException();
		}

		public void Transfert(TopoDS_Edge Ein, TopoDS_Edge Eout, TopoDS_Vertex Vin, TopoDS_Vertex Vout)
		{
			throw new NotImplementedException();
		}


	}; // class BRep_Builder

}
