//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepOffset_Inter3d
	//---------------------------------------------------------------------
	public  sealed class BRepOffset_Inter3d
	{

		public BRepOffset_Inter3d(BRepAlgo_AsDes AsDes, CascadeSharp.TopAbs_State Side, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_Inter3d(BRepOffset_Inter3d parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_Inter3d()
		{
			throw new NotImplementedException();
		}

		public void CompletInt(TopTools_ListOfShape SetOfFaces, BRepAlgo_Image InitOffsetFace)
		{
			throw new NotImplementedException();
		}

		public void FaceInter(TopoDS_Face F1, TopoDS_Face F2, BRepAlgo_Image InitOffsetFace)
		{
			throw new NotImplementedException();
		}

		public void ConnexIntByArc(TopTools_ListOfShape SetOfFaces, TopoDS_Shape ShapeInit, BRepOffset_Analyse Analyse, BRepAlgo_Image InitOffsetFace)
		{
			throw new NotImplementedException();
		}

		public void ConnexIntByInt(TopoDS_Shape SI, BRepOffset_DataMapOfShapeOffset MapSF, BRepOffset_Analyse A, TopTools_DataMapOfShapeShape MES, TopTools_DataMapOfShapeShape Build, TopTools_ListOfShape Failed, bool bIsPlanar)
		{
			throw new NotImplementedException();
		}

		public void ConnexIntByInt(TopoDS_Shape SI, BRepOffset_DataMapOfShapeOffset MapSF, BRepOffset_Analyse A, TopTools_DataMapOfShapeShape MES, TopTools_DataMapOfShapeShape Build, TopTools_ListOfShape Failed)
		{
			throw new NotImplementedException();
		}

		public void ContextIntByInt(TopTools_IndexedMapOfShape ContextFaces, bool ExtentContext, BRepOffset_DataMapOfShapeOffset MapSF, BRepOffset_Analyse A, TopTools_DataMapOfShapeShape MES, TopTools_DataMapOfShapeShape Build, TopTools_ListOfShape Failed, bool bIsPlanar)
		{
			throw new NotImplementedException();
		}

		public void ContextIntByInt(TopTools_IndexedMapOfShape ContextFaces, bool ExtentContext, BRepOffset_DataMapOfShapeOffset MapSF, BRepOffset_Analyse A, TopTools_DataMapOfShapeShape MES, TopTools_DataMapOfShapeShape Build, TopTools_ListOfShape Failed)
		{
			throw new NotImplementedException();
		}

		public void ContextIntByArc(TopTools_IndexedMapOfShape ContextFaces, bool ExtentContext, BRepOffset_Analyse Analyse, BRepAlgo_Image InitOffsetFace, BRepAlgo_Image InitOffsetEdge)
		{
			throw new NotImplementedException();
		}

		public void AddCommonEdges(TopTools_ListOfShape SetOfFaces)
		{
			throw new NotImplementedException();
		}

		public void SetDone(TopoDS_Face F1, TopoDS_Face F2)
		{
			throw new NotImplementedException();
		}

		public bool IsDone(TopoDS_Face F1, TopoDS_Face F2)
		{
			throw new NotImplementedException();
		}

		public TopTools_IndexedMapOfShape TouchedFaces()
		{
			throw new NotImplementedException();
		}

		public BRepAlgo_AsDes AsDes()
		{
			throw new NotImplementedException();
		}

		public TopTools_IndexedMapOfShape NewEdges()
		{
			throw new NotImplementedException();
		}

		public void Store(TopoDS_Face F1, TopoDS_Face F2, TopTools_ListOfShape LInt1, TopTools_ListOfShape LInt2)
		{
			throw new NotImplementedException();
		}


	}; // class BRepOffset_Inter3d

}
