//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRepTool
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRepTool
	{

		public TopOpeBRepTool()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRepTool(TopOpeBRepTool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public bool PurgeClosingEdges(TopoDS_Face F, TopoDS_Face FF, TopTools_DataMapOfShapeInteger MW_isOld, TopTools_IndexedMapOfOrientedShape MshNOK)
		{
			throw new NotImplementedException();
		}

		public bool PurgeClosingEdges(TopoDS_Face F, TopTools_ListOfShape LOF, TopTools_DataMapOfShapeInteger MW_isOld, TopTools_IndexedMapOfOrientedShape MshNOK)
		{
			throw new NotImplementedException();
		}

		public bool CorrectONUVISO(TopoDS_Face F, TopoDS_Face Fsp)
		{
			throw new NotImplementedException();
		}

		public bool MakeFaces(TopoDS_Face F, TopTools_ListOfShape LOF, TopTools_IndexedMapOfOrientedShape MshNOK, TopTools_ListOfShape LOFF)
		{
			throw new NotImplementedException();
		}

		public bool Regularize(TopoDS_Face aFace, TopTools_ListOfShape aL_istOfFaces, TopTools_DataMapOfShapeListOfShape ESplits)
		{
			throw new NotImplementedException();
		}

		public bool RegularizeWires(TopoDS_Face aFace, TopTools_DataMapOfShapeListOfShape OldWiresNewWires, TopTools_DataMapOfShapeListOfShape ESplits)
		{
			throw new NotImplementedException();
		}

		public bool RegularizeFace(TopoDS_Face aFace, TopTools_DataMapOfShapeListOfShape OldWiresnewWires, TopTools_ListOfShape aL_istOfFaces)
		{
			throw new NotImplementedException();
		}

		public bool RegularizeShells(TopoDS_Solid aSolid, TopTools_DataMapOfShapeListOfShape OldSheNewShe, TopTools_DataMapOfShapeListOfShape FSplits)
		{
			throw new NotImplementedException();
		}

		
	}; // class TopOpeBRepTool

}
