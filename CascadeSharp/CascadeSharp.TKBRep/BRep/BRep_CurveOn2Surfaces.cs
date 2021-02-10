//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.BRep
{
	//---------------------------------------------------------------------
	//  Class  BRep_CurveOn2Surfaces
	//---------------------------------------------------------------------
	public  sealed class BRep_CurveOn2Surfaces : BRep_CurveRepresentation
	{

		public BRep_CurveOn2Surfaces(Geom_Surface S1, Geom_Surface S2, TopLoc_Location L1, TopLoc_Location L2, GeomAbs_Shape C)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRep_CurveOn2Surfaces(BRep_CurveOn2Surfaces parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRep_CurveOn2Surfaces()
		{
			throw new NotImplementedException();
		}

		public bool IsRegularity()
		{
			throw new NotImplementedException();
		}

		public bool IsRegularity(Geom_Surface S1, Geom_Surface S2, TopLoc_Location L1, TopLoc_Location L2)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public Geom_Surface Surface()
		{
			throw new NotImplementedException();
		}

		public Geom_Surface Surface2()
		{
			throw new NotImplementedException();
		}

		public TopLoc_Location Location2()
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public void Continuity(GeomAbs_Shape C)
		{
			throw new NotImplementedException();
		}

		public BRep_CurveRepresentation Copy()
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRep_CurveOn2Surfaces

}
