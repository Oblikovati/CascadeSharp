//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeAnalysis
{
	//---------------------------------------------------------------------
	//  Class  ShapeAnalysis_Edge
	//---------------------------------------------------------------------
	public  sealed class ShapeAnalysis_Edge
	{

		public ShapeAnalysis_Edge()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_Edge(ShapeAnalysis_Edge parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public bool HasCurve3d(TopoDS_Edge edge)
		{
			throw new NotImplementedException();
		}

		public bool Curve3d(TopoDS_Edge edge, Geom_Curve C3d, ref double cf, ref double cl, bool orient)
		{
			throw new NotImplementedException();
		}

		public bool Curve3d(TopoDS_Edge edge, Geom_Curve C3d, ref double cf, ref double cl)
		{
			throw new NotImplementedException();
		}

		public bool IsClosed3d(TopoDS_Edge edge)
		{
			throw new NotImplementedException();
		}

		public bool HasPCurve(TopoDS_Edge edge, TopoDS_Face face)
		{
			throw new NotImplementedException();
		}

		public bool HasPCurve(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location)
		{
			throw new NotImplementedException();
		}

		public bool PCurve(TopoDS_Edge edge, TopoDS_Face face, Geom2d_Curve C2d, ref double cf, ref double cl, bool orient)
		{
			throw new NotImplementedException();
		}

		public bool PCurve(TopoDS_Edge edge, TopoDS_Face face, Geom2d_Curve C2d, ref double cf, ref double cl)
		{
			throw new NotImplementedException();
		}

		public bool PCurve(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location, Geom2d_Curve C2d, ref double cf, ref double cl, bool orient)
		{
			throw new NotImplementedException();
		}

		public bool PCurve(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location, Geom2d_Curve C2d, ref double cf, ref double cl)
		{
			throw new NotImplementedException();
		}

		public bool BoundUV(TopoDS_Edge edge, TopoDS_Face face, gp_Pnt2d first, gp_Pnt2d last)
		{
			throw new NotImplementedException();
		}

		public bool BoundUV(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location, gp_Pnt2d first, gp_Pnt2d last)
		{
			throw new NotImplementedException();
		}

		public bool IsSeam(TopoDS_Edge edge, TopoDS_Face face)
		{
			throw new NotImplementedException();
		}

		public bool IsSeam(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex FirstVertex(TopoDS_Edge edge)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex LastVertex(TopoDS_Edge edge)
		{
			throw new NotImplementedException();
		}

		public bool GetEndTangent2d(TopoDS_Edge edge, TopoDS_Face face, bool atEnd, gp_Pnt2d pos, gp_Vec2d tang, double dparam)
		{
			throw new NotImplementedException();
		}

		public bool GetEndTangent2d(TopoDS_Edge edge, TopoDS_Face face, bool atEnd, gp_Pnt2d pos, gp_Vec2d tang)
		{
			throw new NotImplementedException();
		}

		public bool GetEndTangent2d(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location, bool atEnd, gp_Pnt2d pos, gp_Vec2d tang, double dparam)
		{
			throw new NotImplementedException();
		}

		public bool GetEndTangent2d(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location, bool atEnd, gp_Pnt2d pos, gp_Vec2d tang)
		{
			throw new NotImplementedException();
		}

		public bool CheckVerticesWithCurve3d(TopoDS_Edge edge, double preci, int vtx)
		{
			throw new NotImplementedException();
		}

		public bool CheckVerticesWithCurve3d(TopoDS_Edge edge, double preci)
		{
			throw new NotImplementedException();
		}

		public bool CheckVerticesWithCurve3d(TopoDS_Edge edge)
		{
			throw new NotImplementedException();
		}

		public bool CheckVerticesWithPCurve(TopoDS_Edge edge, TopoDS_Face face, double preci, int vtx)
		{
			throw new NotImplementedException();
		}

		public bool CheckVerticesWithPCurve(TopoDS_Edge edge, TopoDS_Face face, double preci)
		{
			throw new NotImplementedException();
		}

		public bool CheckVerticesWithPCurve(TopoDS_Edge edge, TopoDS_Face face)
		{
			throw new NotImplementedException();
		}

		public bool CheckVerticesWithPCurve(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location, double preci, int vtx)
		{
			throw new NotImplementedException();
		}

		public bool CheckVerticesWithPCurve(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location, double preci)
		{
			throw new NotImplementedException();
		}

		public bool CheckVerticesWithPCurve(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location)
		{
			throw new NotImplementedException();
		}

		public bool CheckVertexTolerance(TopoDS_Edge edge, TopoDS_Face face, ref double toler1, ref double toler2)
		{
			throw new NotImplementedException();
		}

		public bool CheckVertexTolerance(TopoDS_Edge edge, ref double toler1, ref double toler2)
		{
			throw new NotImplementedException();
		}

		public bool CheckCurve3dWithPCurve(TopoDS_Edge edge, TopoDS_Face face)
		{
			throw new NotImplementedException();
		}

		public bool CheckCurve3dWithPCurve(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location)
		{
			throw new NotImplementedException();
		}

		public bool Status(ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public bool CheckSameParameter(TopoDS_Edge edge, ref double maxdev, int NbControl)
		{
			throw new NotImplementedException();
		}

		public bool CheckSameParameter(TopoDS_Edge edge, ref double maxdev)
		{
			throw new NotImplementedException();
		}

		public bool CheckSameParameter(TopoDS_Edge theEdge, TopoDS_Face theFace, ref double theMaxdev, int theNbControl)
		{
			throw new NotImplementedException();
		}

		public bool CheckSameParameter(TopoDS_Edge theEdge, TopoDS_Face theFace, ref double theMaxdev)
		{
			throw new NotImplementedException();
		}

		public bool CheckPCurveRange(double theFirst, double theLast, Geom2d_Curve thePC)
		{
			throw new NotImplementedException();
		}

		public bool ComputeDeviation(Adaptor3d_Curve CRef, Adaptor3d_Curve Other, bool SameParameter, ref double dev, int NCONTROL)
		{
			throw new NotImplementedException();
		}

		public bool CheckOverlapping(TopoDS_Edge theEdge1, TopoDS_Edge theEdge2, ref double theTolOverlap, double theDomainD_ist)
		{
			throw new NotImplementedException();
		}

		public bool CheckOverlapping(TopoDS_Edge theEdge1, TopoDS_Edge theEdge2, ref double theTolOverlap)
		{
			throw new NotImplementedException();
		}

		public bool CheckPoints(gp_Pnt P1A, gp_Pnt P1B, gp_Pnt P2A, gp_Pnt P2B, double preci1, double preci2)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeAnalysis_Edge

}
