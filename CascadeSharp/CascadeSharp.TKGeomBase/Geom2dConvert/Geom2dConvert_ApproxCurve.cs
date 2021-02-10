//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKGeomBase.Geom2dConvert
{
	//---------------------------------------------------------------------
	//  Class  Geom2dConvert_ApproxCurve
	//---------------------------------------------------------------------
	public  sealed class Geom2dConvert_ApproxCurve
	{

		public Geom2dConvert_ApproxCurve(Geom2d_Curve Curve, double Tol2d, GeomAbs_Shape Order, int MaxSegments, int MaxDegree)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dConvert_ApproxCurve(Adaptor2d_HCurve2d Curve, double Tol2d, GeomAbs_Shape Order, int MaxSegments, int MaxDegree)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dConvert_ApproxCurve(Geom2dConvert_ApproxCurve parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dConvert_ApproxCurve()
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve Curve()
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

		public double MaxError()
		{
			throw new NotImplementedException();
		}

				public void Approximate(Adaptor2d_HCurve2d theCurve, double theTol3d, GeomAbs_Shape theOrder, int theMaxSegments, int theMaxDegree)
		{
			throw new NotImplementedException();
		}


	}; // class Geom2dConvert_ApproxCurve

}
