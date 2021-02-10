//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomBase.GeomLib
{
	//---------------------------------------------------------------------
	//  Class  GeomLib
	//---------------------------------------------------------------------
	public  sealed class GeomLib
	{

		public GeomLib()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomLib(GeomLib parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom_Curve To3d(gp_Ax2 Position, Geom2d_Curve Curve2d)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve GTransform(Geom2d_Curve Curve, gp_GTrsf2d GTrsf)
		{
			throw new NotImplementedException();
		}

		public void SameRange(double Tolerance, Geom2d_Curve Curve2dPtr, double First, double Last, double RequestedFirst, double RequestedLast, Geom2d_Curve NewCurve2dPtr)
		{
			throw new NotImplementedException();
		}

		public void BuildCurve3d(double Tolerance, Adaptor3d_CurveOnSurface CurvePtr, double FirstParameter, double LastParameter, Geom_Curve NewCurvePtr, ref double MaxDeviation, ref double AverageDeviation, GeomAbs_Shape Continuity, int MaxDegree, int MaxSegment)
		{
			throw new NotImplementedException();
		}

		public void BuildCurve3d(double Tolerance, Adaptor3d_CurveOnSurface CurvePtr, double FirstParameter, double LastParameter, Geom_Curve NewCurvePtr, ref double MaxDeviation, ref double AverageDeviation, GeomAbs_Shape Continuity, int MaxDegree)
		{
			throw new NotImplementedException();
		}

		public void BuildCurve3d(double Tolerance, Adaptor3d_CurveOnSurface CurvePtr, double FirstParameter, double LastParameter, Geom_Curve NewCurvePtr, ref double MaxDeviation, ref double AverageDeviation, GeomAbs_Shape Continuity)
		{
			throw new NotImplementedException();
		}

		public void BuildCurve3d(double Tolerance, Adaptor3d_CurveOnSurface CurvePtr, double FirstParameter, double LastParameter, Geom_Curve NewCurvePtr, ref double MaxDeviation, ref double AverageDeviation)
		{
			throw new NotImplementedException();
		}

		public void AdjustExtremity(Geom_BoundedCurve Curve, gp_Pnt P1, gp_Pnt P2, gp_Vec T1, gp_Vec T2)
		{
			throw new NotImplementedException();
		}

		public void ExtendCurveToPoint(Geom_BoundedCurve Curve, gp_Pnt Point, int Cont, bool After)
		{
			throw new NotImplementedException();
		}

		public void ExtendSurfByLength(Geom_BoundedSurface Surf, double Length, int Cont, bool InU, bool After)
		{
			throw new NotImplementedException();
		}

		public void AxeOfInertia(TColgp_Array1OfPnt Points, gp_Ax2 Axe, ref bool IsSingular, double Tol)
		{
			throw new NotImplementedException();
		}

		public void AxeOfInertia(TColgp_Array1OfPnt Points, gp_Ax2 Axe, ref bool IsSingular)
		{
			throw new NotImplementedException();
		}

		public void Inertia(TColgp_Array1OfPnt Points, gp_Pnt Bary, gp_Dir XDir, gp_Dir YDir, ref double Xgap, ref double YGap, ref double ZGap)
		{
			throw new NotImplementedException();
		}

		public void RemovePointsFromArray(int NumPoints, TColStd_Array1OfReal InParameters, TColStd_HArray1OfReal OutParameters)
		{
			throw new NotImplementedException();
		}

		public void DensifyArray1OfReal(int MinNumPoints, TColStd_Array1OfReal InParameters, TColStd_HArray1OfReal OutParameters)
		{
			throw new NotImplementedException();
		}

		public void FuseIntervals(TColStd_Array1OfReal Interval1, TColStd_Array1OfReal Interval2, TColStd_SequenceOfReal Fusion, double Confusion)
		{
			throw new NotImplementedException();
		}

		public void FuseIntervals(TColStd_Array1OfReal Interval1, TColStd_Array1OfReal Interval2, TColStd_SequenceOfReal Fusion)
		{
			throw new NotImplementedException();
		}

		public void EvalMaxParametricDistance(Adaptor3d_Curve Curve, Adaptor3d_Curve AReferenceCurve, double Tolerance, TColStd_Array1OfReal Parameters, ref double MaxD_istance)
		{
			throw new NotImplementedException();
		}

		public void EvalMaxDistanceAlongParameter(Adaptor3d_Curve Curve, Adaptor3d_Curve AReferenceCurve, double Tolerance, TColStd_Array1OfReal Parameters, ref double MaxD_istance)
		{
			throw new NotImplementedException();
		}

		public void CancelDenominatorDerivative(Geom_BSplineSurface BSurf, bool UDirection, bool VDirection)
		{
			throw new NotImplementedException();
		}

		public int NormEstim(Geom_Surface S, gp_Pnt2d UV, double Tol, gp_Dir N)
		{
			throw new NotImplementedException();
		}

		public void IsClosed(Geom_Surface S, double Tol, ref bool _isUClosed, ref bool _isVClosed)
		{
			throw new NotImplementedException();
		}

		public bool IsBSplUClosed(Geom_BSplineSurface S, double U1, double U2, double Tol)
		{
			throw new NotImplementedException();
		}

		public bool IsBSplVClosed(Geom_BSplineSurface S, double V1, double V2, double Tol)
		{
			throw new NotImplementedException();
		}

		public bool IsBzUClosed(Geom_BezierSurface S, double U1, double U2, double Tol)
		{
			throw new NotImplementedException();
		}

		public bool IsBzVClosed(Geom_BezierSurface S, double V1, double V2, double Tol)
		{
			throw new NotImplementedException();
		}

		public bool isIsoLine(Adaptor2d_HCurve2d theC2D, ref bool theIsU, ref double theParam, ref bool theIsForward)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve buildC3dOnIsoLine(Adaptor2d_HCurve2d theC2D, Adaptor3d_HSurface theSurf, double theFirst, double theLast, double theTolerance, bool theIsU, double theParam, bool theIsForward)
		{
			throw new NotImplementedException();
		}


	}; // class GeomLib

}
