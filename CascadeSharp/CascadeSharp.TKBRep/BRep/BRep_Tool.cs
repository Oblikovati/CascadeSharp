//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.BRep
{
	//---------------------------------------------------------------------
	//  Class  BRep_Tool
	//---------------------------------------------------------------------
	public  sealed class BRep_Tool
	{

		public BRep_Tool()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRep_Tool(BRep_Tool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public bool IsClosed(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface Surface(TopoDS_Face F, TopLoc_Location L)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface Surface(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

				public double Tolerance(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool NaturalRestriction(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool IsGeometric(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool IsGeometric(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve Curve(TopoDS_Edge E, TopLoc_Location L, ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve Curve(TopoDS_Edge E, ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

				public Geom2d_Curve CurveOnSurface(TopoDS_Edge E, TopoDS_Face F, ref double First, ref double Last, ref bool theIsStored)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve CurveOnSurface(TopoDS_Edge E, TopoDS_Face F, ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve CurveOnSurface(TopoDS_Edge E, Geom_Surface S, TopLoc_Location L, ref double First, ref double Last, ref bool theIsStored)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve CurveOnSurface(TopoDS_Edge E, Geom_Surface S, TopLoc_Location L, ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve CurveOnPlane(TopoDS_Edge E, Geom_Surface S, TopLoc_Location L, ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public void CurveOnSurface(TopoDS_Edge E, Geom2d_Curve C, Geom_Surface S, TopLoc_Location L, ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public void CurveOnSurface(TopoDS_Edge E, Geom2d_Curve C, Geom_Surface S, TopLoc_Location L, ref double First, ref double Last, int Index)
		{
			throw new NotImplementedException();
		}

																public bool IsClosed(TopoDS_Edge E, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool IsClosed(TopoDS_Edge E, Geom_Surface S, TopLoc_Location L)
		{
			throw new NotImplementedException();
		}

				public double Tolerance(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public bool SameParameter(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public bool SameRange(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public bool Degenerated(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void Range(TopoDS_Edge E, ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public void Range(TopoDS_Edge E, Geom_Surface S, TopLoc_Location L, ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public void Range(TopoDS_Edge E, TopoDS_Face F, ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public void UVPoints(TopoDS_Edge E, Geom_Surface S, TopLoc_Location L, gp_Pnt2d PFirst, gp_Pnt2d PLast)
		{
			throw new NotImplementedException();
		}

		public void UVPoints(TopoDS_Edge E, TopoDS_Face F, gp_Pnt2d PFirst, gp_Pnt2d PLast)
		{
			throw new NotImplementedException();
		}

		public void SetUVPoints(TopoDS_Edge E, Geom_Surface S, TopLoc_Location L, gp_Pnt2d PFirst, gp_Pnt2d PLast)
		{
			throw new NotImplementedException();
		}

		public void SetUVPoints(TopoDS_Edge E, TopoDS_Face F, gp_Pnt2d PFirst, gp_Pnt2d PLast)
		{
			throw new NotImplementedException();
		}

		public bool HasContinuity(TopoDS_Edge E, TopoDS_Face F1, TopoDS_Face F2)
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape Continuity(TopoDS_Edge E, TopoDS_Face F1, TopoDS_Face F2)
		{
			throw new NotImplementedException();
		}

		public bool HasContinuity(TopoDS_Edge E, Geom_Surface S1, Geom_Surface S2, TopLoc_Location L1, TopLoc_Location L2)
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape Continuity(TopoDS_Edge E, Geom_Surface S1, Geom_Surface S2, TopLoc_Location L1, TopLoc_Location L2)
		{
			throw new NotImplementedException();
		}

		public bool HasContinuity(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape MaxContinuity(TopoDS_Edge theEdge)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Pnt(TopoDS_Vertex V)
		{
			throw new NotImplementedException();
		}

		public double Tolerance(TopoDS_Vertex V)
		{
			throw new NotImplementedException();
		}

		public bool Parameter(TopoDS_Vertex theV, TopoDS_Edge theE, ref double theParam)
		{
			throw new NotImplementedException();
		}

		public double Parameter(TopoDS_Vertex V, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public double Parameter(TopoDS_Vertex V, TopoDS_Edge E, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public double Parameter(TopoDS_Vertex V, TopoDS_Edge E, Geom_Surface S, TopLoc_Location L)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d Parameters(TopoDS_Vertex V, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public double MaxTolerance(TopoDS_Shape theShape, TopAbs_ShapeEnum theSubShape)
		{
			throw new NotImplementedException();
		}


	}; // class BRep_Tool

}
