//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKGeomBase.AppParCurves;

namespace CascadeSharp.TKGeomBase.ProjLib
{
	//---------------------------------------------------------------------
	//  Class  ProjLib_ComputeApproxOnPolarSurface
	//---------------------------------------------------------------------
	public  sealed class ProjLib_ComputeApproxOnPolarSurface
	{

		public ProjLib_ComputeApproxOnPolarSurface()
			: base()
		{
			throw new NotImplementedException();
		}

		public ProjLib_ComputeApproxOnPolarSurface(Adaptor3d_HCurve C, Adaptor3d_HSurface S, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public ProjLib_ComputeApproxOnPolarSurface(Adaptor3d_HCurve C, Adaptor3d_HSurface S)
			: base()
		{
			throw new NotImplementedException();
		}

		public ProjLib_ComputeApproxOnPolarSurface(Adaptor2d_HCurve2d InitCurve2d, Adaptor3d_HCurve C, Adaptor3d_HSurface S, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public ProjLib_ComputeApproxOnPolarSurface(Adaptor2d_HCurve2d InitCurve2d, Adaptor2d_HCurve2d InitCurve2dB_is, Adaptor3d_HCurve C, Adaptor3d_HSurface S, double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public ProjLib_ComputeApproxOnPolarSurface(ProjLib_ComputeApproxOnPolarSurface parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetDegree(int theDegMin, int theDegMax)
		{
			throw new NotImplementedException();
		}

		public void SetMaxSegments(int theMaxSegments)
		{
			throw new NotImplementedException();
		}

		public void SetBndPnt(AppParCurves_Constraint theBndPnt)
		{
			throw new NotImplementedException();
		}

		public void SetMaxDist(double theMaxD_ist)
		{
			throw new NotImplementedException();
		}

		public void SetTolerance(double theTolerance)
		{
			throw new NotImplementedException();
		}

		public void Perform(Adaptor3d_HCurve C, Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve Perform(Adaptor2d_HCurve2d InitCurve2d, Adaptor3d_HCurve C, Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public Adaptor2d_HCurve2d BuildInitialCurve2d(Adaptor3d_HCurve Curve, Adaptor3d_HSurface S)
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve ProjectUsingInitialCurve2d(Adaptor3d_HCurve Curve, Adaptor3d_HSurface S, Adaptor2d_HCurve2d InitCurve2d)
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve BSpline()
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve Curve2d()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public double Tolerance()
		{
			throw new NotImplementedException();
		}


	}; // class ProjLib_ComputeApproxOnPolarSurface

}
