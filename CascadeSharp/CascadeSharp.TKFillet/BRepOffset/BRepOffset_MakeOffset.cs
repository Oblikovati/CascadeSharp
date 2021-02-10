//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepOffset_MakeOffset
	//---------------------------------------------------------------------
	public  sealed class BRepOffset_MakeOffset
	{

		public BRepOffset_MakeOffset()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_MakeOffset(TopoDS_Shape S, double Offset, double Tol, CascadeSharp.BRepOffset_Mode Mode, bool Intersection, bool SelfInter, CascadeSharp.GeomAbs_JoinType Join, bool Thickening, bool RemoveIntEdges)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_MakeOffset(TopoDS_Shape S, double Offset, double Tol, CascadeSharp.BRepOffset_Mode Mode, bool Intersection, bool SelfInter, CascadeSharp.GeomAbs_JoinType Join, bool Thickening)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_MakeOffset(TopoDS_Shape S, double Offset, double Tol, CascadeSharp.BRepOffset_Mode Mode, bool Intersection, bool SelfInter, CascadeSharp.GeomAbs_JoinType Join)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_MakeOffset(TopoDS_Shape S, double Offset, double Tol, CascadeSharp.BRepOffset_Mode Mode, bool Intersection, bool SelfInter)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_MakeOffset(TopoDS_Shape S, double Offset, double Tol, CascadeSharp.BRepOffset_Mode Mode, bool Intersection)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_MakeOffset(TopoDS_Shape S, double Offset, double Tol, CascadeSharp.BRepOffset_Mode Mode)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_MakeOffset(TopoDS_Shape S, double Offset, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_MakeOffset(BRepOffset_MakeOffset parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Initialize(TopoDS_Shape S, double Offset, double Tol, CascadeSharp.BRepOffset_Mode Mode, bool Intersection, bool SelfInter, CascadeSharp.GeomAbs_JoinType Join, bool Thickening, bool RemoveIntEdges)
		{
			throw new NotImplementedException();
		}

		public void Initialize(TopoDS_Shape S, double Offset, double Tol, CascadeSharp.BRepOffset_Mode Mode, bool Intersection, bool SelfInter, CascadeSharp.GeomAbs_JoinType Join, bool Thickening)
		{
			throw new NotImplementedException();
		}

		public void Initialize(TopoDS_Shape S, double Offset, double Tol, CascadeSharp.BRepOffset_Mode Mode, bool Intersection, bool SelfInter, CascadeSharp.GeomAbs_JoinType Join)
		{
			throw new NotImplementedException();
		}

		public void Initialize(TopoDS_Shape S, double Offset, double Tol, CascadeSharp.BRepOffset_Mode Mode, bool Intersection, bool SelfInter)
		{
			throw new NotImplementedException();
		}

		public void Initialize(TopoDS_Shape S, double Offset, double Tol, CascadeSharp.BRepOffset_Mode Mode, bool Intersection)
		{
			throw new NotImplementedException();
		}

		public void Initialize(TopoDS_Shape S, double Offset, double Tol, CascadeSharp.BRepOffset_Mode Mode)
		{
			throw new NotImplementedException();
		}

		public void Initialize(TopoDS_Shape S, double Offset, double Tol)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void AllowLinearization(bool theIsAllowed)
		{
			throw new NotImplementedException();
		}

		public void AddFace(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public void SetOffsetOnFace(TopoDS_Face F, double Off)
		{
			throw new NotImplementedException();
		}

		public void MakeOffsetShape()
		{
			throw new NotImplementedException();
		}

		public void MakeThickSolid()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_Analyse GetAnalyse()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape InitShape()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.BRepOffset_Error Error()
		{
			throw new NotImplementedException();
		}

		public BRepAlgo_Image OffsetFacesFromShapes()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_JoinType GetJoinType()
		{
			throw new NotImplementedException();
		}

		public BRepAlgo_Image OffsetEdgesFromShapes()
		{
			throw new NotImplementedException();
		}

		public TopTools_IndexedMapOfShape ClosingFaces()
		{
			throw new NotImplementedException();
		}

		public bool CheckInputData()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape GetBadShape()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Generated(TopoDS_Shape theS)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Modified(TopoDS_Shape theS)
		{
			throw new NotImplementedException();
		}

		public bool IsDeleted(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public bool IsPlanar()
		{
			throw new NotImplementedException();
		}

		public void SetFaces()
		{
			throw new NotImplementedException();
		}

		public void SetFacesWithOffset()
		{
			throw new NotImplementedException();
		}

		public void BuildFaceComp()
		{
			throw new NotImplementedException();
		}

		public void BuildOffsetByArc()
		{
			throw new NotImplementedException();
		}

		public void BuildOffsetByInter()
		{
			throw new NotImplementedException();
		}

		public void MakeOffsetFaces(BRepOffset_DataMapOfShapeOffset theMapSF)
		{
			throw new NotImplementedException();
		}

		public void SelfInter(TopTools_MapOfShape Modif)
		{
			throw new NotImplementedException();
		}

		public void Intersection3D(BRepOffset_Inter3d Inter)
		{
			throw new NotImplementedException();
		}

		public void Intersection2D(TopTools_IndexedMapOfShape Modif, TopTools_IndexedMapOfShape NewEdges)
		{
			throw new NotImplementedException();
		}

		public void MakeLoops(TopTools_IndexedMapOfShape Modif)
		{
			throw new NotImplementedException();
		}

		public void MakeLoopsOnContext(TopTools_MapOfShape Modif)
		{
			throw new NotImplementedException();
		}

		public void MakeFaces(TopTools_IndexedMapOfShape Modif)
		{
			throw new NotImplementedException();
		}

		public void MakeShells()
		{
			throw new NotImplementedException();
		}

		public void SelectShells()
		{
			throw new NotImplementedException();
		}

		public void EncodeRegularity()
		{
			throw new NotImplementedException();
		}

		public void ReplaceRoots()
		{
			throw new NotImplementedException();
		}

		public void MakeSolid()
		{
			throw new NotImplementedException();
		}

		public void ToContext(BRepOffset_DataMapOfShapeOffset MapSF)
		{
			throw new NotImplementedException();
		}

		public void UpdateFaceOffset()
		{
			throw new NotImplementedException();
		}

		public void CorrectConicalFaces()
		{
			throw new NotImplementedException();
		}

		public void MakeMissingWalls()
		{
			throw new NotImplementedException();
		}

		public void RemoveInternalEdges()
		{
			throw new NotImplementedException();
		}

		public void IntersectEdges(TopTools_ListOfShape theFaces, BRepOffset_DataMapOfShapeOffset theMapSF, TopTools_DataMapOfShapeShape theMES, TopTools_DataMapOfShapeShape theBuild, BRepAlgo_AsDes theAsDes, BRepAlgo_AsDes theAsDes2d)
		{
			throw new NotImplementedException();
		}

		public void BuildSplitsOfExtendedFaces(TopTools_ListOfShape theLF, BRepOffset_Analyse theAnalyse, BRepAlgo_AsDes theAsDes, TopTools_DataMapOfShapeListOfShape theEdgesOrigins, TopTools_DataMapOfShapeShape theFacesOrigins, TopTools_DataMapOfShapeShape theETrimEInf, BRepAlgo_Image theImage)
		{
			throw new NotImplementedException();
		}

		public void BuildSplitsOfTrimmedFaces(TopTools_ListOfShape theLF, BRepAlgo_AsDes theAsDes, BRepAlgo_Image theImage)
		{
			throw new NotImplementedException();
		}


	}; // class BRepOffset_MakeOffset

}
