//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.math;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKMath.PLib
{
	//---------------------------------------------------------------------
	//  Class  PLib
	//---------------------------------------------------------------------
	public  sealed class PLib
	{

		public PLib()
			: base()
		{
			throw new NotImplementedException();
		}

		public PLib(PLib parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public TColStd_Array1OfReal NoWeights()
		{
			throw new NotImplementedException();
		}

		public TColStd_Array2OfReal NoWeights2()
		{
			throw new NotImplementedException();
		}

		public void SetPoles(TColgp_Array1OfPnt Poles, TColStd_Array1OfReal FP)
		{
			throw new NotImplementedException();
		}

		public void SetPoles(TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal FP)
		{
			throw new NotImplementedException();
		}

		public void GetPoles(TColStd_Array1OfReal FP, TColgp_Array1OfPnt Poles)
		{
			throw new NotImplementedException();
		}

		public void GetPoles(TColStd_Array1OfReal FP, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights)
		{
			throw new NotImplementedException();
		}

		public void SetPoles(TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal FP)
		{
			throw new NotImplementedException();
		}

		public void SetPoles(TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal FP)
		{
			throw new NotImplementedException();
		}

		public void GetPoles(TColStd_Array1OfReal FP, TColgp_Array1OfPnt2d Poles)
		{
			throw new NotImplementedException();
		}

		public void GetPoles(TColStd_Array1OfReal FP, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights)
		{
			throw new NotImplementedException();
		}

		public double Bin(int N, int P)
		{
			throw new NotImplementedException();
		}

		public void RationalDerivative(int Degree, int N, int Dimension, ref double Ders, ref double RDers, bool All)
		{
			throw new NotImplementedException();
		}

		public void RationalDerivative(int Degree, int N, int Dimension, ref double Ders, ref double RDers)
		{
			throw new NotImplementedException();
		}

		public void RationalDerivatives(int DerivativesRequest, int Dimension, ref double PolesDerivatives, ref double WeightsDerivatives, ref double RationalDerivates)
		{
			throw new NotImplementedException();
		}

		public void EvalPolynomial(double U, int DerivativeOrder, int Degree, int Dimension, ref double PolynomialCoeff, ref double Results)
		{
			throw new NotImplementedException();
		}

		public void NoDerivativeEvalPolynomial(double U, int Degree, int Dimension, int DegreeDimension, ref double PolynomialCoeff, ref double Results)
		{
			throw new NotImplementedException();
		}

		public void EvalPoly2Var(double U, double V, int UDerivativeOrder, int VDerivativeOrder, int UDegree, int VDegree, int Dimension, ref double PolynomialCoeff, ref double Results)
		{
			throw new NotImplementedException();
		}

		public int EvalLagrange(double U, int DerivativeOrder, int Degree, int Dimension, ref double ValueArray, ref double ParameterArray, ref double Results)
		{
			throw new NotImplementedException();
		}

		public int EvalCubicHermite(double U, int DerivativeOrder, int Dimension, ref double ValueArray, ref double DerivativeArray, ref double ParameterArray, ref double Results)
		{
			throw new NotImplementedException();
		}

		public bool HermiteCoefficients(double FirstParameter, double LastParameter, int FirstOrder, int LastOrder, math_Matrix MatrixCoefs)
		{
			throw new NotImplementedException();
		}

		public void CoefficientsPoles(TColgp_Array1OfPnt Coefs, TColStd_Array1OfReal WCoefs, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal WPoles)
		{
			throw new NotImplementedException();
		}

		public void CoefficientsPoles(TColgp_Array1OfPnt2d Coefs, TColStd_Array1OfReal WCoefs, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal WPoles)
		{
			throw new NotImplementedException();
		}

		public void CoefficientsPoles(TColStd_Array1OfReal Coefs, TColStd_Array1OfReal WCoefs, TColStd_Array1OfReal Poles, TColStd_Array1OfReal WPoles)
		{
			throw new NotImplementedException();
		}

		public void CoefficientsPoles(int dim, TColStd_Array1OfReal Coefs, TColStd_Array1OfReal WCoefs, TColStd_Array1OfReal Poles, TColStd_Array1OfReal WPoles)
		{
			throw new NotImplementedException();
		}

		public void Trimming(double U1, double U2, TColgp_Array1OfPnt Coeffs, TColStd_Array1OfReal WCoeffs)
		{
			throw new NotImplementedException();
		}

		public void Trimming(double U1, double U2, TColgp_Array1OfPnt2d Coeffs, TColStd_Array1OfReal WCoeffs)
		{
			throw new NotImplementedException();
		}

		public void Trimming(double U1, double U2, TColStd_Array1OfReal Coeffs, TColStd_Array1OfReal WCoeffs)
		{
			throw new NotImplementedException();
		}

		public void Trimming(double U1, double U2, int dim, TColStd_Array1OfReal Coeffs, TColStd_Array1OfReal WCoeffs)
		{
			throw new NotImplementedException();
		}

		public void CoefficientsPoles(TColgp_Array2OfPnt Coefs, TColStd_Array2OfReal WCoefs, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal WPoles)
		{
			throw new NotImplementedException();
		}

		public void UTrimming(double U1, double U2, TColgp_Array2OfPnt Coeffs, TColStd_Array2OfReal WCoeffs)
		{
			throw new NotImplementedException();
		}

		public void VTrimming(double V1, double V2, TColgp_Array2OfPnt Coeffs, TColStd_Array2OfReal WCoeffs)
		{
			throw new NotImplementedException();
		}

		public bool HermiteInterpolate(int Dimension, double FirstParameter, double LastParameter, int FirstOrder, int LastOrder, TColStd_Array2OfReal FirstConstr, TColStd_Array2OfReal LastConstr, TColStd_Array1OfReal Coefficients)
		{
			throw new NotImplementedException();
		}

		public void JacobiParameters(GeomAbs_Shape ConstraintOrder, int MaxDegree, int Code, ref int NbGaussPoints, ref int WorkDegree)
		{
			throw new NotImplementedException();
		}

		public int NivConstr(GeomAbs_Shape ConstraintOrder)
		{
			throw new NotImplementedException();
		}

		public GeomAbs_Shape ConstraintOrder(int NivConstr)
		{
			throw new NotImplementedException();
		}

		public void EvalLength(int Degree, int Dimension, ref double PolynomialCoeff, double U1, double U2, ref double Length)
		{
			throw new NotImplementedException();
		}

		public void EvalLength(int Degree, int Dimension, ref double PolynomialCoeff, double U1, double U2, double Tol, ref double Length, ref double Error)
		{
			throw new NotImplementedException();
		}


	}; // class PLib

}
