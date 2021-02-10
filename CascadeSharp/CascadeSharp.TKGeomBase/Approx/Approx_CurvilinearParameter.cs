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
	//  Class  Approx_CurvilinearParameter
	//---------------------------------------------------------------------
	public  sealed class Approx_CurvilinearParameter
	{

		public Approx_CurvilinearParameter(Adaptor3d_HCurve C3D, double Tol, GeomAbs_Shape Order, int MaxDegree, int MaxSegments)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_CurvilinearParameter(Adaptor2d_HCurve2d C2D, Adaptor3d_HSurface Surf, double Tol, GeomAbs_Shape Order, int MaxDegree, int MaxSegments)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_CurvilinearParameter(Adaptor2d_HCurve2d C2D1, Adaptor3d_HSurface Surf1, Adaptor2d_HCurve2d C2D2, Adaptor3d_HSurface Surf2, double Tol, GeomAbs_Shape Order, int MaxDegree, int MaxSegments)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_CurvilinearParameter(Approx_CurvilinearParameter parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Approx_CurvilinearParameter()
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

		public Geom2d_BSplineCurve Curve2d1()
		{
			throw new NotImplementedException();
		}

		public double MaxError2d1()
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve Curve2d2()
		{
			throw new NotImplementedException();
		}

		public double MaxError2d2()
		{
			throw new NotImplementedException();
		}

				public void ToleranceComputation(Adaptor2d_HCurve2d C2D, Adaptor3d_HSurface S, int MaxNumber, double Tol, ref double TolV, ref double TolW)
		{
			throw new NotImplementedException();
		}


	}; // class Approx_CurvilinearParameter

}
