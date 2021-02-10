//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Law_Constant
	//---------------------------------------------------------------------
	public  sealed class Law_Constant : CascadeSharp.Law_Function
	{

		public Law_Constant()
			: base()
		{
			throw new NotImplementedException();
		}

		public Law_Constant(Law_Constant parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Set(double Radius, double PFirst, double PLast)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public int NbIntervals(CascadeSharp.GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Intervals(TColStd_Array1OfReal T, CascadeSharp.GeomAbs_Shape S)
		{
			throw new NotImplementedException();
		}

		public double Value(double X)
		{
			throw new NotImplementedException();
		}

		public void D1(double X, ref double F, ref double D)
		{
			throw new NotImplementedException();
		}

		public void D2(double X, ref double F, ref double D, ref double D2)
		{
			throw new NotImplementedException();
		}

		public Law_Function Trim(double PFirst, double PLast, double Tol)
		{
			throw new NotImplementedException();
		}

		public void Bounds(ref double PFirst, ref double PLast)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class Law_Constant

}
