//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKGeomBase.Approx
{
	//---------------------------------------------------------------------
	//  Class  Approx_CurveOnSurface
	//---------------------------------------------------------------------
	public  sealed class Approx_CurveOnSurface
	{

		public Approx_CurveOnSurface(Adaptor2d_HCurve2d C2D, Adaptor3d_HSurface Surf, double First, double Last, double Tol, GeomAbs_Shape Continuity, int MaxDegree, int MaxSegments, bool Only3d, bool Only2d)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_CurveOnSurface(Adaptor2d_HCurve2d C2D, Adaptor3d_HSurface Surf, double First, double Last, double Tol, GeomAbs_Shape Continuity, int MaxDegree, int MaxSegments, bool Only3d)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_CurveOnSurface(Adaptor2d_HCurve2d C2D, Adaptor3d_HSurface Surf, double First, double Last, double Tol, GeomAbs_Shape Continuity, int MaxDegree, int MaxSegments)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_CurveOnSurface(Adaptor2d_HCurve2d theC2D, Adaptor3d_HSurface theSurf, double theFirst, double theLast, double theTol)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_CurveOnSurface(Approx_CurveOnSurface parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_CurveOnSurface()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public bool HasResult()
		{
			throw new NotImplementedException();
		}

		public Geom_BSplineCurve Curve3d()
		{
			throw new NotImplementedException();
		}

		public double MaxError3d()
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve Curve2d()
		{
			throw new NotImplementedException();
		}

		public double MaxError2dU()
		{
			throw new NotImplementedException();
		}

		public double MaxError2dV()
		{
			throw new NotImplementedException();
		}

		public void Perform(int theMaxSegments, int theMaxDegree, GeomAbs_Shape theContinuity, bool theOnly3d, bool theOnly2d)
		{
			throw new NotImplementedException();
		}

		public void Perform(int theMaxSegments, int theMaxDegree, GeomAbs_Shape theContinuity, bool theOnly3d)
		{
			throw new NotImplementedException();
		}

		public void Perform(int theMaxSegments, int theMaxDegree, GeomAbs_Shape theContinuity)
		{
			throw new NotImplementedException();
		}

		public bool isIsoLine(Adaptor2d_HCurve2d theC2D, ref bool theIsU, ref double theParam, ref bool theIsForward)
		{
			throw new NotImplementedException();
		}

		public bool buildC3dOnIsoLine(Adaptor2d_HCurve2d theC2D, bool theIsU, double theParam, bool theIsForward)
		{
			throw new NotImplementedException();
		}


	}; // class Approx_CurveOnSurface

}
