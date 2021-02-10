//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_TrihedronWithGuide
	//---------------------------------------------------------------------
	public  abstract class GeomFill_TrihedronWithGuide : CascadeSharp.GeomFill_TrihedronLaw
	{

		public GeomFill_TrihedronWithGuide(GeomFill_TrihedronWithGuide parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public GeomFill_TrihedronWithGuide()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Adaptor3d_HCurve Guide()
		{
			throw new NotImplementedException();
		}

		public void Origine(double Param1, double Param2)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt CurrentPointOnGuide()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class GeomFill_TrihedronWithGuide

}
