//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Geom_Point
	//---------------------------------------------------------------------
	public  abstract class Geom_Point : CascadeSharp.Geom_Geometry
	{

		public Geom_Point()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Geom_Point(Geom_Point parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void Coord(ref double X, ref double Y, ref double Z)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Pnt()
		{
			throw new NotImplementedException();
		}

		public double X()
		{
			throw new NotImplementedException();
		}

		public double Y()
		{
			throw new NotImplementedException();
		}

		public double Z()
		{
			throw new NotImplementedException();
		}

		public double Distance(Geom_Point Other)
		{
			throw new NotImplementedException();
		}

		public double SquareDistance(Geom_Point Other)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Geom_Point

}
