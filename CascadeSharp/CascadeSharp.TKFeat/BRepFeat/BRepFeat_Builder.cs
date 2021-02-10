//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBO.BOPAlgo;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;

namespace CascadeSharp.TKFeat.BRepFeat
{
	//---------------------------------------------------------------------
	//  Class  BRepFeat_Builder
	//---------------------------------------------------------------------
	public  class BRepFeat_Builder : BOPAlgo_BOP
	{

		public BRepFeat_Builder()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFeat_Builder(BRepFeat_Builder parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape theShape)
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape theShape, TopoDS_Shape theTool)
		{
			throw new NotImplementedException();
		}

		public void SetOperation(int theFuse)
		{
			throw new NotImplementedException();
		}

		public void SetOperation(int theFuse, bool theFlag)
		{
			throw new NotImplementedException();
		}

		public void PartsOfTool(TopTools_ListOfShape theLT)
		{
			throw new NotImplementedException();
		}

		public void KeepParts(TopTools_ListOfShape theIm)
		{
			throw new NotImplementedException();
		}

		public void KeepPart(TopoDS_Shape theS)
		{
			throw new NotImplementedException();
		}

		public void PerformResult()
		{
			throw new NotImplementedException();
		}

		public void RebuildFaces()
		{
			throw new NotImplementedException();
		}

		public void RebuildEdge(TopoDS_Shape theE, TopoDS_Face theF, TopTools_MapOfShape theME, TopTools_ListOfShape aLEIm)
		{
			throw new NotImplementedException();
		}

		public void CheckSolidImages()
		{
			throw new NotImplementedException();
		}

		public void FillRemoved()
		{
			throw new NotImplementedException();
		}

		public void FillRemoved(TopoDS_Shape theS, TopTools_MapOfShape theM)
		{
			throw new NotImplementedException();
		}

		public void Prepare()
		{
			throw new NotImplementedException();
		}

		public void FillIn3DParts(TopTools_DataMapOfShapeShape theDraftSolids)
		{
			throw new NotImplementedException();
		}

		public bool CheckArgsForOpenSolid()
		{
			throw new NotImplementedException();
		}


	}; // class BRepFeat_Builder

}
