//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG2d.TColGeom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TColGeom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKShHealing.ShapeAnalysis;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeAlgo
{
	//---------------------------------------------------------------------
	//  Class  ShapeAlgo_AlgoContainer
	//---------------------------------------------------------------------
	public  sealed class ShapeAlgo_AlgoContainer : Standard_Transient
	{

		public ShapeAlgo_AlgoContainer()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAlgo_AlgoContainer(ShapeAlgo_AlgoContainer parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetToolContainer(ShapeAlgo_ToolContainer TC)
		{
			throw new NotImplementedException();
		}

		public ShapeAlgo_ToolContainer ToolContainer()
		{
			throw new NotImplementedException();
		}

		public bool ConnectNextWire(ShapeAnalysis_Wire saw, ShapeExtend_WireData nextsewd, double maxtol, ref double d_istmin, ref bool revsewd, ref bool revnextsewd)
		{
			throw new NotImplementedException();
		}

		public void ApproxBSplineCurve(Geom_BSplineCurve bspline, TColGeom_SequenceOfCurve seq)
		{
			throw new NotImplementedException();
		}

		public void ApproxBSplineCurve(Geom2d_BSplineCurve bspline, TColGeom2d_SequenceOfCurve seq)
		{
			throw new NotImplementedException();
		}

		public bool C0BSplineToSequenceOfC1BSplineCurve(Geom_BSplineCurve BS, TColGeom_HSequenceOfBoundedCurve seqBS)
		{
			throw new NotImplementedException();
		}

		public bool C0BSplineToSequenceOfC1BSplineCurve(Geom2d_BSplineCurve BS, TColGeom2d_HSequenceOfBoundedCurve seqBS)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape C0ShapeToC1Shape(TopoDS_Shape shape, double tol)
		{
			throw new NotImplementedException();
		}

		public Geom_BSplineSurface ConvertSurfaceToBSpline(Geom_Surface surf, double UF, double UL, double VF, double VL)
		{
			throw new NotImplementedException();
		}

		public bool HomoWires(TopoDS_Wire wireIn1, TopoDS_Wire wireIn2, TopoDS_Wire wireOut1, TopoDS_Wire wireOut2, bool byParam)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Wire OuterWire(TopoDS_Face face)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface ConvertToPeriodic(Geom_Surface surf)
		{
			throw new NotImplementedException();
		}

		public void GetFaceUVBounds(TopoDS_Face F, ref double Umin, ref double Umax, ref double Vmin, ref double Vmax)
		{
			throw new NotImplementedException();
		}

		public Geom_BSplineCurve ConvertCurveToBSpline(Geom_Curve C3D, double First, double Last, double Tol3d, GeomAbs_Shape Continuity, int MaxSegments, int MaxDegree)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class ShapeAlgo_AlgoContainer

}
