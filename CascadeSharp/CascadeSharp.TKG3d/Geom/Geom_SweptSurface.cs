//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Geom_SweptSurface
	//---------------------------------------------------------------------
	public  abstract class Geom_SweptSurface : CascadeSharp.Geom_Surface
	{

		public Geom_SweptSurface(Geom_SweptSurface parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Geom_SweptSurface()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public CascadeSharp.GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public gp_Dir Direction()
		{
			throw new NotImplementedException();
		}

		public Geom_Curve BasisCurve()
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Geom_SweptSurface

}
