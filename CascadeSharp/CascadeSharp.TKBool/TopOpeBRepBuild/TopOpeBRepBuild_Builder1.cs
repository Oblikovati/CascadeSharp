//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBool.TopOpeBRepDS;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBool.TopOpeBRepBuild
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepBuild_Builder1
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepBuild_Builder1 : TopOpeBRepBuild_Builder
	{

		public TopOpeBRepBuild_Builder1(TopOpeBRepDS_BuildTool BT)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_Builder1(TopOpeBRepBuild_Builder1 parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_Builder1()
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void Perform(TopOpeBRepDS_HDataStructure HDS)
		{
			throw new NotImplementedException();
		}

		public void Perform(TopOpeBRepDS_HDataStructure HDS, TopoDS_Shape S1, TopoDS_Shape S2)
		{
			throw new NotImplementedException();
		}

		public void MergeKPart()
		{
			throw new NotImplementedException();
		}

		public void MergeKPart(TopAbs_State TB1, TopAbs_State TB2)
		{
			throw new NotImplementedException();
		}

		public void GFillSolidSFS(TopoDS_Shape SO1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_ShellFaceSet SFS)
		{
			throw new NotImplementedException();
		}

		public void GFillShellSFS(TopoDS_Shape SH1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_ShellFaceSet SFS)
		{
			throw new NotImplementedException();
		}

		public void GWESMakeFaces(TopoDS_Shape FF, TopOpeBRepBuild_WireEdgeSet WES, TopTools_ListOfShape LOF)
		{
			throw new NotImplementedException();
		}

		public void GFillSplitsPVS(TopoDS_Shape anEdge, TopOpeBRepBuild_GTopo G1, TopOpeBRepBuild_PaveSet PVS)
		{
			throw new NotImplementedException();
		}

		public void GFillFaceNotSameDomSFS(TopoDS_Shape F1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_ShellFaceSet SFS)
		{
			throw new NotImplementedException();
		}

		public void GFillFaceNotSameDomWES(TopoDS_Shape F1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_WireEdgeSet WES)
		{
			throw new NotImplementedException();
		}

		public void GFillWireNotSameDomWES(TopoDS_Shape W1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_WireEdgeSet WES)
		{
			throw new NotImplementedException();
		}

		public void GFillEdgeNotSameDomWES(TopoDS_Shape E1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_WireEdgeSet WES)
		{
			throw new NotImplementedException();
		}

		public void GFillFaceSameDomSFS(TopoDS_Shape F1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_ShellFaceSet SFS)
		{
			throw new NotImplementedException();
		}

		public void GFillFaceSameDomWES(TopoDS_Shape F1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_WireEdgeSet WES)
		{
			throw new NotImplementedException();
		}

		public void GFillWireSameDomWES(TopoDS_Shape W1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_WireEdgeSet WES)
		{
			throw new NotImplementedException();
		}

		public void GFillEdgeSameDomWES(TopoDS_Shape E1, TopTools_ListOfShape LSO2, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_WireEdgeSet WES)
		{
			throw new NotImplementedException();
		}

		public void PerformONParts(TopoDS_Shape F, TopTools_IndexedMapOfShape SDfaces, TopOpeBRepBuild_GTopo G, TopOpeBRepBuild_WireEdgeSet WES)
		{
			throw new NotImplementedException();
		}

		public void PerformPieceIn2D(TopoDS_Edge aPieceToPerform, TopoDS_Edge aOriginalEdge, TopoDS_Face edgeFace, TopoDS_Face toFace, TopOpeBRepBuild_GTopo G, ref bool keep)
		{
			throw new NotImplementedException();
		}

		public int PerformPieceOn2D(TopoDS_Shape aPieceObj, TopoDS_Shape aFaceObj, TopoDS_Shape aEdgeObj, TopTools_ListOfShape aL_istOfPieces, TopTools_ListOfShape aL_istOfFaces, TopTools_ListOfShape aL_istOfPiecesOut2d)
		{
			throw new NotImplementedException();
		}

		public int TwoPiecesON(TopTools_SequenceOfShape aSeq, TopTools_ListOfShape aL_istOfPieces, TopTools_ListOfShape aL_istOfFaces, TopTools_ListOfShape aL_istOfPiecesOut2d)
		{
			throw new NotImplementedException();
		}

		public int CorrectResult2d(TopoDS_Shape aResult)
		{
			throw new NotImplementedException();
		}

		public void PerformShapeWithStates()
		{
			throw new NotImplementedException();
		}

		public void PerformShapeWithStates(TopoDS_Shape anObj, TopoDS_Shape aTool)
		{
			throw new NotImplementedException();
		}

		public void StatusEdgesToSplit(TopoDS_Shape anObj, TopTools_IndexedMapOfShape anEdgesToSplitMap, TopTools_IndexedMapOfShape anEdgesToRestMap)
		{
			throw new NotImplementedException();
		}

						public int IsSame2d(TopTools_SequenceOfShape aSeq, TopTools_ListOfShape aL_istOfPiecesOut2d)
		{
			throw new NotImplementedException();
		}

		public void OrientateEdgeOnFace(TopoDS_Edge EdgeToPerform, TopoDS_Face baseFace, TopoDS_Face edgeFace, TopOpeBRepBuild_GTopo G1, ref bool stateOfFaceOri)
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRepBuild_Builder1

}
