//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  IntTools_Tools
	//---------------------------------------------------------------------
	public  sealed class IntTools_Tools
	{

		public IntTools_Tools()
			: base()
		{
			throw new NotImplementedException();
		}

		public IntTools_Tools(IntTools_Tools parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public int ComputeVV(TopoDS_Vertex V1, TopoDS_Vertex V2)
		{
			throw new NotImplementedException();
		}

		public bool HasInternalEdge(TopoDS_Wire aW)
		{
			throw new NotImplementedException();
		}

		public void MakeFaceFromWireAndFace(TopoDS_Wire aW, TopoDS_Face aF, TopoDS_Face aFNew)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_State ClassifyPointByFace(TopoDS_Face aF, gp_Pnt2d P)
		{
			throw new NotImplementedException();
		}

		public bool IsVertex(TopoDS_Edge E, double t)
		{
			throw new NotImplementedException();
		}

		public bool IsVertex(TopoDS_Edge E, TopoDS_Vertex V, double t)
		{
			throw new NotImplementedException();
		}

		public bool IsVertex(IntTools_CommonPrt aCmnPrt)
		{
			throw new NotImplementedException();
		}

		public bool IsMiddlePointsEqual(TopoDS_Edge E1, TopoDS_Edge E2)
		{
			throw new NotImplementedException();
		}

		public bool IsVertex(gp_Pnt aP, double aTolPV, TopoDS_Vertex aV)
		{
			throw new NotImplementedException();
		}

		public double IntermediatePoint(double aFirst, double aLast)
		{
			throw new NotImplementedException();
		}

		public int SplitCurve(IntTools_Curve aC, IntTools_SequenceOfCurves aS)
		{
			throw new NotImplementedException();
		}

		public void RejectLines(IntTools_SequenceOfCurves aSIn, IntTools_SequenceOfCurves aSOut)
		{
			throw new NotImplementedException();
		}

		public bool IsDirsCoinside(gp_Dir D1, gp_Dir D2)
		{
			throw new NotImplementedException();
		}

		public bool IsDirsCoinside(gp_Dir D1, gp_Dir D2, double aTol)
		{
			throw new NotImplementedException();
		}

		public bool IsClosed(Geom_Curve aC)
		{
			throw new NotImplementedException();
		}

		public double CurveTolerance(Geom_Curve aC, double aTolBase)
		{
			throw new NotImplementedException();
		}

		public bool CheckCurve(IntTools_Curve theCurve, Bnd_Box theBox)
		{
			throw new NotImplementedException();
		}

		public bool IsOnPave(double theT, IntTools_Range theRange, double theTol)
		{
			throw new NotImplementedException();
		}

		public void VertexParameters(IntTools_CommonPrt theCP, ref double theT1, ref double theT2)
		{
			throw new NotImplementedException();
		}

		public void VertexParameter(IntTools_CommonPrt theCP, ref double theT)
		{
			throw new NotImplementedException();
		}

		public bool IsOnPave1(double theT, IntTools_Range theRange, double theTol)
		{
			throw new NotImplementedException();
		}

		public bool IsInRange(IntTools_Range theRRef, IntTools_Range theR, double theTol)
		{
			throw new NotImplementedException();
		}

		public int SegPln(gp_Lin theLin, double theTLin1, double theTLin2, double theTolLin, gp_Pln thePln, double theTolPln, gp_Pnt theP, ref double theT, ref double theTolP, ref double theTmin, ref double theTmax)
		{
			throw new NotImplementedException();
		}

		public bool ComputeTolerance(Geom_Curve theCurve3D, Geom2d_Curve theCurve2D, Geom_Surface theSurf, double theFirst, double theLast, ref double theMaxD_ist, ref double theMaxPar, double theTolRange)
		{
			throw new NotImplementedException();
		}

		public bool ComputeTolerance(Geom_Curve theCurve3D, Geom2d_Curve theCurve2D, Geom_Surface theSurf, double theFirst, double theLast, ref double theMaxD_ist, ref double theMaxPar)
		{
			throw new NotImplementedException();
		}

		public double ComputeIntRange(double theTol1, double theTol2, double theAngle)
		{
			throw new NotImplementedException();
		}


	}; // class IntTools_Tools

}
