//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBO.IntTools;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKernel.Message;
using CascadeSharp.TKernel.NCollection;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBO.BOPTools
{
	//---------------------------------------------------------------------
	//  Class  BOPTools_AlgoTools
	//---------------------------------------------------------------------
	public  sealed class BOPTools_AlgoTools
	{

		public BOPTools_AlgoTools()
			: base()
		{
			throw new NotImplementedException();
		}

		public BOPTools_AlgoTools(BOPTools_AlgoTools parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public double DTolerance()
		{
			throw new NotImplementedException();
		}

		public int ComputeVV(TopoDS_Vertex theV, gp_Pnt theP, double theTolP)
		{
			throw new NotImplementedException();
		}

		public int ComputeVV(TopoDS_Vertex theV1, TopoDS_Vertex theV2, double theFuzz)
		{
			throw new NotImplementedException();
		}

		public int ComputeVV(TopoDS_Vertex theV1, TopoDS_Vertex theV2)
		{
			throw new NotImplementedException();
		}

		public void MakeVertex(TopTools_ListOfShape theLV, TopoDS_Vertex theV)
		{
			throw new NotImplementedException();
		}

		public void MakeNewVertex(gp_Pnt aP1, double aTol, TopoDS_Vertex aNewVertex)
		{
			throw new NotImplementedException();
		}

		public void MakeNewVertex(TopoDS_Vertex aV1, TopoDS_Vertex aV2, TopoDS_Vertex aNewVertex)
		{
			throw new NotImplementedException();
		}

		public void MakeNewVertex(TopoDS_Edge aE1, double aP1, TopoDS_Edge aE2, double aP2, TopoDS_Vertex aNewVertex)
		{
			throw new NotImplementedException();
		}

		public void MakeNewVertex(TopoDS_Edge aE1, double aP1, TopoDS_Face aF2, TopoDS_Vertex aNewVertex)
		{
			throw new NotImplementedException();
		}

		public void UpdateVertex(IntTools_Curve aIC, double aT, TopoDS_Vertex aV)
		{
			throw new NotImplementedException();
		}

		public void UpdateVertex(TopoDS_Edge aE, double aT, TopoDS_Vertex aV)
		{
			throw new NotImplementedException();
		}

		public void UpdateVertex(TopoDS_Vertex aVF, TopoDS_Vertex aVN)
		{
			throw new NotImplementedException();
		}

		public void MakeEdge(IntTools_Curve theCurve, TopoDS_Vertex theV1, double theT1, TopoDS_Vertex theV2, double theT2, double theTolR3D, TopoDS_Edge theE)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge CopyEdge(TopoDS_Edge theEdge)
		{
			throw new NotImplementedException();
		}

		public void MakeSplitEdge(TopoDS_Edge aE1, TopoDS_Vertex aV1, double aP1, TopoDS_Vertex aV2, double aP2, TopoDS_Edge aNewEdge)
		{
			throw new NotImplementedException();
		}

		public void MakeSectEdge(IntTools_Curve aIC, TopoDS_Vertex aV1, double aP1, TopoDS_Vertex aV2, double aP2, TopoDS_Edge aNewEdge)
		{
			throw new NotImplementedException();
		}

		public TopAbs_State ComputeState(gp_Pnt thePoint, TopoDS_Solid theSolid, double theTol, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public TopAbs_State ComputeState(TopoDS_Vertex theVertex, TopoDS_Solid theSolid, double theTol, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public TopAbs_State ComputeState(TopoDS_Edge theEdge, TopoDS_Solid theSolid, double theTol, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public TopAbs_State ComputeState(TopoDS_Face theFace, TopoDS_Solid theSolid, double theTol, TopTools_IndexedMapOfShape theBounds, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public TopAbs_State ComputeStateByOnePoint(TopoDS_Shape theShape, TopoDS_Solid theSolid, double theTol, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public bool GetFaceOff(TopoDS_Edge theEdge, TopoDS_Face theFace, BOPTools_ListOfCoupleOfShape theLCEF, TopoDS_Face theFaceOff, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public int IsInternalFace(TopoDS_Face theFace, TopoDS_Edge theEdge, TopoDS_Face theFace1, TopoDS_Face theFace2, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public int IsInternalFace(TopoDS_Face theFace, TopoDS_Edge theEdge, TopTools_ListOfShape theLF, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public bool IsInternalFace(TopoDS_Face theFace, TopoDS_Solid theSolid, TopTools_IndexedDataMapOfShapeListOfShape theMEF, double theTol, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public void MakePCurve(TopoDS_Edge theE, TopoDS_Face theF1, TopoDS_Face theF2, IntTools_Curve theCurve, bool thePC1, bool thePC2, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public void MakePCurve(TopoDS_Edge theE, TopoDS_Face theF1, TopoDS_Face theF2, IntTools_Curve theCurve, bool thePC1, bool thePC2)
		{
			throw new NotImplementedException();
		}

		public bool IsHole(TopoDS_Shape theW, TopoDS_Shape theF)
		{
			throw new NotImplementedException();
		}

		public bool IsSplitToReverse(TopoDS_Shape theSplit, TopoDS_Shape theShape, IntTools_Context theContext, ref int theError)
		{
			throw new NotImplementedException();
		}

		public bool IsSplitToReverse(TopoDS_Shape theSplit, TopoDS_Shape theShape, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public bool IsSplitToReverseWithWarn(TopoDS_Shape theSplit, TopoDS_Shape theShape, IntTools_Context theContext, Message_Report theReport)
		{
			throw new NotImplementedException();
		}

		public bool IsSplitToReverseWithWarn(TopoDS_Shape theSplit, TopoDS_Shape theShape, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public bool IsSplitToReverse(TopoDS_Face theSplit, TopoDS_Face theShape, IntTools_Context theContext, ref int theError)
		{
			throw new NotImplementedException();
		}

		public bool IsSplitToReverse(TopoDS_Face theSplit, TopoDS_Face theShape, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public bool IsSplitToReverse(TopoDS_Edge theSplit, TopoDS_Edge theShape, IntTools_Context theContext, ref int theError)
		{
			throw new NotImplementedException();
		}

		public bool IsSplitToReverse(TopoDS_Edge theSplit, TopoDS_Edge theShape, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public int Sense(TopoDS_Face theF1, TopoDS_Face theF2, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public void MakeConnexityBlock(TopTools_ListOfShape theLS, TopTools_IndexedMapOfShape theMapAvoid, TopTools_ListOfShape theLSCB, NCollection_BaseAllocator theAllocator)
		{
			throw new NotImplementedException();
		}

		public void MakeConnexityBlocks(TopoDS_Shape theS, TopAbs_ShapeEnum theConnectionType, TopAbs_ShapeEnum theElementType, TopTools_ListOfShape theLCB)
		{
			throw new NotImplementedException();
		}

		public void MakeConnexityBlocks(TopoDS_Shape theS, TopAbs_ShapeEnum theConnectionType, TopAbs_ShapeEnum theElementType, TopTools_ListOfListOfShape theLCB, TopTools_IndexedDataMapOfShapeListOfShape theConnectionMap)
		{
			throw new NotImplementedException();
		}

		public void MakeConnexityBlocks(TopTools_ListOfShape theLS, TopAbs_ShapeEnum theConnectionType, TopAbs_ShapeEnum theElementType, BOPTools_ListOfConnexityBlock theLCB)
		{
			throw new NotImplementedException();
		}

		public void OrientEdgesOnWire(TopoDS_Shape theWire)
		{
			throw new NotImplementedException();
		}

		public void OrientFacesOnShell(TopoDS_Shape theShell)
		{
			throw new NotImplementedException();
		}

		public void CorrectTolerances(TopoDS_Shape theS, TopTools_IndexedMapOfShape theMapToAvoid, double theTolMax, bool theRunParallel)
		{
			throw new NotImplementedException();
		}

		public void CorrectTolerances(TopoDS_Shape theS, TopTools_IndexedMapOfShape theMapToAvoid, double theTolMax)
		{
			throw new NotImplementedException();
		}

		public void CorrectTolerances(TopoDS_Shape theS, TopTools_IndexedMapOfShape theMapToAvoid)
		{
			throw new NotImplementedException();
		}

		public void CorrectCurveOnSurface(TopoDS_Shape theS, TopTools_IndexedMapOfShape theMapToAvoid, double theTolMax, bool theRunParallel)
		{
			throw new NotImplementedException();
		}

		public void CorrectCurveOnSurface(TopoDS_Shape theS, TopTools_IndexedMapOfShape theMapToAvoid, double theTolMax)
		{
			throw new NotImplementedException();
		}

		public void CorrectCurveOnSurface(TopoDS_Shape theS, TopTools_IndexedMapOfShape theMapToAvoid)
		{
			throw new NotImplementedException();
		}

		public void CorrectPointOnCurve(TopoDS_Shape theS, TopTools_IndexedMapOfShape theMapToAvoid, double theTolMax, bool theRunParallel)
		{
			throw new NotImplementedException();
		}

		public void CorrectPointOnCurve(TopoDS_Shape theS, TopTools_IndexedMapOfShape theMapToAvoid, double theTolMax)
		{
			throw new NotImplementedException();
		}

		public void CorrectPointOnCurve(TopoDS_Shape theS, TopTools_IndexedMapOfShape theMapToAvoid)
		{
			throw new NotImplementedException();
		}

		public void CorrectShapeTolerances(TopoDS_Shape theS, TopTools_IndexedMapOfShape theMapToAvoid, bool theRunParallel)
		{
			throw new NotImplementedException();
		}

		public void CorrectShapeTolerances(TopoDS_Shape theS, TopTools_IndexedMapOfShape theMapToAvoid)
		{
			throw new NotImplementedException();
		}

		public bool AreFacesSameDomain(TopoDS_Face theF1, TopoDS_Face theF2, IntTools_Context theContext, double theFuzz)
		{
			throw new NotImplementedException();
		}

		public bool AreFacesSameDomain(TopoDS_Face theF1, TopoDS_Face theF2, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public bool GetEdgeOff(TopoDS_Edge theEdge, TopoDS_Face theFace, TopoDS_Edge theEdgeOff)
		{
			throw new NotImplementedException();
		}

		public bool GetEdgeOnFace(TopoDS_Edge theEdge, TopoDS_Face theFace, TopoDS_Edge theEdgeOnF)
		{
			throw new NotImplementedException();
		}

		public void CorrectRange(TopoDS_Edge aE1, TopoDS_Edge aE2, IntTools_Range aSR, IntTools_Range aNewSR)
		{
			throw new NotImplementedException();
		}

		public void CorrectRange(TopoDS_Edge aE, TopoDS_Face aF, IntTools_Range aSR, IntTools_Range aNewSR)
		{
			throw new NotImplementedException();
		}

		public bool IsMicroEdge(TopoDS_Edge theEdge, IntTools_Context theContext, bool theCheckSplittable)
		{
			throw new NotImplementedException();
		}

		public bool IsMicroEdge(TopoDS_Edge theEdge, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public bool IsInvertedSolid(TopoDS_Solid theSolid)
		{
			throw new NotImplementedException();
		}

		public bool ComputeTolerance(TopoDS_Face theFace, TopoDS_Edge theEdge, ref double theMaxD_ist, ref double theMaxPar)
		{
			throw new NotImplementedException();
		}

		public void MakeContainer(TopAbs_ShapeEnum theType, TopoDS_Shape theShape)
		{
			throw new NotImplementedException();
		}

		public void PointOnEdge(TopoDS_Edge aEdge, double aPrm, gp_Pnt aP)
		{
			throw new NotImplementedException();
		}

		public bool IsBlockInOnFace(IntTools_Range aShR, TopoDS_Face aF, TopoDS_Edge aE, IntTools_Context aContext)
		{
			throw new NotImplementedException();
		}

		public void Dimensions(TopoDS_Shape theS, ref int theDMin, ref int theDMax)
		{
			throw new NotImplementedException();
		}

		public int Dimension(TopoDS_Shape theS)
		{
			throw new NotImplementedException();
		}

		public void TreatCompound(TopoDS_Shape theS, TopTools_ListOfShape theL_ist, TopTools_MapOfShape theMap)
		{
			throw new NotImplementedException();
		}

		public void TreatCompound(TopoDS_Shape theS, TopTools_ListOfShape theL_ist)
		{
			throw new NotImplementedException();
		}

		public bool IsOpenShell(TopoDS_Shell theShell)
		{
			throw new NotImplementedException();
		}


	}; // class BOPTools_AlgoTools

}
