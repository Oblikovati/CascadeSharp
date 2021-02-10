//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepDS_DataStructure
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepDS_DataStructure
	{

		public TopOpeBRepDS_DataStructure()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_DataStructure(TopOpeBRepDS_DataStructure parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init()
		{
			throw new NotImplementedException();
		}

		public int AddSurface(TopOpeBRepDS_Surface S)
		{
			throw new NotImplementedException();
		}

		public void RemoveSurface(int I)
		{
			throw new NotImplementedException();
		}

		public bool KeepSurface(int I)
		{
			throw new NotImplementedException();
		}

		public bool KeepSurface(TopOpeBRepDS_Surface S)
		{
			throw new NotImplementedException();
		}

		public void ChangeKeepSurface(int I, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public void ChangeKeepSurface(TopOpeBRepDS_Surface S, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public int AddCurve(TopOpeBRepDS_Curve S)
		{
			throw new NotImplementedException();
		}

		public void RemoveCurve(int I)
		{
			throw new NotImplementedException();
		}

		public bool KeepCurve(int I)
		{
			throw new NotImplementedException();
		}

		public bool KeepCurve(TopOpeBRepDS_Curve C)
		{
			throw new NotImplementedException();
		}

		public void ChangeKeepCurve(int I, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public void ChangeKeepCurve(TopOpeBRepDS_Curve C, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public int AddPoint(TopOpeBRepDS_Point PDS)
		{
			throw new NotImplementedException();
		}

		public int AddPointSS(TopOpeBRepDS_Point PDS, TopoDS_Shape S1, TopoDS_Shape S2)
		{
			throw new NotImplementedException();
		}

		public void RemovePoint(int I)
		{
			throw new NotImplementedException();
		}

		public bool KeepPoint(int I)
		{
			throw new NotImplementedException();
		}

		public bool KeepPoint(TopOpeBRepDS_Point P)
		{
			throw new NotImplementedException();
		}

		public void ChangeKeepPoint(int I, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public void ChangeKeepPoint(TopOpeBRepDS_Point P, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public int AddShape(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public int AddShape(TopoDS_Shape S, int I)
		{
			throw new NotImplementedException();
		}

		public bool KeepShape(int I, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public bool KeepShape(int I)
		{
			throw new NotImplementedException();
		}

		public bool KeepShape(TopoDS_Shape S, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public bool KeepShape(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void ChangeKeepShape(int I, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public void ChangeKeepShape(TopoDS_Shape S, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public void InitSectionEdges()
		{
			throw new NotImplementedException();
		}

		public int AddSectionEdge(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference SurfaceInterferences(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference ChangeSurfaceInterferences(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference CurveInterferences(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference ChangeCurveInterferences(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference PointInterferences(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference ChangePointInterferences(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference ShapeInterferences(TopoDS_Shape S, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference ShapeInterferences(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference ChangeShapeInterferences(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference ShapeInterferences(int I, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference ShapeInterferences(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ListOfInterference ChangeShapeInterferences(int I)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape ShapeSameDomain(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape ChangeShapeSameDomain(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape ShapeSameDomain(int I)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape ChangeShapeSameDomain(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_MapOfShapeData ChangeShapes()
		{
			throw new NotImplementedException();
		}

		public void AddShapeSameDomain(TopoDS_Shape S, TopoDS_Shape SSD)
		{
			throw new NotImplementedException();
		}

		public void RemoveShapeSameDomain(TopoDS_Shape S, TopoDS_Shape SSD)
		{
			throw new NotImplementedException();
		}

		public int SameDomainRef(int I)
		{
			throw new NotImplementedException();
		}

		public int SameDomainRef(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void SameDomainRef(int I, int Ref)
		{
			throw new NotImplementedException();
		}

		public void SameDomainRef(TopoDS_Shape S, int Ref)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopOpeBRepDS_Config SameDomainOri(int I)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopOpeBRepDS_Config SameDomainOri(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void SameDomainOri(int I, CascadeSharp.TopOpeBRepDS_Config Ori)
		{
			throw new NotImplementedException();
		}

		public void SameDomainOri(TopoDS_Shape S, CascadeSharp.TopOpeBRepDS_Config Ori)
		{
			throw new NotImplementedException();
		}

		public int SameDomainInd(int I)
		{
			throw new NotImplementedException();
		}

		public int SameDomainInd(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void SameDomainInd(int I, int Ind)
		{
			throw new NotImplementedException();
		}

		public void SameDomainInd(TopoDS_Shape S, int Ind)
		{
			throw new NotImplementedException();
		}

		public int AncestorRank(int I)
		{
			throw new NotImplementedException();
		}

		public int AncestorRank(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void AncestorRank(int I, int Ianc)
		{
			throw new NotImplementedException();
		}

		public void AncestorRank(TopoDS_Shape S, int Ianc)
		{
			throw new NotImplementedException();
		}

		public void AddShapeInterference(TopoDS_Shape S, TopOpeBRepDS_Interference I)
		{
			throw new NotImplementedException();
		}

		public void RemoveShapeInterference(TopoDS_Shape S, TopOpeBRepDS_Interference I)
		{
			throw new NotImplementedException();
		}

		public void FillShapesSameDomain(TopoDS_Shape S1, TopoDS_Shape S2, bool _refFirst)
		{
			throw new NotImplementedException();
		}

		public void FillShapesSameDomain(TopoDS_Shape S1, TopoDS_Shape S2)
		{
			throw new NotImplementedException();
		}

		public void FillShapesSameDomain(TopoDS_Shape S1, TopoDS_Shape S2, CascadeSharp.TopOpeBRepDS_Config c1, CascadeSharp.TopOpeBRepDS_Config c2, bool _refFirst)
		{
			throw new NotImplementedException();
		}

		public void FillShapesSameDomain(TopoDS_Shape S1, TopoDS_Shape S2, CascadeSharp.TopOpeBRepDS_Config c1, CascadeSharp.TopOpeBRepDS_Config c2)
		{
			throw new NotImplementedException();
		}

		public void UnfillShapesSameDomain(TopoDS_Shape S1, TopoDS_Shape S2)
		{
			throw new NotImplementedException();
		}

		public int NbSurfaces()
		{
			throw new NotImplementedException();
		}

		public int NbCurves()
		{
			throw new NotImplementedException();
		}

		public void ChangeNbCurves(int N)
		{
			throw new NotImplementedException();
		}

		public int NbPoints()
		{
			throw new NotImplementedException();
		}

		public int NbShapes()
		{
			throw new NotImplementedException();
		}

		public int NbSectionEdges()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Surface Surface(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Surface ChangeSurface(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Curve Curve(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Curve ChangeCurve(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Point Point(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Point ChangePoint(int I)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape(int I, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape(int I)
		{
			throw new NotImplementedException();
		}

		public int Shape(TopoDS_Shape S, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public int Shape(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge SectionEdge(int I, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge SectionEdge(int I)
		{
			throw new NotImplementedException();
		}

		public int SectionEdge(TopoDS_Edge E, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public int SectionEdge(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public bool IsSectionEdge(TopoDS_Edge E, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public bool IsSectionEdge(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public bool HasGeometry(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public bool HasShape(TopoDS_Shape S, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public bool HasShape(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void SetNewSurface(TopoDS_Shape F, Geom_Surface S)
		{
			throw new NotImplementedException();
		}

		public bool HasNewSurface(TopoDS_Shape F)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface NewSurface(TopoDS_Shape F)
		{
			throw new NotImplementedException();
		}

		public void Isfafa(bool _isfafa)
		{
			throw new NotImplementedException();
		}

		public bool Isfafa()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_IndexedDataMapOfShapeWithState ChangeMapOfShapeWithStateObj()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_IndexedDataMapOfShapeWithState ChangeMapOfShapeWithStateTool()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_IndexedDataMapOfShapeWithState ChangeMapOfShapeWithState(TopoDS_Shape aShape, ref bool aFlag)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_ShapeWithState GetShapeWithState(TopoDS_Shape aShape)
		{
			throw new NotImplementedException();
		}

		public TopTools_IndexedMapOfShape ChangeMapOfRejectedShapesObj()
		{
			throw new NotImplementedException();
		}

		public TopTools_IndexedMapOfShape ChangeMapOfRejectedShapesTool()
		{
			throw new NotImplementedException();
		}

		
	}; // class TopOpeBRepDS_DataStructure

}
