//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG2d.Geom2d
{
	//---------------------------------------------------------------------
	//  Class  Geom2d_Conic
	//---------------------------------------------------------------------
	public  abstract class Geom2d_Conic : Geom2d_Curve
	{

		public Geom2d_Conic()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Geom2d_Conic(Geom2d_Conic parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void SetAxis(gp_Ax22d theA)
		{
			throw new NotImplementedException();
		}

		public void SetXAxis(gp_Ax2d theAX)
		{
			throw new NotImplementedException();
		}

		public void SetYAxis(gp_Ax2d theAY)
		{
			throw new NotImplementedException();
		}

		public void SetLocation(gp_Pnt2d theP)
		{
			throw new NotImplementedException();
		}

		public gp_Ax2d XAxis()
		{
			throw new NotImplementedException();
		}

		public gp_Ax2d YAxis()
		{
			throw new NotImplementedException();
		}

		public double Eccentricity()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d Location()
		{
			throw new NotImplementedException();
		}

		public gp_Ax22d Position()
		{
			throw new NotImplementedException();
		}

		public void Reverse()
		{
			throw new NotImplementedException();
		}

		public double ReversedParameter(double U)
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public bool IsCN(int N)
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Geom2d_Conic

}
