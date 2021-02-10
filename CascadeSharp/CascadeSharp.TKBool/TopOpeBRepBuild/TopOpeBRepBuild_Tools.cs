//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepBuild_Tools
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepBuild_Tools
	{

		public TopOpeBRepBuild_Tools()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_Tools(TopOpeBRepBuild_Tools parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

						public CascadeSharp.TopAbs_State FindStateThroughVertex(TopoDS_Shape aShape, TopOpeBRepTool_ShapeClassifier aShapeClassifier, TopOpeBRepDS_IndexedDataMapOfShapeWithState aMapOfShapeWithState, TopTools_MapOfShape anAvoidSubshMap)
		{
			throw new NotImplementedException();
		}

		public void PropagateStateForWires(TopTools_IndexedMapOfShape aFacesToRestMap, TopOpeBRepDS_IndexedDataMapOfShapeWithState aMapOfShapeWithState)
		{
			throw new NotImplementedException();
		}

		public void SpreadStateToChild(TopoDS_Shape aShape, CascadeSharp.TopAbs_State aState, TopOpeBRepDS_IndexedDataMapOfShapeWithState aMapOfShapeWithState)
		{
			throw new NotImplementedException();
		}

						public bool GetAdjacentFace(TopoDS_Shape aFaceObj, TopoDS_Shape anEObj, TopTools_IndexedDataMapOfShapeListOfShape anEdgeFaceMap, TopoDS_Shape anAdjFaceObj)
		{
			throw new NotImplementedException();
		}

		public void GetNormalToFaceOnEdge(TopoDS_Face aFObj, TopoDS_Edge anEdgeObj, gp_Vec aDirNormal)
		{
			throw new NotImplementedException();
		}

		public void GetNormalInNearestPoint(TopoDS_Face aFace, TopoDS_Edge anEdge, gp_Vec aNormal)
		{
			throw new NotImplementedException();
		}

		public bool GetTangentToEdgeEdge(TopoDS_Face aFObj, TopoDS_Edge anEdgeObj, TopoDS_Edge aOriEObj, gp_Vec aTangent)
		{
			throw new NotImplementedException();
		}

		public bool GetTangentToEdge(TopoDS_Edge anEdgeObj, gp_Vec aTangent)
		{
			throw new NotImplementedException();
		}

		public void UpdatePCurves(TopoDS_Wire aWire, TopoDS_Face fromFace, TopoDS_Face toFace)
		{
			throw new NotImplementedException();
		}

		public void UpdateEdgeOnPeriodicalFace(TopoDS_Edge aEdgeToUpdate, TopoDS_Face OldFace, TopoDS_Face NewFace)
		{
			throw new NotImplementedException();
		}

		public void UpdateEdgeOnFace(TopoDS_Edge aEdgeToUpdate, TopoDS_Face OldFace, TopoDS_Face NewFace)
		{
			throw new NotImplementedException();
		}

		public bool IsDegEdgesTheSame(TopoDS_Shape anE1, TopoDS_Shape anE2)
		{
			throw new NotImplementedException();
		}

		public void NormalizeFace(TopoDS_Shape oldFace, TopoDS_Shape corrFace)
		{
			throw new NotImplementedException();
		}

		public void CorrectFace2d(TopoDS_Shape oldFace, TopoDS_Shape corrFace, TopTools_IndexedMapOfOrientedShape aSourceShapes, TopTools_IndexedDataMapOfShapeShape aMapOfCorrect2dEdges)
		{
			throw new NotImplementedException();
		}

		public void CorrectTolerances(TopoDS_Shape aS, double aTolMax)
		{
			throw new NotImplementedException();
		}

		public void CorrectTolerances(TopoDS_Shape aS)
		{
			throw new NotImplementedException();
		}

		public void CorrectCurveOnSurface(TopoDS_Shape aS, double aTolMax)
		{
			throw new NotImplementedException();
		}

		public void CorrectCurveOnSurface(TopoDS_Shape aS)
		{
			throw new NotImplementedException();
		}

		public void CorrectPointOnCurve(TopoDS_Shape aS, double aTolMax)
		{
			throw new NotImplementedException();
		}

		public void CorrectPointOnCurve(TopoDS_Shape aS)
		{
			throw new NotImplementedException();
		}

		public bool CheckFaceClosed2d(TopoDS_Face theFace)
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRepBuild_Tools

}
