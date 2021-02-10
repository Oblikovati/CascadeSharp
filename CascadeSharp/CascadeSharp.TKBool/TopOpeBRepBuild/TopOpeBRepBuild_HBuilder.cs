//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepBuild_HBuilder
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepBuild_HBuilder : Standard_Transient
	{

		public TopOpeBRepBuild_HBuilder(TopOpeBRepDS_BuildTool BT)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_HBuilder(TopOpeBRepBuild_HBuilder parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_HBuilder()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_BuildTool BuildTool()
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

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_HDataStructure DataStructure()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepDS_BuildTool ChangeBuildTool()
		{
			throw new NotImplementedException();
		}

		public void MergeShapes(TopoDS_Shape S1, CascadeSharp.TopAbs_State TB1, TopoDS_Shape S2, CascadeSharp.TopAbs_State TB2)
		{
			throw new NotImplementedException();
		}

		public void MergeSolids(TopoDS_Shape S1, CascadeSharp.TopAbs_State TB1, TopoDS_Shape S2, CascadeSharp.TopAbs_State TB2)
		{
			throw new NotImplementedException();
		}

		public void MergeSolid(TopoDS_Shape S, CascadeSharp.TopAbs_State TB)
		{
			throw new NotImplementedException();
		}

		public bool IsSplit(TopoDS_Shape S, CascadeSharp.TopAbs_State ToBuild)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Splits(TopoDS_Shape S, CascadeSharp.TopAbs_State ToBuild)
		{
			throw new NotImplementedException();
		}

		public bool IsMerged(TopoDS_Shape S, CascadeSharp.TopAbs_State ToBuild)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Merged(TopoDS_Shape S, CascadeSharp.TopAbs_State ToBuild)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape NewVertex(int I)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape NewEdges(int I)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape ChangeNewEdges(int I)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape NewFaces(int I)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Section()
		{
			throw new NotImplementedException();
		}

		public void InitExtendedSectionDS(int k)
		{
			throw new NotImplementedException();
		}

		public void InitExtendedSectionDS()
		{
			throw new NotImplementedException();
		}

		public void InitSection(int k)
		{
			throw new NotImplementedException();
		}

		public void InitSection()
		{
			throw new NotImplementedException();
		}

		public bool MoreSection()
		{
			throw new NotImplementedException();
		}

		public void NextSection()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape CurrentSection()
		{
			throw new NotImplementedException();
		}

		public int GetDSEdgeFromSectEdge(TopoDS_Shape E, int rank)
		{
			throw new NotImplementedException();
		}

		public TColStd_ListOfInteger GetDSFaceFromDSEdge(int indexEdg, int rank)
		{
			throw new NotImplementedException();
		}

		public int GetDSCurveFromSectEdge(TopoDS_Shape SectEdge)
		{
			throw new NotImplementedException();
		}

		public int GetDSFaceFromDSCurve(int indexCur, int rank)
		{
			throw new NotImplementedException();
		}

		public int GetDSPointFromNewVertex(TopoDS_Shape NewVert)
		{
			throw new NotImplementedException();
		}

		public bool EdgeCurveAncestors(TopoDS_Shape E, TopoDS_Shape F1, TopoDS_Shape F2, ref int IC)
		{
			throw new NotImplementedException();
		}

		public bool EdgeSectionAncestors(TopoDS_Shape E, TopTools_ListOfShape LF1, TopTools_ListOfShape LF2, TopTools_ListOfShape LE1, TopTools_ListOfShape LE2)
		{
			throw new NotImplementedException();
		}

		public int IsKPart()
		{
			throw new NotImplementedException();
		}

		public void MergeKPart(CascadeSharp.TopAbs_State TB1, CascadeSharp.TopAbs_State TB2)
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepBuild_Builder ChangeBuilder()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void MakeEdgeAncestorMap()
		{
			throw new NotImplementedException();
		}

		public void MakeCurveAncestorMap()
		{
			throw new NotImplementedException();
		}


	}; // class TopOpeBRepBuild_HBuilder

}
