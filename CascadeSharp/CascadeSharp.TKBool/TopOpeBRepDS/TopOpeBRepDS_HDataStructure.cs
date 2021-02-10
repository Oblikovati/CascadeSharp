//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepDS_HDataStructure
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepDS_HDataStructure : Standard_Transient
	{

		public TopOpeBRepDS_HDataStructure()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_HDataStructure(TopOpeBRepDS_HDataStructure parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void AddAncestors(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void AddAncestors(TopoDS_Shape S, CascadeSharp.TopAbs_ShapeEnum T1, CascadeSharp.TopAbs_ShapeEnum T2)
		{
			throw new NotImplementedException();
		}

		public void ChkIntg()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_DataStructure DS()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_DataStructure ChangeDS()
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

		public int NbPoints()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Surface Surface(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_CurveIterator SurfaceCurves(int I)
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

		public TopOpeBRepDS_PointIterator CurvePoints(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_Point Point(int I)
		{
			throw new NotImplementedException();
		}

		public int NbShapes()
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

		public bool HasSameDomain(TopoDS_Shape S, bool FindKeep)
		{
			throw new NotImplementedException();
		}

		public bool HasSameDomain(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

				public CascadeSharp.TopOpeBRepDS_Config SameDomainOrientation(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public int SameDomainReference(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_SurfaceIterator SolidSurfaces(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_SurfaceIterator SolidSurfaces(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_CurveIterator FaceCurves(TopoDS_Shape F)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_CurveIterator FaceCurves(int I)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_PointIterator EdgePoints(TopoDS_Shape E)
		{
			throw new NotImplementedException();
		}

		public int MakeCurve(TopOpeBRepDS_Curve C1, TopOpeBRepDS_Curve C2)
		{
			throw new NotImplementedException();
		}

		public void RemoveCurve(int iC)
		{
			throw new NotImplementedException();
		}

		public int NbGeometry(CascadeSharp.TopOpeBRepDS_Kind K)
		{
			throw new NotImplementedException();
		}

		public int NbTopology(CascadeSharp.TopOpeBRepDS_Kind K)
		{
			throw new NotImplementedException();
		}

		public int NbTopology()
		{
			throw new NotImplementedException();
		}

		public bool EdgesSameParameter()
		{
			throw new NotImplementedException();
		}

		public void SortOnParameter(TopOpeBRepDS_ListOfInterference L1, TopOpeBRepDS_ListOfInterference L2)
		{
			throw new NotImplementedException();
		}

		public void SortOnParameter(TopOpeBRepDS_ListOfInterference L)
		{
			throw new NotImplementedException();
		}

		public void MinMaxOnParameter(TopOpeBRepDS_ListOfInterference L, ref double Min, ref double Max)
		{
			throw new NotImplementedException();
		}

						public void StoreInterference(TopOpeBRepDS_Interference I, TopOpeBRepDS_ListOfInterference LI, TCollection_AsciiString str)
		{
			throw new NotImplementedException();
		}

		public void StoreInterference(TopOpeBRepDS_Interference I, TopOpeBRepDS_ListOfInterference LI)
		{
			throw new NotImplementedException();
		}

		public void StoreInterference(TopOpeBRepDS_Interference I, TopoDS_Shape S, TCollection_AsciiString str)
		{
			throw new NotImplementedException();
		}

		public void StoreInterference(TopOpeBRepDS_Interference I, TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void StoreInterference(TopOpeBRepDS_Interference I, int IS, TCollection_AsciiString str)
		{
			throw new NotImplementedException();
		}

		public void StoreInterference(TopOpeBRepDS_Interference I, int IS)
		{
			throw new NotImplementedException();
		}

		public void StoreInterferences(TopOpeBRepDS_ListOfInterference LI, TopoDS_Shape S, TCollection_AsciiString str)
		{
			throw new NotImplementedException();
		}

		public void StoreInterferences(TopOpeBRepDS_ListOfInterference LI, TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void StoreInterferences(TopOpeBRepDS_ListOfInterference LI, int IS, TCollection_AsciiString str)
		{
			throw new NotImplementedException();
		}

		public void StoreInterferences(TopOpeBRepDS_ListOfInterference LI, int IS)
		{
			throw new NotImplementedException();
		}

		public void ClearStoreInterferences(TopOpeBRepDS_ListOfInterference LI, TopoDS_Shape S, TCollection_AsciiString str)
		{
			throw new NotImplementedException();
		}

		public void ClearStoreInterferences(TopOpeBRepDS_ListOfInterference LI, TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void ClearStoreInterferences(TopOpeBRepDS_ListOfInterference LI, int IS, TCollection_AsciiString str)
		{
			throw new NotImplementedException();
		}

		public void ClearStoreInterferences(TopOpeBRepDS_ListOfInterference LI, int IS)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class TopOpeBRepDS_HDataStructure

}
