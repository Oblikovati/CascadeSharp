//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepLib
	//---------------------------------------------------------------------
	public  sealed class BRepLib
	{

		public BRepLib()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepLib(BRepLib parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Precision(double P)
		{
			throw new NotImplementedException();
		}

		public double Precision()
		{
			throw new NotImplementedException();
		}

		public void Plane(Geom_Plane P)
		{
			throw new NotImplementedException();
		}

		public Geom_Plane Plane()
		{
			throw new NotImplementedException();
		}

		public bool CheckSameRange(TopoDS_Edge E, double Confusion)
		{
			throw new NotImplementedException();
		}

		public bool CheckSameRange(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void SameRange(TopoDS_Edge E, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public void SameRange(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public bool BuildCurve3d(TopoDS_Edge E, double Tolerance, CascadeSharp.GeomAbs_Shape Continuity, int MaxDegree, int MaxSegment)
		{
			throw new NotImplementedException();
		}

		public bool BuildCurve3d(TopoDS_Edge E, double Tolerance, CascadeSharp.GeomAbs_Shape Continuity, int MaxDegree)
		{
			throw new NotImplementedException();
		}

		public bool BuildCurve3d(TopoDS_Edge E, double Tolerance, CascadeSharp.GeomAbs_Shape Continuity)
		{
			throw new NotImplementedException();
		}

		public bool BuildCurve3d(TopoDS_Edge E, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public bool BuildCurve3d(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public bool BuildCurves3d(TopoDS_Shape S, double Tolerance, CascadeSharp.GeomAbs_Shape Continuity, int MaxDegree, int MaxSegment)
		{
			throw new NotImplementedException();
		}

		public bool BuildCurves3d(TopoDS_Shape S, double Tolerance, CascadeSharp.GeomAbs_Shape Continuity, int MaxDegree)
		{
			throw new NotImplementedException();
		}

		public bool BuildCurves3d(TopoDS_Shape S, double Tolerance, CascadeSharp.GeomAbs_Shape Continuity)
		{
			throw new NotImplementedException();
		}

		public bool BuildCurves3d(TopoDS_Shape S, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public bool BuildCurves3d(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void BuildPCurveForEdgeOnPlane(TopoDS_Edge theE, TopoDS_Face theF)
		{
			throw new NotImplementedException();
		}

		public void BuildPCurveForEdgeOnPlane(TopoDS_Edge theE, TopoDS_Face theF, Geom2d_Curve aC2D, ref bool bToUpdate)
		{
			throw new NotImplementedException();
		}

		public bool UpdateEdgeTol(TopoDS_Edge E, double MinToleranceRequest, double MaxToleranceToCheck)
		{
			throw new NotImplementedException();
		}

		public bool UpdateEdgeTolerance(TopoDS_Shape S, double MinToleranceRequest, double MaxToleranceToCheck)
		{
			throw new NotImplementedException();
		}

		public void SameParameter(TopoDS_Edge theEdge, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public void SameParameter(TopoDS_Edge theEdge)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge SameParameter(TopoDS_Edge theEdge, double theTolerance, ref double theNewTol, bool IsUseOldEdge)
		{
			throw new NotImplementedException();
		}

		public void SameParameter(TopoDS_Shape S, double Tolerance, bool forced)
		{
			throw new NotImplementedException();
		}

		public void SameParameter(TopoDS_Shape S, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public void SameParameter(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void SameParameter(TopoDS_Shape S, BRepTools_ReShape theReshaper, double Tolerance, bool forced)
		{
			throw new NotImplementedException();
		}

		public void SameParameter(TopoDS_Shape S, BRepTools_ReShape theReshaper, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public void SameParameter(TopoDS_Shape S, BRepTools_ReShape theReshaper)
		{
			throw new NotImplementedException();
		}

		public void UpdateTolerances(TopoDS_Shape S, bool verifyFaceTolerance)
		{
			throw new NotImplementedException();
		}

		public void UpdateTolerances(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void UpdateTolerances(TopoDS_Shape S, BRepTools_ReShape theReshaper, bool verifyFaceTolerance)
		{
			throw new NotImplementedException();
		}

		public void UpdateTolerances(TopoDS_Shape S, BRepTools_ReShape theReshaper)
		{
			throw new NotImplementedException();
		}

		public void UpdateInnerTolerances(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public bool OrientClosedSolid(TopoDS_Solid solid)
		{
			throw new NotImplementedException();
		}

		public void EncodeRegularity(TopoDS_Shape S, double TolAng)
		{
			throw new NotImplementedException();
		}

		public void EncodeRegularity(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void EncodeRegularity(TopoDS_Shape S, TopTools_ListOfShape LE, double TolAng)
		{
			throw new NotImplementedException();
		}

		public void EncodeRegularity(TopoDS_Shape S, TopTools_ListOfShape LE)
		{
			throw new NotImplementedException();
		}

		public void EncodeRegularity(TopoDS_Edge E, TopoDS_Face F1, TopoDS_Face F2, double TolAng)
		{
			throw new NotImplementedException();
		}

		public void EncodeRegularity(TopoDS_Edge E, TopoDS_Face F1, TopoDS_Face F2)
		{
			throw new NotImplementedException();
		}

		public void SortFaces(TopoDS_Shape S, TopTools_ListOfShape LF)
		{
			throw new NotImplementedException();
		}

		public void ReverseSortFaces(TopoDS_Shape S, TopTools_ListOfShape LF)
		{
			throw new NotImplementedException();
		}

		public bool EnsureNormalConsistency(TopoDS_Shape S, double theAngTol, bool ForceComputeNormals)
		{
			throw new NotImplementedException();
		}

		public bool EnsureNormalConsistency(TopoDS_Shape S, double theAngTol)
		{
			throw new NotImplementedException();
		}

		public bool EnsureNormalConsistency(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

				public bool FindValidRange(Adaptor3d_Curve theCurve, double theTolE, double theParV1, gp_Pnt thePntV1, double theTolV1, double theParV2, gp_Pnt thePntV2, double theTolV2, ref double theFirst, ref double theLast)
		{
			throw new NotImplementedException();
		}

		public bool FindValidRange(TopoDS_Edge theEdge, ref double theFirst, ref double theLast)
		{
			throw new NotImplementedException();
		}

		public void ExtendFace(TopoDS_Face theF, double theExtVal, bool theExtUMin, bool theExtUMax, bool theExtVMin, bool theExtVMax, TopoDS_Face theFExtended)
		{
			throw new NotImplementedException();
		}


	}; // class BRepLib

}
