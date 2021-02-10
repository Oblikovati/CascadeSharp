//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKGeomAlgo.Law;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
	//---------------------------------------------------------------------
	//  Class  GeomFill_TgtField
	//---------------------------------------------------------------------
	public  abstract class GeomFill_TgtField : Standard_Transient
	{

		public GeomFill_TgtField(GeomFill_TgtField parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public GeomFill_TgtField()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public bool IsScalable()
		{
			throw new NotImplementedException();
		}

		public void Scale(Law_BSpline Func)
		{
			throw new NotImplementedException();
		}

		public gp_Vec Value(double W)
		{
			throw new NotImplementedException();
		}

		public gp_Vec D1(double W)
		{
			throw new NotImplementedException();
		}

		public void D1(double W, gp_Vec V, gp_Vec DV)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class GeomFill_TgtField

}
