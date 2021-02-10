//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.BRep
{
	//---------------------------------------------------------------------
	//  Class  BRep_GCurve
	//---------------------------------------------------------------------
	public  abstract class BRep_GCurve : BRep_CurveRepresentation
	{

		public BRep_GCurve(TopLoc_Location L, double First, double Last)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BRep_GCurve(BRep_GCurve parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public BRep_GCurve()
		{
			throw new NotImplementedException();
		}

		public void SetRange(double First, double Last)
		{
			throw new NotImplementedException();
		}

		public void Range(ref double First, ref double Last)
		{
			throw new NotImplementedException();
		}

		public double First()
		{
			throw new NotImplementedException();
		}

		public double Last()
		{
			throw new NotImplementedException();
		}

		public void First(double F)
		{
			throw new NotImplementedException();
		}

		public void Last(double L)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

						public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class BRep_GCurve

}
