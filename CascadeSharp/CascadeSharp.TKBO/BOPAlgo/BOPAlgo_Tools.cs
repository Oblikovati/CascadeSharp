//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBO.BOPDS;
using CascadeSharp.TKBO.IntTools;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKernel.NCollection;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBO.BOPAlgo
{
	//---------------------------------------------------------------------
	//  Class  BOPAlgo_Tools
	//---------------------------------------------------------------------
	public  sealed class BOPAlgo_Tools
	{

		public BOPAlgo_Tools()
			: base()
		{
			throw new NotImplementedException();
		}

		public BOPAlgo_Tools(BOPAlgo_Tools parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void FillMap(BOPDS_PaveBlock thePB1, int theF, BOPDS_IndexedDataMapOfPaveBlockListOfInteger theMILI, NCollection_BaseAllocator theAllocator)
		{
			throw new NotImplementedException();
		}

		public void PerformCommonBlocks(BOPDS_IndexedDataMapOfPaveBlockListOfPaveBlock theMBlocks, NCollection_BaseAllocator theAllocator, BOPDS_DS theDS, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public void PerformCommonBlocks(BOPDS_IndexedDataMapOfPaveBlockListOfPaveBlock theMBlocks, NCollection_BaseAllocator theAllocator, BOPDS_DS theDS)
		{
			throw new NotImplementedException();
		}

		public void PerformCommonBlocks(BOPDS_IndexedDataMapOfPaveBlockListOfInteger theMBlocks, NCollection_BaseAllocator theAllocator, BOPDS_DS pDS, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public void PerformCommonBlocks(BOPDS_IndexedDataMapOfPaveBlockListOfInteger theMBlocks, NCollection_BaseAllocator theAllocator, BOPDS_DS pDS)
		{
			throw new NotImplementedException();
		}

		public double ComputeToleranceOfCB(BOPDS_CommonBlock theCB, BOPDS_DS theDS, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public int EdgesToWires(TopoDS_Shape theEdges, TopoDS_Shape theWires, bool theShared, double theAngTol)
		{
			throw new NotImplementedException();
		}

		public int EdgesToWires(TopoDS_Shape theEdges, TopoDS_Shape theWires, bool theShared)
		{
			throw new NotImplementedException();
		}

		public int EdgesToWires(TopoDS_Shape theEdges, TopoDS_Shape theWires)
		{
			throw new NotImplementedException();
		}

		public bool WiresToFaces(TopoDS_Shape theWires, TopoDS_Shape theFaces, double theAngTol)
		{
			throw new NotImplementedException();
		}

		public bool WiresToFaces(TopoDS_Shape theWires, TopoDS_Shape theFaces)
		{
			throw new NotImplementedException();
		}

		public void IntersectVertices(TopTools_IndexedDataMapOfShapeReal theVertices, double theFuzzyValue, TopTools_ListOfListOfShape theChains)
		{
			throw new NotImplementedException();
		}

		public void ClassifyFaces(TopTools_ListOfShape theFaces, TopTools_ListOfShape theSolids, bool theRunParallel, IntTools_Context theContext, TopTools_IndexedDataMapOfShapeListOfShape theInParts, TopTools_DataMapOfShapeBox theShapeBoxMap, TopTools_DataMapOfShapeListOfShape theSolidsIF)
		{
			throw new NotImplementedException();
		}

		public void ClassifyFaces(TopTools_ListOfShape theFaces, TopTools_ListOfShape theSolids, bool theRunParallel, IntTools_Context theContext, TopTools_IndexedDataMapOfShapeListOfShape theInParts, TopTools_DataMapOfShapeBox theShapeBoxMap)
		{
			throw new NotImplementedException();
		}

		public void ClassifyFaces(TopTools_ListOfShape theFaces, TopTools_ListOfShape theSolids, bool theRunParallel, IntTools_Context theContext, TopTools_IndexedDataMapOfShapeListOfShape theInParts)
		{
			throw new NotImplementedException();
		}

		public void FillInternals(TopTools_ListOfShape theSolids, TopTools_ListOfShape theParts, TopTools_DataMapOfShapeListOfShape theImages, IntTools_Context theContext)
		{
			throw new NotImplementedException();
		}

		public bool TrsfToPoint(Bnd_Box theBox1, Bnd_Box theBox2, gp_Trsf theTrsf, gp_Pnt thePoint, double theCriteria)
		{
			throw new NotImplementedException();
		}

		public bool TrsfToPoint(Bnd_Box theBox1, Bnd_Box theBox2, gp_Trsf theTrsf, gp_Pnt thePoint)
		{
			throw new NotImplementedException();
		}

		public bool TrsfToPoint(Bnd_Box theBox1, Bnd_Box theBox2, gp_Trsf theTrsf)
		{
			throw new NotImplementedException();
		}


	}; // class BOPAlgo_Tools

}
