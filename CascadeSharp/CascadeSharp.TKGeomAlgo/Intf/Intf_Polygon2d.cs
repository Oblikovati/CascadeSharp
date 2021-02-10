//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Intf_Polygon2d
	//---------------------------------------------------------------------
	public  abstract class Intf_Polygon2d
	{

		public Intf_Polygon2d()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Intf_Polygon2d(Intf_Polygon2d parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Bnd_Box2d Bounding()
		{
			throw new NotImplementedException();
		}

		public bool Closed()
		{
			throw new NotImplementedException();
		}

		public double DeflectionOverEstimation()
		{
			throw new NotImplementedException();
		}

		public int NbSegments()
		{
			throw new NotImplementedException();
		}

		public void Segment(int theIndex, gp_Pnt2d theBegin, gp_Pnt2d theEnd)
		{
			throw new NotImplementedException();
		}


	}; // class Intf_Polygon2d

}
