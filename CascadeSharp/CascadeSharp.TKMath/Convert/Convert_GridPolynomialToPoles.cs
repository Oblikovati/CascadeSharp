//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Convert_GridPolynomialToPoles
	//---------------------------------------------------------------------
	public  sealed class Convert_GridPolynomialToPoles
	{

		public Convert_GridPolynomialToPoles(int MaxUDegree, int MaxVDegree, TColStd_HArray1OfInteger NumCoeff, TColStd_HArray1OfReal Coefficients, TColStd_HArray1OfReal PolynomialUIntervals, TColStd_HArray1OfReal PolynomialVIntervals)
			: base()
		{
			throw new NotImplementedException();
		}

		public Convert_GridPolynomialToPoles(int NbUSurfaces, int NBVSurfaces, int UContinuity, int VContinuity, int MaxUDegree, int MaxVDegree, TColStd_HArray2OfInteger NumCoeffPerSurface, TColStd_HArray1OfReal Coefficients, TColStd_HArray1OfReal PolynomialUIntervals, TColStd_HArray1OfReal PolynomialVIntervals, TColStd_HArray1OfReal TrueUIntervals, TColStd_HArray1OfReal TrueVIntervals)
			: base()
		{
			throw new NotImplementedException();
		}

		public Convert_GridPolynomialToPoles(Convert_GridPolynomialToPoles parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Convert_GridPolynomialToPoles()
		{
			throw new NotImplementedException();
		}

		public void Perform(int UContinuity, int VContinuity, int MaxUDegree, int MaxVDegree, TColStd_HArray2OfInteger NumCoeffPerSurface, TColStd_HArray1OfReal Coefficients, TColStd_HArray1OfReal PolynomialUIntervals, TColStd_HArray1OfReal PolynomialVIntervals, TColStd_HArray1OfReal TrueUIntervals, TColStd_HArray1OfReal TrueVIntervals)
		{
			throw new NotImplementedException();
		}

		public int NbUPoles()
		{
			throw new NotImplementedException();
		}

		public int NbVPoles()
		{
			throw new NotImplementedException();
		}

		public TColgp_HArray2OfPnt Poles()
		{
			throw new NotImplementedException();
		}

		public int UDegree()
		{
			throw new NotImplementedException();
		}

		public int VDegree()
		{
			throw new NotImplementedException();
		}

		public int NbUKnots()
		{
			throw new NotImplementedException();
		}

		public int NbVKnots()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfReal UKnots()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfReal VKnots()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfInteger UMultiplicities()
		{
			throw new NotImplementedException();
		}

		public TColStd_HArray1OfInteger VMultiplicities()
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public void BuildArray(int Degree, TColStd_HArray1OfReal Knots, int Continuty, TColStd_HArray1OfReal FlatKnots, TColStd_HArray1OfInteger Mults, TColStd_HArray1OfReal Parameters)
		{
			throw new NotImplementedException();
		}


	}; // class Convert_GridPolynomialToPoles

}
