//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_SimpleBound
	//---------------------------------------------------------------------
	public  sealed class GeomFill_SimpleBound : CascadeSharp.GeomFill_Boundary
	{

		public GeomFill_SimpleBound(Adaptor3d_HCurve Curve, double Tol3d, double Tolang)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SimpleBound(GeomFill_SimpleBound parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomFill_SimpleBound()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Value(double U)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, gp_Pnt P, gp_Vec V)
		{
			throw new NotImplementedException();
		}

		public void Reparametrize(double First, double Last, bool HasDF, bool HasDL, double DF, double DL, bool Rev)
		{
			throw new NotImplementedException();
		}

		public void Bounds(ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public bool IsDegenerated()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class GeomFill_SimpleBound

}
