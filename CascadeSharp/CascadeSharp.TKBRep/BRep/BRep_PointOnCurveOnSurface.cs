//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.BRep
{
	//---------------------------------------------------------------------
	//  Class  BRep_PointOnCurveOnSurface
	//---------------------------------------------------------------------
	public  sealed class BRep_PointOnCurveOnSurface : BRep_PointsOnSurface
	{

		public BRep_PointOnCurveOnSurface(double P, Geom2d_Curve C, Geom_Surface S, TopLoc_Location L)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRep_PointOnCurveOnSurface(BRep_PointOnCurveOnSurface parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRep_PointOnCurveOnSurface()
		{
			throw new NotImplementedException();
		}

		public bool IsPointOnCurveOnSurface()
		{
			throw new NotImplementedException();
		}

		public bool IsPointOnCurveOnSurface(Geom2d_Curve PC, Geom_Surface S, TopLoc_Location L)
		{
			throw new NotImplementedException();
		}

		public Geom2d_Curve PCurve()
		{
			throw new NotImplementedException();
		}

		public void PCurve(Geom2d_Curve C)
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRep_PointOnCurveOnSurface

}
