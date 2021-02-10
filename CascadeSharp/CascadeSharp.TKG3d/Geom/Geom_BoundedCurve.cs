//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Geom
{
	//---------------------------------------------------------------------
	//  Class  Geom_BoundedCurve
	//---------------------------------------------------------------------
	public  abstract class Geom_BoundedCurve : Geom_Curve
	{

		public Geom_BoundedCurve(Geom_BoundedCurve parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Geom_BoundedCurve()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public gp_Pnt EndPoint()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt StartPoint()
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Geom_BoundedCurve

}
