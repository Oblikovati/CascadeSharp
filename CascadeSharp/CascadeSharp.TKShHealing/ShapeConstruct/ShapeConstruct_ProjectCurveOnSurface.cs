//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;
using CascadeSharp.TKShHealing.ShapeAnalysis;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeConstruct
{
	//---------------------------------------------------------------------
	//  Class  ShapeConstruct_ProjectCurveOnSurface
	//---------------------------------------------------------------------
	public  sealed class ShapeConstruct_ProjectCurveOnSurface : Standard_Transient
	{

		public ShapeConstruct_ProjectCurveOnSurface()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeConstruct_ProjectCurveOnSurface(ShapeConstruct_ProjectCurveOnSurface parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(Geom_Surface surf, double preci)
		{
			throw new NotImplementedException();
		}

		public void Init(ShapeAnalysis_Surface surf, double preci)
		{
			throw new NotImplementedException();
		}

		public void SetSurface(Geom_Surface surf)
		{
			throw new NotImplementedException();
		}

		public void SetSurface(ShapeAnalysis_Surface surf)
		{
			throw new NotImplementedException();
		}

		public void SetPrecision(double preci)
		{
			throw new NotImplementedException();
		}

		public bool BuildCurveMode()
		{
			throw new NotImplementedException();
		}

		public int AdjustOverDegenMode()
		{
			throw new NotImplementedException();
		}

		public bool Status(ShapeExtend_Status theStatus)
		{
			throw new NotImplementedException();
		}

		public bool Perform(Geom_Curve c3d, double First, double Last, Geom2d_Curve c2d, double TolFirst, double TolLast)
		{
			throw new NotImplementedException();
		}

		public bool Perform(Geom_Curve c3d, double First, double Last, Geom2d_Curve c2d, double TolFirst)
		{
			throw new NotImplementedException();
		}

		public bool Perform(Geom_Curve c3d, double First, double Last, Geom2d_Curve c2d)
		{
			throw new NotImplementedException();
		}

		public bool PerformByProjLib(Geom_Curve c3d, double First, double Last, Geom2d_Curve c2d, GeomAbs_Shape continuity, int maxdeg, int nbinterval)
		{
			throw new NotImplementedException();
		}

		public bool PerformByProjLib(Geom_Curve c3d, double First, double Last, Geom2d_Curve c2d, GeomAbs_Shape continuity, int maxdeg)
		{
			throw new NotImplementedException();
		}

		public bool PerformByProjLib(Geom_Curve c3d, double First, double Last, Geom2d_Curve c2d, GeomAbs_Shape continuity)
		{
			throw new NotImplementedException();
		}

		public bool PerformByProjLib(Geom_Curve c3d, double First, double Last, Geom2d_Curve c2d)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public Geom2d_Curve getLine(TColgp_SequenceOfPnt points, TColStd_SequenceOfReal _params, TColgp_SequenceOfPnt2d points2d, double theTol, ref bool IsRecompute, ref bool _isFromCashe)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve ProjectAnalytic(Geom_Curve c3d)
		{
			throw new NotImplementedException();
		}

		public bool ApproxPCurve(int nbrPnt, Geom_Curve c3d, double TolFirst, double TolLast, TColgp_SequenceOfPnt points, TColStd_SequenceOfReal _params, TColgp_SequenceOfPnt2d points2d, Geom2d_Curve c2d)
		{
			throw new NotImplementedException();
		}

		public void CorrectExtremity(Geom_Curve theC3d, TColStd_SequenceOfReal theParams, TColgp_SequenceOfPnt2d thePnt2d, bool theIsFirstPoint, gp_Pnt2d thePointOnIsoLine, bool theIsU_iso)
		{
			throw new NotImplementedException();
		}

		public void InsertAdditionalPointOrAdjust(ref bool ToAdjust, int theIndCoord, double Period, double TolOnPeriod, ref double CurCoord, double prevCoord, Geom_Curve c3d, ref int theIndex, TColgp_SequenceOfPnt points, TColStd_SequenceOfReal _params, TColgp_SequenceOfPnt2d pnt2d)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve InterpolatePCurve(int nbrPnt, TColgp_HArray1OfPnt2d points2d, TColStd_HArray1OfReal _params, Geom_Curve orig)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve ApproximatePCurve(int nbrPnt, TColgp_HArray1OfPnt2d points2d, TColStd_HArray1OfReal _params, Geom_Curve orig)
		{
			throw new NotImplementedException();
		}

		public Geom_Curve InterpolateCurve3d(int nbrPnt, TColgp_HArray1OfPnt points, TColStd_HArray1OfReal _params, Geom_Curve orig)
		{
			throw new NotImplementedException();
		}

		public void CheckPoints(TColgp_HArray1OfPnt points, TColStd_HArray1OfReal _params, ref double preci)
		{
			throw new NotImplementedException();
		}

		public void CheckPoints2d(TColgp_HArray1OfPnt2d points, TColStd_HArray1OfReal _params, ref double preci)
		{
			throw new NotImplementedException();
		}

		public bool IsAnIsoparametric(int nbrPnt, TColgp_SequenceOfPnt points, TColStd_SequenceOfReal _params, ref bool _isoTypeU, ref bool p1OnIso, gp_Pnt2d valueP1, ref bool p2OnIso, gp_Pnt2d valueP2, ref bool _isoPar2d3d, Geom_Curve cIso, ref double t1, ref double t2, TColStd_Array1OfReal pout)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeConstruct_ProjectCurveOnSurface

}
