//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKGeomAlgo.IntRes2d;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;
using CascadeSharp.TKMath.TopLoc;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeAnalysis
{
	//---------------------------------------------------------------------
	//  Class  ShapeAnalysis_Wire
	//---------------------------------------------------------------------
	public  sealed class ShapeAnalysis_Wire : Standard_Transient
	{

		public ShapeAnalysis_Wire()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_Wire(TopoDS_Wire wire, TopoDS_Face face, double prec_ision)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_Wire(ShapeExtend_WireData sbwd, TopoDS_Face face, double prec_ision)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_Wire(ShapeAnalysis_Wire parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Wire wire, TopoDS_Face face, double prec_ision)
		{
			throw new NotImplementedException();
		}

		public void Init(ShapeExtend_WireData sbwd, TopoDS_Face face, double prec_ision)
		{
			throw new NotImplementedException();
		}

		public void Load(TopoDS_Wire wire)
		{
			throw new NotImplementedException();
		}

		public void Load(ShapeExtend_WireData sbwd)
		{
			throw new NotImplementedException();
		}

		public void SetFace(TopoDS_Face face)
		{
			throw new NotImplementedException();
		}

		public void SetSurface(Geom_Surface surface)
		{
			throw new NotImplementedException();
		}

		public void SetSurface(Geom_Surface surface, TopLoc_Location location)
		{
			throw new NotImplementedException();
		}

		public void SetPrecision(double prec_ision)
		{
			throw new NotImplementedException();
		}

		public void ClearStatuses()
		{
			throw new NotImplementedException();
		}

		public bool IsLoaded()
		{
			throw new NotImplementedException();
		}

		public bool IsReady()
		{
			throw new NotImplementedException();
		}

		public double Precision()
		{
			throw new NotImplementedException();
		}

		public ShapeExtend_WireData WireData()
		{
			throw new NotImplementedException();
		}

		public int NbEdges()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face Face()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_Surface Surface()
		{
			throw new NotImplementedException();
		}

		public bool Perform()
		{
			throw new NotImplementedException();
		}

		public bool CheckOrder(bool _isClosed, bool mode3d)
		{
			throw new NotImplementedException();
		}

		public bool CheckOrder(bool _isClosed)
		{
			throw new NotImplementedException();
		}

		public bool CheckOrder()
		{
			throw new NotImplementedException();
		}

		public bool CheckConnected(double prec)
		{
			throw new NotImplementedException();
		}

		public bool CheckConnected()
		{
			throw new NotImplementedException();
		}

		public bool CheckSmall(double precsmall)
		{
			throw new NotImplementedException();
		}

		public bool CheckSmall()
		{
			throw new NotImplementedException();
		}

		public bool CheckEdgeCurves()
		{
			throw new NotImplementedException();
		}

		public bool CheckDegenerated()
		{
			throw new NotImplementedException();
		}

		public bool CheckClosed(double prec)
		{
			throw new NotImplementedException();
		}

		public bool CheckClosed()
		{
			throw new NotImplementedException();
		}

		public bool CheckSelfIntersection()
		{
			throw new NotImplementedException();
		}

		public bool CheckLacking()
		{
			throw new NotImplementedException();
		}

		public bool CheckGaps3d()
		{
			throw new NotImplementedException();
		}

		public bool CheckGaps2d()
		{
			throw new NotImplementedException();
		}

		public bool CheckCurveGaps()
		{
			throw new NotImplementedException();
		}

		public bool CheckOrder(ShapeAnalysis_WireOrder sawo, bool _isClosed, bool mode3d)
		{
			throw new NotImplementedException();
		}

		public bool CheckOrder(ShapeAnalysis_WireOrder sawo, bool _isClosed)
		{
			throw new NotImplementedException();
		}

		public bool CheckOrder(ShapeAnalysis_WireOrder sawo)
		{
			throw new NotImplementedException();
		}

		public bool CheckConnected(int num, double prec)
		{
			throw new NotImplementedException();
		}

		public bool CheckConnected(int num)
		{
			throw new NotImplementedException();
		}

		public bool CheckSmall(int num, double precsmall)
		{
			throw new NotImplementedException();
		}

		public bool CheckSmall(int num)
		{
			throw new NotImplementedException();
		}

		public bool CheckSeam(int num, Geom2d_Curve C1, Geom2d_Curve C2, ref double cf, ref double cl)
		{
			throw new NotImplementedException();
		}

		public bool CheckSeam(int num)
		{
			throw new NotImplementedException();
		}

		public bool CheckDegenerated(int num, gp_Pnt2d dgnr1, gp_Pnt2d dgnr2)
		{
			throw new NotImplementedException();
		}

		public bool CheckDegenerated(int num)
		{
			throw new NotImplementedException();
		}

		public bool CheckGap3d(int num)
		{
			throw new NotImplementedException();
		}

		public bool CheckGap3d()
		{
			throw new NotImplementedException();
		}

		public bool CheckGap2d(int num)
		{
			throw new NotImplementedException();
		}

		public bool CheckGap2d()
		{
			throw new NotImplementedException();
		}

		public bool CheckCurveGap(int num)
		{
			throw new NotImplementedException();
		}

		public bool CheckCurveGap()
		{
			throw new NotImplementedException();
		}

		public bool CheckSelfIntersectingEdge(int num, IntRes2d_SequenceOfIntersectionPoint points2d, TColgp_SequenceOfPnt points3d)
		{
			throw new NotImplementedException();
		}

		public bool CheckSelfIntersectingEdge(int num)
		{
			throw new NotImplementedException();
		}

		public bool CheckIntersectingEdges(int num, IntRes2d_SequenceOfIntersectionPoint points2d, TColgp_SequenceOfPnt points3d, TColStd_SequenceOfReal errors)
		{
			throw new NotImplementedException();
		}

		public bool CheckIntersectingEdges(int num)
		{
			throw new NotImplementedException();
		}

		public bool CheckIntersectingEdges(int num1, int num2, IntRes2d_SequenceOfIntersectionPoint points2d, TColgp_SequenceOfPnt points3d, TColStd_SequenceOfReal errors)
		{
			throw new NotImplementedException();
		}

		public bool CheckIntersectingEdges(int num1, int num2)
		{
			throw new NotImplementedException();
		}

		public bool CheckLacking(int num, double Tolerance, gp_Pnt2d p2d1, gp_Pnt2d p2d2)
		{
			throw new NotImplementedException();
		}

		public bool CheckLacking(int num, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public bool CheckLacking(int num)
		{
			throw new NotImplementedException();
		}

		public bool CheckOuterBound(bool APIMake)
		{
			throw new NotImplementedException();
		}

		public bool CheckOuterBound()
		{
			throw new NotImplementedException();
		}

		public bool CheckNotchedEdges(int num, ref int shortNum, ref double param, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public bool CheckNotchedEdges(int num, ref int shortNum, ref double param)
		{
			throw new NotImplementedException();
		}

		public bool CheckSmallArea(TopoDS_Wire theWire)
		{
			throw new NotImplementedException();
		}

		public bool CheckShapeConnect(TopoDS_Shape shape, double prec)
		{
			throw new NotImplementedException();
		}

		public bool CheckShapeConnect(TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public bool CheckShapeConnect(ref double tailhead, ref double tailtail, ref double headtail, ref double headhead, TopoDS_Shape shape, double prec)
		{
			throw new NotImplementedException();
		}

		public bool CheckShapeConnect(ref double tailhead, ref double tailtail, ref double headtail, ref double headhead, TopoDS_Shape shape)
		{
			throw new NotImplementedException();
		}

		public bool CheckLoop(TopTools_IndexedMapOfShape aMapLoopVertices, TopTools_DataMapOfShapeListOfShape aMapVertexEdges, TopTools_MapOfShape aMapSmallEdges, TopTools_MapOfShape aMapSeemEdges)
		{
			throw new NotImplementedException();
		}

		public bool CheckTail(TopoDS_Edge theEdge1, TopoDS_Edge theEdge2, double theMaxSine, double theMaxWidth, double theMaxTolerance, TopoDS_Edge theEdge11, TopoDS_Edge theEdge12, TopoDS_Edge theEdge21, TopoDS_Edge theEdge22)
		{
			throw new NotImplementedException();
		}

		public bool StatusOrder(ShapeExtend_Status Status)
		{
			throw new NotImplementedException();
		}

		public bool StatusConnected(ShapeExtend_Status Status)
		{
			throw new NotImplementedException();
		}

		public bool StatusEdgeCurves(ShapeExtend_Status Status)
		{
			throw new NotImplementedException();
		}

		public bool StatusDegenerated(ShapeExtend_Status Status)
		{
			throw new NotImplementedException();
		}

		public bool StatusClosed(ShapeExtend_Status Status)
		{
			throw new NotImplementedException();
		}

		public bool StatusSmall(ShapeExtend_Status Status)
		{
			throw new NotImplementedException();
		}

		public bool StatusSelfIntersection(ShapeExtend_Status Status)
		{
			throw new NotImplementedException();
		}

		public bool StatusLacking(ShapeExtend_Status Status)
		{
			throw new NotImplementedException();
		}

		public bool StatusGaps3d(ShapeExtend_Status Status)
		{
			throw new NotImplementedException();
		}

		public bool StatusGaps2d(ShapeExtend_Status Status)
		{
			throw new NotImplementedException();
		}

		public bool StatusCurveGaps(ShapeExtend_Status Status)
		{
			throw new NotImplementedException();
		}

		public bool StatusLoop(ShapeExtend_Status Status)
		{
			throw new NotImplementedException();
		}

		public bool LastCheckStatus(ShapeExtend_Status Status)
		{
			throw new NotImplementedException();
		}

		public double MinDistance3d()
		{
			throw new NotImplementedException();
		}

		public double MinDistance2d()
		{
			throw new NotImplementedException();
		}

		public double MaxDistance3d()
		{
			throw new NotImplementedException();
		}

		public double MaxDistance2d()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class ShapeAnalysis_Wire

}
