//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepOffset_Tool
	//---------------------------------------------------------------------
	public  sealed class BRepOffset_Tool
	{

		public BRepOffset_Tool()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepOffset_Tool(BRepOffset_Tool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void EdgeVertices(TopoDS_Edge E, TopoDS_Vertex V1, TopoDS_Vertex V2)
		{
			throw new NotImplementedException();
		}

		public void OrientSection(TopoDS_Edge E, TopoDS_Face F1, TopoDS_Face F2,  ref CascadeSharp.TopAbs_Orientation O1,  ref CascadeSharp.TopAbs_Orientation O2)
		{
			throw new NotImplementedException();
		}

		public bool FindCommonShapes(TopoDS_Face theF1, TopoDS_Face theF2, TopTools_ListOfShape theLE, TopTools_ListOfShape theLV)
		{
			throw new NotImplementedException();
		}

		public bool FindCommonShapes(TopoDS_Shape theS1, TopoDS_Shape theS2, CascadeSharp.TopAbs_ShapeEnum theType, TopTools_ListOfShape theLSC)
		{
			throw new NotImplementedException();
		}

		public void Inter3D(TopoDS_Face F1, TopoDS_Face F2, TopTools_ListOfShape LInt1, TopTools_ListOfShape LInt2, CascadeSharp.TopAbs_State Side, TopoDS_Edge RefEdge, bool IsRefEdgeDefined)
		{
			throw new NotImplementedException();
		}

		public void Inter3D(TopoDS_Face F1, TopoDS_Face F2, TopTools_ListOfShape LInt1, TopTools_ListOfShape LInt2, CascadeSharp.TopAbs_State Side, TopoDS_Edge RefEdge)
		{
			throw new NotImplementedException();
		}

		public bool TryProject(TopoDS_Face F1, TopoDS_Face F2, TopTools_ListOfShape Edges, TopTools_ListOfShape LInt1, TopTools_ListOfShape LInt2, CascadeSharp.TopAbs_State Side, double TolConf)
		{
			throw new NotImplementedException();
		}

		public void PipeInter(TopoDS_Face F1, TopoDS_Face F2, TopTools_ListOfShape LInt1, TopTools_ListOfShape LInt2, CascadeSharp.TopAbs_State Side)
		{
			throw new NotImplementedException();
		}

		public void Inter2d(TopoDS_Face F, TopoDS_Edge E1, TopoDS_Edge E2, TopTools_ListOfShape LV, double Tol)
		{
			throw new NotImplementedException();
		}

		public void InterOrExtent(TopoDS_Face F1, TopoDS_Face F2, TopTools_ListOfShape LInt1, TopTools_ListOfShape LInt2, CascadeSharp.TopAbs_State Side)
		{
			throw new NotImplementedException();
		}

		public void CheckBounds(TopoDS_Face F, BRepOffset_Analyse Analyse, ref bool enlargeU, ref bool enlargeVfirst, ref bool enlargeVlast)
		{
			throw new NotImplementedException();
		}

		public bool EnLargeFace(TopoDS_Face F, TopoDS_Face NF, bool ChangeGeom, bool UpDatePCurve, bool enlargeU, bool enlargeVfirst, bool enlargeVlast, int theExtensionMode, double theLenBeforeUfirst, double theLenAfterUlast, double theLenBeforeVfirst, double theLenAfterVlast)
		{
			throw new NotImplementedException();
		}

		public bool EnLargeFace(TopoDS_Face F, TopoDS_Face NF, bool ChangeGeom, bool UpDatePCurve, bool enlargeU, bool enlargeVfirst, bool enlargeVlast, int theExtensionMode, double theLenBeforeUfirst, double theLenAfterUlast, double theLenBeforeVfirst)
		{
			throw new NotImplementedException();
		}

		public bool EnLargeFace(TopoDS_Face F, TopoDS_Face NF, bool ChangeGeom, bool UpDatePCurve, bool enlargeU, bool enlargeVfirst, bool enlargeVlast, int theExtensionMode, double theLenBeforeUfirst, double theLenAfterUlast)
		{
			throw new NotImplementedException();
		}

		public bool EnLargeFace(TopoDS_Face F, TopoDS_Face NF, bool ChangeGeom, bool UpDatePCurve, bool enlargeU, bool enlargeVfirst, bool enlargeVlast, int theExtensionMode, double theLenBeforeUfirst)
		{
			throw new NotImplementedException();
		}

		public bool EnLargeFace(TopoDS_Face F, TopoDS_Face NF, bool ChangeGeom, bool UpDatePCurve, bool enlargeU, bool enlargeVfirst, bool enlargeVlast, int theExtensionMode)
		{
			throw new NotImplementedException();
		}

		public bool EnLargeFace(TopoDS_Face F, TopoDS_Face NF, bool ChangeGeom, bool UpDatePCurve, bool enlargeU, bool enlargeVfirst, bool enlargeVlast)
		{
			throw new NotImplementedException();
		}

		public bool EnLargeFace(TopoDS_Face F, TopoDS_Face NF, bool ChangeGeom, bool UpDatePCurve, bool enlargeU, bool enlargeVfirst)
		{
			throw new NotImplementedException();
		}

		public bool EnLargeFace(TopoDS_Face F, TopoDS_Face NF, bool ChangeGeom, bool UpDatePCurve, bool enlargeU)
		{
			throw new NotImplementedException();
		}

		public bool EnLargeFace(TopoDS_Face F, TopoDS_Face NF, bool ChangeGeom, bool UpDatePCurve)
		{
			throw new NotImplementedException();
		}

		public bool EnLargeFace(TopoDS_Face F, TopoDS_Face NF, bool ChangeGeom)
		{
			throw new NotImplementedException();
		}

		public void ExtentFace(TopoDS_Face F, TopTools_DataMapOfShapeShape ConstShapes, TopTools_DataMapOfShapeShape ToBuild, CascadeSharp.TopAbs_State Side, double TolConf, TopoDS_Face NF)
		{
			throw new NotImplementedException();
		}

		public void BuildNeighbour(TopoDS_Wire W, TopoDS_Face F, TopTools_DataMapOfShapeShape NOnV1, TopTools_DataMapOfShapeShape NOnV2)
		{
			throw new NotImplementedException();
		}

		public void MapVertexEdges(TopoDS_Shape S, TopTools_DataMapOfShapeListOfShape MVE)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Deboucle3D(TopoDS_Shape S, TopTools_MapOfShape Boundary)
		{
			throw new NotImplementedException();
		}

		public void CorrectOrientation(TopoDS_Shape SI, TopTools_IndexedMapOfShape NewEdges, BRepAlgo_AsDes AsDes, BRepAlgo_Image InitOffset, double Offset)
		{
			throw new NotImplementedException();
		}

		public double Gabarit(Geom_Curve aCurve)
		{
			throw new NotImplementedException();
		}

		public bool CheckPlanesNormals(TopoDS_Face theFace1, TopoDS_Face theFace2, double theTolAng)
		{
			throw new NotImplementedException();
		}

		public bool CheckPlanesNormals(TopoDS_Face theFace1, TopoDS_Face theFace2)
		{
			throw new NotImplementedException();
		}


	}; // class BRepOffset_Tool

}
