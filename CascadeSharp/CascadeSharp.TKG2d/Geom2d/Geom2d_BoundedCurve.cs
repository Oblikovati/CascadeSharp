//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Geom2d_BoundedCurve
	//---------------------------------------------------------------------
	public  abstract class Geom2d_BoundedCurve : CascadeSharp.Geom2d_Curve
	{

		public Geom2d_BoundedCurve(Geom2d_BoundedCurve parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Geom2d_BoundedCurve()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public gp_Pnt2d EndPoint()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d StartPoint()
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Geom2d_BoundedCurve

}
