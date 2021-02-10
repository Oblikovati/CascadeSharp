//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKMath.Convert
{
	//---------------------------------------------------------------------
	//  Class  Convert_ConicToBSplineCurve
	//---------------------------------------------------------------------
	public  class Convert_ConicToBSplineCurve
	{

		public Convert_ConicToBSplineCurve(int NumberOfPoles, int NumberOfKnots, int Degree)
			: base()
		{
			throw new NotImplementedException();
		}

		public Convert_ConicToBSplineCurve(Convert_ConicToBSplineCurve parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Convert_ConicToBSplineCurve()
		{
			throw new NotImplementedException();
		}

		public int Degree()
		{
			throw new NotImplementedException();
		}

		public int NbPoles()
		{
			throw new NotImplementedException();
		}

		public int NbKnots()
		{
			throw new NotImplementedException();
		}

		public bool IsPeriodic()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d Pole(int Index)
		{
			throw new NotImplementedException();
		}

		public double Weight(int Index)
		{
			throw new NotImplementedException();
		}

		public double Knot(int Index)
		{
			throw new NotImplementedException();
		}

		public int Multiplicity(int Index)
		{
			throw new NotImplementedException();
		}

		public void BuildCosAndSin(Convert_ParameterisationType Parametr_isation, TColStd_HArray1OfReal CosNumerator, TColStd_HArray1OfReal SinNumerator, TColStd_HArray1OfReal Denominator, ref int Degree, TColStd_HArray1OfReal Knots, TColStd_HArray1OfInteger Mults)
		{
			throw new NotImplementedException();
		}

		public void BuildCosAndSin(Convert_ParameterisationType Parametr_isation, double UFirst, double ULast, TColStd_HArray1OfReal CosNumerator, TColStd_HArray1OfReal SinNumerator, TColStd_HArray1OfReal Denominator, ref int Degree, TColStd_HArray1OfReal Knots, TColStd_HArray1OfInteger Mults)
		{
			throw new NotImplementedException();
		}


	}; // class Convert_ConicToBSplineCurve

}
