//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.BRep
{
	//---------------------------------------------------------------------
	//  Class  BRep_PointOnSurface
	//---------------------------------------------------------------------
	public  sealed class BRep_PointOnSurface : BRep_PointsOnSurface
	{

		public BRep_PointOnSurface(double P1, double P2, Geom_Surface S, TopLoc_Location L)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRep_PointOnSurface(BRep_PointOnSurface parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRep_PointOnSurface()
		{
			throw new NotImplementedException();
		}

		public bool IsPointOnSurface()
		{
			throw new NotImplementedException();
		}

		public bool IsPointOnSurface(Geom_Surface S, TopLoc_Location L)
		{
			throw new NotImplementedException();
		}

		public double Parameter2()
		{
			throw new NotImplementedException();
		}

		public void Parameter2(double P)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRep_PointOnSurface

}
