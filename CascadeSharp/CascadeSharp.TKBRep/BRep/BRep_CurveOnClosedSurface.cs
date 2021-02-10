//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.BRep
{
	//---------------------------------------------------------------------
	//  Class  BRep_CurveOnClosedSurface
	//---------------------------------------------------------------------
	public  sealed class BRep_CurveOnClosedSurface : BRep_CurveOnSurface
	{

		public BRep_CurveOnClosedSurface(Geom2d_Curve PC1, Geom2d_Curve PC2, Geom_Surface S, TopLoc_Location L, GeomAbs_Shape C)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRep_CurveOnClosedSurface(BRep_CurveOnClosedSurface parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRep_CurveOnClosedSurface()
		{
			throw new NotImplementedException();
		}

		public void SetUVPoints2(gp_Pnt2d P1, gp_Pnt2d P2)
		{
			throw new NotImplementedException();
		}

		public void UVPoints2(gp_Pnt2d P1, gp_Pnt2d P2)
		{
			throw new NotImplementedException();
		}

		public bool IsCurveOnClosedSurface()
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

		public Geom2d_Curve PCurve2()
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

		public void PCurve2(Geom2d_Curve C)
		{
			throw new NotImplementedException();
		}

		public BRep_CurveRepresentation Copy()
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRep_CurveOnClosedSurface

}
