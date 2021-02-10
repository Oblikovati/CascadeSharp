//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;

namespace CascadeSharp.TKGeomBase.GeomLib
{
	//---------------------------------------------------------------------
	//  Class  GeomLib_Check2dBSplineCurve
	//---------------------------------------------------------------------
	public  sealed class GeomLib_Check2dBSplineCurve
	{

		public GeomLib_Check2dBSplineCurve(Geom2d_BSplineCurve Curve, double Tolerance, double AngularTolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomLib_Check2dBSplineCurve(GeomLib_Check2dBSplineCurve parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomLib_Check2dBSplineCurve()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public void NeedTangentFix(ref bool FirstFlag, ref bool SecondFlag)
		{
			throw new NotImplementedException();
		}

		public void FixTangent(bool FirstFlag, bool LastFlag)
		{
			throw new NotImplementedException();
		}

		public Geom2d_BSplineCurve FixedTangent(bool FirstFlag, bool LastFlag)
		{
			throw new NotImplementedException();
		}

		public void FixTangentOnCurve(Geom2d_BSplineCurve theCurve, bool FirstFlag, bool LastFlag)
		{
			throw new NotImplementedException();
		}


	}; // class GeomLib_Check2dBSplineCurve

}
