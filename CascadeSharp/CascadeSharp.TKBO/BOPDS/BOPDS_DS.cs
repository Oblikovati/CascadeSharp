//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BOPDS_DS
	//---------------------------------------------------------------------
	public  sealed class BOPDS_DS
	{

		public BOPDS_DS()
			: base()
		{
			throw new NotImplementedException();
		}

		public BOPDS_DS(NCollection_BaseAllocator theAllocator)
			: base()
		{
			throw new NotImplementedException();
		}

		public BOPDS_DS(BOPDS_DS parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public NCollection_BaseAllocator Allocator()
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

		public void Init(double theFuzz)
		{
			throw new NotImplementedException();
		}

		public void Init()
		{
			throw new NotImplementedException();
		}

		public int NbShapes()
		{
			throw new NotImplementedException();
		}

		public int NbSourceShapes()
		{
			throw new NotImplementedException();
		}

		public int NbRanges()
		{
			throw new NotImplementedException();
		}

		public BOPDS_IndexRange Range(int theIndex)
		{
			throw new NotImplementedException();
		}

		public int Rank(int theIndex)
		{
			throw new NotImplementedException();
		}

		public bool IsNewShape(int theIndex)
		{
			throw new NotImplementedException();
		}

		public int Append(BOPDS_ShapeInfo theSI)
		{
			throw new NotImplementedException();
		}

		public int Append(TopoDS_Shape theS)
		{
			throw new NotImplementedException();
		}

		public BOPDS_ShapeInfo ShapeInfo(int theIndex)
		{
			throw new NotImplementedException();
		}

		public BOPDS_ShapeInfo ChangeShapeInfo(int theIndex)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape(int theIndex)
		{
			throw new NotImplementedException();
		}

		public int Index(TopoDS_Shape theS)
		{
			throw new NotImplementedException();
		}

						public bool HasPaveBlocks(int theIndex)
		{
			throw new NotImplementedException();
		}

		public BOPDS_ListOfPaveBlock PaveBlocks(int theIndex)
		{
			throw new NotImplementedException();
		}

		public BOPDS_ListOfPaveBlock ChangePaveBlocks(int theIndex)
		{
			throw new NotImplementedException();
		}

		public void UpdatePaveBlocks()
		{
			throw new NotImplementedException();
		}

		public void UpdatePaveBlock(BOPDS_PaveBlock thePB)
		{
			throw new NotImplementedException();
		}

		public void UpdateCommonBlock(BOPDS_CommonBlock theCB, double theFuzz)
		{
			throw new NotImplementedException();
		}

		public bool IsCommonBlock(BOPDS_PaveBlock thePB)
		{
			throw new NotImplementedException();
		}

		public BOPDS_CommonBlock CommonBlock(BOPDS_PaveBlock thePB)
		{
			throw new NotImplementedException();
		}

		public void SetCommonBlock(BOPDS_PaveBlock thePB, BOPDS_CommonBlock theCB)
		{
			throw new NotImplementedException();
		}

		public BOPDS_PaveBlock RealPaveBlock(BOPDS_PaveBlock thePB)
		{
			throw new NotImplementedException();
		}

		public bool IsCommonBlockOnEdge(BOPDS_PaveBlock thePB)
		{
			throw new NotImplementedException();
		}

				public bool HasFaceInfo(int theIndex)
		{
			throw new NotImplementedException();
		}

		public BOPDS_FaceInfo FaceInfo(int theIndex)
		{
			throw new NotImplementedException();
		}

		public BOPDS_FaceInfo ChangeFaceInfo(int theIndex)
		{
			throw new NotImplementedException();
		}

		public void UpdateFaceInfoIn(int theIndex)
		{
			throw new NotImplementedException();
		}

		public void UpdateFaceInfoIn(TColStd_MapOfInteger theFaces)
		{
			throw new NotImplementedException();
		}

		public void UpdateFaceInfoOn(int theIndex)
		{
			throw new NotImplementedException();
		}

		public void UpdateFaceInfoOn(TColStd_MapOfInteger theFaces)
		{
			throw new NotImplementedException();
		}

		public void FaceInfoOn(int theIndex, BOPDS_IndexedMapOfPaveBlock theMPB, TColStd_MapOfInteger theMVP)
		{
			throw new NotImplementedException();
		}

		public void FaceInfoIn(int theIndex, BOPDS_IndexedMapOfPaveBlock theMPB, TColStd_MapOfInteger theMVP)
		{
			throw new NotImplementedException();
		}

		public void AloneVertices(int theF, TColStd_ListOfInteger theLI)
		{
			throw new NotImplementedException();
		}

		public void RefineFaceInfoOn()
		{
			throw new NotImplementedException();
		}

		public void RefineFaceInfoIn()
		{
			throw new NotImplementedException();
		}

		public void SubShapesOnIn(int theNF1, int theNF2, TColStd_MapOfInteger theMVOnIn, TColStd_MapOfInteger theMVCommon, BOPDS_IndexedMapOfPaveBlock thePBOnIn, BOPDS_MapOfPaveBlock theCommonPB)
		{
			throw new NotImplementedException();
		}

		public void SharedEdges(int theF1, int theF2, TColStd_ListOfInteger theLI, NCollection_BaseAllocator theAllocator)
		{
			throw new NotImplementedException();
		}

		public TColStd_DataMapOfIntegerInteger ShapesSD()
		{
			throw new NotImplementedException();
		}

		public void AddShapeSD(int theIndex, int theIndexSD)
		{
			throw new NotImplementedException();
		}

		public bool HasShapeSD(int theIndex, ref int theIndexSD)
		{
			throw new NotImplementedException();
		}

																						public int NbInterfTypes()
		{
			throw new NotImplementedException();
		}

		public bool AddInterf(int theI1, int theI2)
		{
			throw new NotImplementedException();
		}

		public bool HasInterf(int theI)
		{
			throw new NotImplementedException();
		}

		public bool HasInterf(int theI1, int theI2)
		{
			throw new NotImplementedException();
		}

		public bool HasInterfShapeSubShapes(int theI1, int theI2, bool theFlag)
		{
			throw new NotImplementedException();
		}

		public bool HasInterfShapeSubShapes(int theI1, int theI2)
		{
			throw new NotImplementedException();
		}

		public bool HasInterfSubShapes(int theI1, int theI2)
		{
			throw new NotImplementedException();
		}

		public BOPDS_MapOfPair Interferences()
		{
			throw new NotImplementedException();
		}

		public void Dump()
		{
			throw new NotImplementedException();
		}

		public bool IsSubShape(int theI1, int theI2)
		{
			throw new NotImplementedException();
		}

		public void Paves(int theIndex, BOPDS_ListOfPave theLP)
		{
			throw new NotImplementedException();
		}

		public void UpdatePaveBlocksWithSDVertices()
		{
			throw new NotImplementedException();
		}

		public void UpdatePaveBlockWithSDVertices(BOPDS_PaveBlock thePB)
		{
			throw new NotImplementedException();
		}

		public void UpdateCommonBlockWithSDVertices(BOPDS_CommonBlock theCB)
		{
			throw new NotImplementedException();
		}

		public void InitPaveBlocksForVertex(int theNV)
		{
			throw new NotImplementedException();
		}

		public void ReleasePaveBlocks()
		{
			throw new NotImplementedException();
		}

		public bool IsValidShrunkData(BOPDS_PaveBlock thePB)
		{
			throw new NotImplementedException();
		}

		public void BuildBndBoxSolid(int theIndex, Bnd_Box theBox, bool theCheckInverted)
		{
			throw new NotImplementedException();
		}

		public void BuildBndBoxSolid(int theIndex, Bnd_Box theBox)
		{
			throw new NotImplementedException();
		}

		public void InitPaveBlocks(int theIndex)
		{
			throw new NotImplementedException();
		}

		public void InitFaceInfo(int theIndex)
		{
			throw new NotImplementedException();
		}

		public void InitFaceInfoIn(int theIndex)
		{
			throw new NotImplementedException();
		}

		public void InitShape(int theIndex, TopoDS_Shape theS)
		{
			throw new NotImplementedException();
		}

		public bool CheckCoincidence(BOPDS_PaveBlock thePB1, BOPDS_PaveBlock thePB2, double theFuzz)
		{
			throw new NotImplementedException();
		}


	}; // class BOPDS_DS

}
