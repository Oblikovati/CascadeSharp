//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  PLib_Base
	//---------------------------------------------------------------------
	public  abstract class PLib_Base : Standard_Transient
	{

		public PLib_Base(PLib_Base parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public PLib_Base()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public void ToCoefficients(int Dimension, int Degree, TColStd_Array1OfReal CoeffinBase, TColStd_Array1OfReal Coefficients)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, TColStd_Array1OfReal Bas_isValue)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, TColStd_Array1OfReal Bas_isValue, TColStd_Array1OfReal Bas_isD1)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, TColStd_Array1OfReal Bas_isValue, TColStd_Array1OfReal Bas_isD1, TColStd_Array1OfReal Bas_isD2)
		{
			throw new NotImplementedException();
		}

		public void D3(double U, TColStd_Array1OfReal Bas_isValue, TColStd_Array1OfReal Bas_isD1, TColStd_Array1OfReal Bas_isD2, TColStd_Array1OfReal Bas_isD3)
		{
			throw new NotImplementedException();
		}

		public int WorkDegree()
		{
			throw new NotImplementedException();
		}

		public void ReduceDegree(int Dimension, int MaxDegree, double Tol, ref double BaseCoeff, ref int NewDegree, ref double MaxError)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class PLib_Base

}
