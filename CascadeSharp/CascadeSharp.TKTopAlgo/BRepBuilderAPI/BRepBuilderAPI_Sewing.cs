//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepBuilderAPI_Sewing
	//---------------------------------------------------------------------
	public  sealed class BRepBuilderAPI_Sewing : Standard_Transient
	{

		public BRepBuilderAPI_Sewing(double tolerance, bool option1, bool option2, bool option3, bool option4)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_Sewing(double tolerance, bool option1, bool option2, bool option3)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_Sewing(double tolerance, bool option1, bool option2)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_Sewing(double tolerance, bool option1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_Sewing(double tolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_Sewing(BRepBuilderAPI_Sewing parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_Sewing()
		{
			throw new NotImplementedException();
		}

		public void Init(double tolerance, bool option1, bool option2, bool option3, bool option4)
		{
			throw new NotImplementedException();
		}

		public void Init(double tolerance, bool option1, bool option2, bool option3)
		{
			throw new NotImplementedException();
		}

		public void Init(double tolerance, bool option1, bool option2)
		{
			throw new NotImplementedException();
		}

		public void Init(double tolerance, bool option1)
		{
			throw new NotImplementedException();
		}

		public void Init(double tolerance)
		{
			throw new NotImplementedException();
		}

		public void Init()
		{
			throw new NotImplementedException();
		}

		public void Load(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public void Add(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public void Perform(Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public void Perform()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape SewedShape()
		{
			throw new NotImplementedException();
		}

		public void SetContext(BRepTools_ReShape theContext)
		{
			throw new NotImplementedException();
		}

		public BRepTools_ReShape GetContext()
		{
			throw new NotImplementedException();
		}

		public int NbFreeEdges()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge FreeEdge(int index)
		{
			throw new NotImplementedException();
		}

		public int NbMultipleEdges()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge MultipleEdge(int index)
		{
			throw new NotImplementedException();
		}

		public int NbContigousEdges()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge ContigousEdge(int index)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape ContigousEdgeCouple(int index)
		{
			throw new NotImplementedException();
		}

		public bool IsSectionBound(TopoDS_Edge section)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge SectionToBoundary(TopoDS_Edge section)
		{
			throw new NotImplementedException();
		}

		public int NbDegeneratedShapes()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape DegeneratedShape(int index)
		{
			throw new NotImplementedException();
		}

		public bool IsDegenerated(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public bool IsModified(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Modified(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public bool IsModifiedSubShape(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape ModifiedSubShape(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public void Dump()
		{
			throw new NotImplementedException();
		}

		public int NbDeletedFaces()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face DeletedFace(int index)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face WhichFace(TopoDS_Edge theEdg, int index)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face WhichFace(TopoDS_Edge theEdg)
		{
			throw new NotImplementedException();
		}

		public bool SameParameterMode()
		{
			throw new NotImplementedException();
		}

		public void SetSameParameterMode(bool SameParameterMode)
		{
			throw new NotImplementedException();
		}

		public double Tolerance()
		{
			throw new NotImplementedException();
		}

		public void SetTolerance(double theToler)
		{
			throw new NotImplementedException();
		}

		public double MinTolerance()
		{
			throw new NotImplementedException();
		}

		public void SetMinTolerance(double theMinToler)
		{
			throw new NotImplementedException();
		}

		public double MaxTolerance()
		{
			throw new NotImplementedException();
		}

		public void SetMaxTolerance(double theMaxToler)
		{
			throw new NotImplementedException();
		}

		public bool FaceMode()
		{
			throw new NotImplementedException();
		}

		public void SetFaceMode(bool theFaceMode)
		{
			throw new NotImplementedException();
		}

		public bool FloatingEdgesMode()
		{
			throw new NotImplementedException();
		}

		public void SetFloatingEdgesMode(bool theFloatingEdgesMode)
		{
			throw new NotImplementedException();
		}

		public bool LocalTolerancesMode()
		{
			throw new NotImplementedException();
		}

		public void SetLocalTolerancesMode(bool theLocalTolerancesMode)
		{
			throw new NotImplementedException();
		}

		public void SetNonManifoldMode(bool theNonManifoldMode)
		{
			throw new NotImplementedException();
		}

		public bool NonManifoldMode()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void Cutting(Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public void Cutting()
		{
			throw new NotImplementedException();
		}

		public void Merging(bool passage, Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public void Merging(bool passage)
		{
			throw new NotImplementedException();
		}

		public bool IsMergedClosed(TopoDS_Edge Edge1, TopoDS_Edge Edge2, TopoDS_Face fase)
		{
			throw new NotImplementedException();
		}

		public bool FindCandidates(TopTools_SequenceOfShape seqSections, TColStd_IndexedMapOfInteger mapReference, TColStd_SequenceOfInteger seqCandidates, TColStd_SequenceOfBoolean seqOrientations)
		{
			throw new NotImplementedException();
		}

		public void AnalysisNearestEdges(TopTools_SequenceOfShape sequenceSec, TColStd_SequenceOfInteger seqIndCandidate, TColStd_SequenceOfBoolean seqOrientations, bool evalD_ist)
		{
			throw new NotImplementedException();
		}

		public void AnalysisNearestEdges(TopTools_SequenceOfShape sequenceSec, TColStd_SequenceOfInteger seqIndCandidate, TColStd_SequenceOfBoolean seqOrientations)
		{
			throw new NotImplementedException();
		}

		public bool MergedNearestEdges(TopoDS_Shape edge, TopTools_SequenceOfShape SeqMergedEdge, TColStd_SequenceOfBoolean SeqMergedOri)
		{
			throw new NotImplementedException();
		}

		public void EdgeProcessing(Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public void EdgeProcessing()
		{
			throw new NotImplementedException();
		}

		public void EdgeRegularity(Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public void EdgeRegularity()
		{
			throw new NotImplementedException();
		}

		public void CreateOutputInformations()
		{
			throw new NotImplementedException();
		}

		public bool IsUClosedSurface(Geom_Surface surf, TopoDS_Shape theEdge, TopLoc_Location theloc)
		{
			throw new NotImplementedException();
		}

		public bool IsVClosedSurface(Geom_Surface surf, TopoDS_Shape theEdge, TopLoc_Location theloc)
		{
			throw new NotImplementedException();
		}

		public void FaceAnalysis(Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public void FaceAnalysis()
		{
			throw new NotImplementedException();
		}

		public void FindFreeBoundaries()
		{
			throw new NotImplementedException();
		}

		public void VerticesAssembling(Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public void VerticesAssembling()
		{
			throw new NotImplementedException();
		}

		public void CreateSewedShape()
		{
			throw new NotImplementedException();
		}

		public void GetFreeWires(TopTools_IndexedMapOfShape MapFreeEdges, TopTools_SequenceOfShape seqWires)
		{
			throw new NotImplementedException();
		}

		public void EvaluateAngulars(TopTools_SequenceOfShape sequenceSec, TColStd_Array1OfBoolean secForward, TColStd_Array1OfReal tabAng, int indRef)
		{
			throw new NotImplementedException();
		}

		public void EvaluateDistances(TopTools_SequenceOfShape sequenceSec, TColStd_Array1OfBoolean secForward, TColStd_Array1OfReal tabAng, TColStd_Array1OfReal arrLen, TColStd_Array1OfReal tabMinD_ist, int indRef)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve SameRange(Geom2d_Curve CurvePtr, double FirstOnCurve, double LastOnCurve, double RequestedFirst, double RequestedLast)
		{
			throw new NotImplementedException();
		}

		public void SameParameter(TopoDS_Edge edge)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge SameParameterEdge(TopoDS_Shape edge, TopTools_SequenceOfShape seqEdges, TColStd_SequenceOfBoolean seqForward, TopTools_MapOfShape mapMerged, BRepTools_ReShape locReShape)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge SameParameterEdge(TopoDS_Edge edge1, TopoDS_Edge edge2, TopTools_ListOfShape l_istFaces1, TopTools_ListOfShape l_istFaces2, bool secForward, ref int whichSec, bool firstCall)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge SameParameterEdge(TopoDS_Edge edge1, TopoDS_Edge edge2, TopTools_ListOfShape l_istFaces1, TopTools_ListOfShape l_istFaces2, bool secForward, ref int whichSec)
		{
			throw new NotImplementedException();
		}

		public void ProjectPointsOnCurve(TColgp_Array1OfPnt arrPnt, Geom_Curve Crv, double first, double last, TColStd_Array1OfReal arrD_ist, TColStd_Array1OfReal arrPara, TColgp_Array1OfPnt arrProj, bool _isConsiderEnds)
		{
			throw new NotImplementedException();
		}

		public void CreateCuttingNodes(TopTools_IndexedMapOfShape MapVert, TopoDS_Shape bound, TopoDS_Shape vfirst, TopoDS_Shape vlast, TColStd_Array1OfReal arrD_ist, TColStd_Array1OfReal arrPara, TColgp_Array1OfPnt arrPnt, TopTools_SequenceOfShape seqNode, TColStd_SequenceOfReal seqPara)
		{
			throw new NotImplementedException();
		}

		public void CreateSections(TopoDS_Shape bound, TopTools_SequenceOfShape seqNode, TColStd_SequenceOfReal seqPara, TopTools_ListOfShape l_istEdge)
		{
			throw new NotImplementedException();
		}

		public void SameParameterShape()
		{
			throw new NotImplementedException();
		}


	}; // class BRepBuilderAPI_Sewing

}
