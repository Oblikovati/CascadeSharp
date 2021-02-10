//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BOPAlgo_Builder
	//---------------------------------------------------------------------
	public  class BOPAlgo_Builder : CascadeSharp.BOPAlgo_BuilderShape
	{

		public BOPAlgo_Builder()
			: base()
		{
			throw new NotImplementedException();
		}

		public BOPAlgo_Builder(NCollection_BaseAllocator theAllocator)
			: base()
		{
			throw new NotImplementedException();
		}

		public BOPAlgo_Builder(BOPAlgo_Builder parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

				public BOPDS_DS PDS()
		{
			throw new NotImplementedException();
		}

		public IntTools_Context Context()
		{
			throw new NotImplementedException();
		}

		public void AddArgument(TopoDS_Shape theShape)
		{
			throw new NotImplementedException();
		}

		public void SetArguments(TopTools_ListOfShape theLS)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Arguments()
		{
			throw new NotImplementedException();
		}

		public void SetNonDestructive(bool theFlag)
		{
			throw new NotImplementedException();
		}

		public bool NonDestructive()
		{
			throw new NotImplementedException();
		}

		public void SetGlue(CascadeSharp.BOPAlgo_GlueEnum theGlue)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.BOPAlgo_GlueEnum Glue()
		{
			throw new NotImplementedException();
		}

		public void SetCheckInverted(bool theCheck)
		{
			throw new NotImplementedException();
		}

		public bool CheckInverted()
		{
			throw new NotImplementedException();
		}

		public void Perform()
		{
			throw new NotImplementedException();
		}

				public void BuildBOP(TopTools_ListOfShape theObjects, CascadeSharp.TopAbs_State theObjState, TopTools_ListOfShape theTools, CascadeSharp.TopAbs_State theToolsState, Message_Report theReport)
		{
			throw new NotImplementedException();
		}

		public void BuildBOP(TopTools_ListOfShape theObjects, CascadeSharp.TopAbs_State theObjState, TopTools_ListOfShape theTools, CascadeSharp.TopAbs_State theToolsState)
		{
			throw new NotImplementedException();
		}

		public void BuildBOP(TopTools_ListOfShape theObjects, TopTools_ListOfShape theTools, CascadeSharp.BOPAlgo_Operation theOperation, Message_Report theReport)
		{
			throw new NotImplementedException();
		}

		public void BuildBOP(TopTools_ListOfShape theObjects, TopTools_ListOfShape theTools, CascadeSharp.BOPAlgo_Operation theOperation)
		{
			throw new NotImplementedException();
		}

		public void PrepareHistory()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape LocModified(TopoDS_Shape theS)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape LocGenerated(TopoDS_Shape theS)
		{
			throw new NotImplementedException();
		}

		public TopTools_DataMapOfShapeListOfShape Images()
		{
			throw new NotImplementedException();
		}

		public TopTools_DataMapOfShapeListOfShape Origins()
		{
			throw new NotImplementedException();
		}

		public TopTools_DataMapOfShapeShape ShapesSD()
		{
			throw new NotImplementedException();
		}

						public void BuildResult(CascadeSharp.TopAbs_ShapeEnum theType)
		{
			throw new NotImplementedException();
		}

		public void CheckData()
		{
			throw new NotImplementedException();
		}

		public void CheckFiller()
		{
			throw new NotImplementedException();
		}

		public void Prepare()
		{
			throw new NotImplementedException();
		}

		public void FillImagesVertices()
		{
			throw new NotImplementedException();
		}

		public void FillImagesEdges()
		{
			throw new NotImplementedException();
		}

		public void FillImagesContainers(CascadeSharp.TopAbs_ShapeEnum theType)
		{
			throw new NotImplementedException();
		}

		public void FillImagesContainer(TopoDS_Shape theS, CascadeSharp.TopAbs_ShapeEnum theType)
		{
			throw new NotImplementedException();
		}

		public void FillImagesFaces()
		{
			throw new NotImplementedException();
		}

		public void BuildSplitFaces()
		{
			throw new NotImplementedException();
		}

		public void FillSameDomainFaces()
		{
			throw new NotImplementedException();
		}

		public void FillInternalVertices()
		{
			throw new NotImplementedException();
		}

		public void FillImagesSolids()
		{
			throw new NotImplementedException();
		}

		public void BuildDraftSolid(TopoDS_Shape theSolid, TopoDS_Shape theDraftSolid, TopTools_ListOfShape theLIF)
		{
			throw new NotImplementedException();
		}

		public void FillIn3DParts(TopTools_DataMapOfShapeShape theDraftSolids)
		{
			throw new NotImplementedException();
		}

		public void BuildSplitSolids(TopTools_DataMapOfShapeShape theDraftSolids)
		{
			throw new NotImplementedException();
		}

		public void FillInternalShapes()
		{
			throw new NotImplementedException();
		}

		public void FillImagesCompounds()
		{
			throw new NotImplementedException();
		}

		public void FillImagesCompound(TopoDS_Shape theS, TopTools_MapOfShape theMF)
		{
			throw new NotImplementedException();
		}

		public void PostTreat()
		{
			throw new NotImplementedException();
		}


	}; // class BOPAlgo_Builder

}
