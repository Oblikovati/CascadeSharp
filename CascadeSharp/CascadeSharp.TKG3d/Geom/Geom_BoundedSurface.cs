//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Geom_BoundedSurface
	//---------------------------------------------------------------------
	public  abstract class Geom_BoundedSurface : CascadeSharp.Geom_Surface
	{

		public Geom_BoundedSurface(Geom_BoundedSurface parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Geom_BoundedSurface()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Geom_BoundedSurface

}
