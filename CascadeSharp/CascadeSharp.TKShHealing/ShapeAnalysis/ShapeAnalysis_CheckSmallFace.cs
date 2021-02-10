//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeAnalysis
{
	//---------------------------------------------------------------------
	//  Class  ShapeAnalysis_CheckSmallFace
	//---------------------------------------------------------------------
	public  sealed class ShapeAnalysis_CheckSmallFace
	{

		public ShapeAnalysis_CheckSmallFace()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_CheckSmallFace(ShapeAnalysis_CheckSmallFace parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public int IsSpotFace(TopoDS_Face F, gp_Pnt spot, ref double spotol, double tol)
		{
			throw new NotImplementedException();
		}

		public int IsSpotFace(TopoDS_Face F, gp_Pnt spot, ref double spotol)
		{
			throw new NotImplementedException();
		}

		public bool CheckSpotFace(TopoDS_Face F, double tol)
		{
			throw new NotImplementedException();
		}

		public bool CheckSpotFace(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool IsStripSupport(TopoDS_Face F, double tol)
		{
			throw new NotImplementedException();
		}

		public bool IsStripSupport(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public bool CheckStripEdges(TopoDS_Edge E1, TopoDS_Edge E2, double tol, ref double dmax)
		{
			throw new NotImplementedException();
		}

		public bool FindStripEdges(TopoDS_Face F, TopoDS_Edge E1, TopoDS_Edge E2, double tol, ref double dmax)
		{
			throw new NotImplementedException();
		}

		public bool CheckSingleStrip(TopoDS_Face F, TopoDS_Edge E1, TopoDS_Edge E2, double tol)
		{
			throw new NotImplementedException();
		}

		public bool CheckSingleStrip(TopoDS_Face F, TopoDS_Edge E1, TopoDS_Edge E2)
		{
			throw new NotImplementedException();
		}

		public bool CheckStripFace(TopoDS_Face F, TopoDS_Edge E1, TopoDS_Edge E2, double tol)
		{
			throw new NotImplementedException();
		}

		public bool CheckStripFace(TopoDS_Face F, TopoDS_Edge E1, TopoDS_Edge E2)
		{
			throw new NotImplementedException();
		}

		public int CheckSplittingVertices(TopoDS_Face F, TopTools_DataMapOfShapeListOfShape MapEdges, ShapeAnalysis_DataMapOfShapeListOfReal MapParam, TopoDS_Compound theAllVert)
		{
			throw new NotImplementedException();
		}

		public bool CheckPin(TopoDS_Face F, ref int whatrow, ref int sence)
		{
			throw new NotImplementedException();
		}

		public bool CheckTwisted(TopoDS_Face F, ref double paramu, ref double paramv)
		{
			throw new NotImplementedException();
		}

		public bool CheckPinFace(TopoDS_Face F, TopTools_DataMapOfShapeShape mapEdges, double toler)
		{
			throw new NotImplementedException();
		}

		public bool CheckPinFace(TopoDS_Face F, TopTools_DataMapOfShapeShape mapEdges)
		{
			throw new NotImplementedException();
		}

		public bool CheckPinEdges(TopoDS_Edge theFirstEdge, TopoDS_Edge theSecondEdge, double coef1, double coef2, double toler)
		{
			throw new NotImplementedException();
		}

		public bool Status(ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public void SetTolerance(double tol)
		{
			throw new NotImplementedException();
		}

		public double Tolerance()
		{
			throw new NotImplementedException();
		}

		public bool StatusSpot(ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public bool StatusStrip(ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public bool StatusPin(ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public bool StatusTwisted(ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public bool StatusSplitVert(ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public bool StatusPinFace(ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public bool StatusPinEdges(ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeAnalysis_CheckSmallFace

}
