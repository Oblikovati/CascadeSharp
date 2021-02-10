//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRep_FacesFiller
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRep_FacesFiller
	{

		public TopOpeBRep_FacesFiller()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_FacesFiller(TopOpeBRep_FacesFiller parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Insert(TopoDS_Shape F1, TopoDS_Shape F2, TopOpeBRep_FacesIntersector FACINT, TopOpeBRepDS_HDataStructure HDS)
		{
			throw new NotImplementedException();
		}

		public void ProcessSectionEdges()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_PointClassifier ChangePointClassifier()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepTool_ShapeClassifier PShapeClassifier()
		{
			throw new NotImplementedException();
		}

		public void SetPShapeClassifier(TopOpeBRepTool_ShapeClassifier PSC)
		{
			throw new NotImplementedException();
		}

		public void LoadLine(TopOpeBRep_LineInter L)
		{
			throw new NotImplementedException();
		}

		public bool CheckLine(TopOpeBRep_LineInter L)
		{
			throw new NotImplementedException();
		}

		public void VP_Position(TopOpeBRep_FacesIntersector FACINT)
		{
			throw new NotImplementedException();
		}

		public void VP_Position(TopOpeBRep_LineInter L)
		{
			throw new NotImplementedException();
		}

		public void VP_PositionOnL(TopOpeBRep_LineInter L)
		{
			throw new NotImplementedException();
		}

		public void VP_PositionOnR(TopOpeBRep_LineInter L)
		{
			throw new NotImplementedException();
		}

		public void VP_Position(TopOpeBRep_VPointInter VP, TopOpeBRep_VPointInterClassifier VPC)
		{
			throw new NotImplementedException();
		}

		public void ProcessLine()
		{
			throw new NotImplementedException();
		}

		public void ResetDSC()
		{
			throw new NotImplementedException();
		}

		public void ProcessRLine()
		{
			throw new NotImplementedException();
		}

		public void FillLineVPonR()
		{
			throw new NotImplementedException();
		}

		public void FillLine()
		{
			throw new NotImplementedException();
		}

		public void AddShapesLine()
		{
			throw new NotImplementedException();
		}

		public void GetESL(TopTools_ListOfShape LES)
		{
			throw new NotImplementedException();
		}

		public void ProcessVPR(TopOpeBRep_FacesFiller FF, TopOpeBRep_VPointInter VP)
		{
			throw new NotImplementedException();
		}

		public void ProcessVPIonR(TopOpeBRep_VPointInterIterator VPI, TopOpeBRepDS_Transition trans1, TopoDS_Shape F1, int ShapeIndex)
		{
			throw new NotImplementedException();
		}

		public void ProcessVPonR(TopOpeBRep_VPointInter VP, TopOpeBRepDS_Transition trans1, TopoDS_Shape F1, int ShapeIndex)
		{
			throw new NotImplementedException();
		}

		public void ProcessVPonclosingR(TopOpeBRep_VPointInter VP, TopoDS_Shape F1, int ShapeIndex, TopOpeBRepDS_Transition transEdge, CascadeSharp.TopOpeBRepDS_Kind PVKind, int PVIndex, bool EPIfound, TopOpeBRepDS_Interference IEPI)
		{
			throw new NotImplementedException();
		}

		public bool ProcessVPondgE(TopOpeBRep_VPointInter VP, int ShapeIndex,  ref CascadeSharp.TopOpeBRepDS_Kind PVKind, ref int PVIndex, ref bool EPIfound, TopOpeBRepDS_Interference IEPI, ref bool CPIfound, TopOpeBRepDS_Interference ICPI)
		{
			throw new NotImplementedException();
		}

		public void ProcessVPInotonR(TopOpeBRep_VPointInterIterator VPI)
		{
			throw new NotImplementedException();
		}

		public void ProcessVPnotonR(TopOpeBRep_VPointInter VP)
		{
			throw new NotImplementedException();
		}

				public int MakeGeometry(TopOpeBRep_VPointInter VP, int ShapeIndex,  ref CascadeSharp.TopOpeBRepDS_Kind K)
		{
			throw new NotImplementedException();
		}

		public void StoreCurveInterference(TopOpeBRepDS_Interference I)
		{
			throw new NotImplementedException();
		}

		public bool GetFFGeometry(TopOpeBRepDS_Point DSP,  ref CascadeSharp.TopOpeBRepDS_Kind K, ref int G)
		{
			throw new NotImplementedException();
		}

		public bool GetFFGeometry(TopOpeBRep_VPointInter VP,  ref CascadeSharp.TopOpeBRepDS_Kind K, ref int G)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_FacesIntersector ChangeFacesIntersector()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_HDataStructure HDataStructure()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_DataStructure ChangeDataStructure()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Face(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Transition FaceFaceTransition(TopOpeBRep_LineInter L, int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Transition FaceFaceTransition(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_FacesIntersector PFacesIntersectorDummy()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_DataStructure PDataStructureDummy()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_LineInter PLineInterDummy()
		{
			throw new NotImplementedException();
		}

		public void SetTraceIndex(int exF1, int exF2)
		{
			throw new NotImplementedException();
		}

		public void GetTraceIndex(ref int exF1, ref int exF2)
		{
			throw new NotImplementedException();
		}

		public void Lminmax(TopOpeBRep_LineInter L, ref double pmin, ref double pmax)
		{
			throw new NotImplementedException();
		}

		public bool LSameDomainERL(TopOpeBRep_LineInter L, TopTools_ListOfShape ERL)
		{
			throw new NotImplementedException();
		}

		public bool IsVPtransLok(TopOpeBRep_LineInter L, int iVP, int SI12, TopOpeBRepDS_Transition T)
		{
			throw new NotImplementedException();
		}

		public bool TransvpOK(TopOpeBRep_LineInter L, int iVP, int SI, bool _isINOUT)
		{
			throw new NotImplementedException();
		}

		public double VPParamOnER(TopOpeBRep_VPointInter vp, TopOpeBRep_LineInter Lrest)
		{
			throw new NotImplementedException();
		}

		public bool EqualpPonR(TopOpeBRep_LineInter Lrest, TopOpeBRep_VPointInter VP1, TopOpeBRep_VPointInter VP2)
		{
			throw new NotImplementedException();
		}

		public bool KeepRLine(TopOpeBRep_LineInter Lrest, bool checkkeep)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Transition GetEdgeTrans(TopOpeBRep_VPointInter VP, CascadeSharp.TopOpeBRepDS_Kind PVKind, int PVIndex, int Sind, TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_State StateVPonFace(TopOpeBRep_VPointInter VP)
		{
			throw new NotImplementedException();
		}

		public bool PequalVPonR(gp_Pnt P3D, int VPshapeindex, TopOpeBRep_VPointInter VP, TopOpeBRep_LineInter Lrest)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_State StBipVPonF(TopOpeBRep_VPointInter IVPf, TopOpeBRep_VPointInter IVPl, TopOpeBRep_LineInter Lrest, bool _isonedge1)
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRep_FacesFiller

}
