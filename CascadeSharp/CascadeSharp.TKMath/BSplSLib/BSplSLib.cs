//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKMath.BSplSLib
{
	//---------------------------------------------------------------------
	//  Class  BSplSLib
	//---------------------------------------------------------------------
	public  sealed class BSplSLib
	{

		public BSplSLib()
			: base()
		{
			throw new NotImplementedException();
		}

		public BSplSLib(BSplSLib parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void RationalDerivative(int UDeg, int VDeg, int N, int M, ref double Ders, ref double RDers, bool All)
		{
			throw new NotImplementedException();
		}

		public void RationalDerivative(int UDeg, int VDeg, int N, int M, ref double Ders, ref double RDers)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, double V, int UIndex, int VIndex, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal UKnots, TColStd_Array1OfReal VKnots, TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int UDegree, int VDegree, bool URat, bool VRat, bool UPer, bool VPer, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, double V, int UIndex, int VIndex, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal UKnots, TColStd_Array1OfReal VKnots, TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int Degree, int VDegree, bool URat, bool VRat, bool UPer, bool VPer, gp_Pnt P, gp_Vec Vu, gp_Vec Vv)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, double V, int UIndex, int VIndex, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal UKnots, TColStd_Array1OfReal VKnots, TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int UDegree, int VDegree, bool URat, bool VRat, bool UPer, bool VPer, gp_Pnt P, gp_Vec Vu, gp_Vec Vv, gp_Vec Vuu, gp_Vec Vvv, gp_Vec Vuv)
		{
			throw new NotImplementedException();
		}

		public void D3(double U, double V, int UIndex, int VIndex, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal UKnots, TColStd_Array1OfReal VKnots, TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int UDegree, int VDegree, bool URat, bool VRat, bool UPer, bool VPer, gp_Pnt P, gp_Vec Vu, gp_Vec Vv, gp_Vec Vuu, gp_Vec Vvv, gp_Vec Vuv, gp_Vec Vuuu, gp_Vec Vvvv, gp_Vec Vuuv, gp_Vec Vuvv)
		{
			throw new NotImplementedException();
		}

		public void DN(double U, double V, int Nu, int Nv, int UIndex, int VIndex, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal UKnots, TColStd_Array1OfReal VKnots, TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int UDegree, int VDegree, bool URat, bool VRat, bool UPer, bool VPer, gp_Vec Vn)
		{
			throw new NotImplementedException();
		}

		public void Iso(double Param, bool IsU, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, int Degree, bool Periodic, TColgp_Array1OfPnt CPoles, TColStd_Array1OfReal CWeights)
		{
			throw new NotImplementedException();
		}

		public void Reverse(TColgp_Array2OfPnt Poles, int Last, bool UDirection)
		{
			throw new NotImplementedException();
		}

		public void HomogeneousD0(double U, double V, int UIndex, int VIndex, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal UKnots, TColStd_Array1OfReal VKnots, TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int UDegree, int VDegree, bool URat, bool VRat, bool UPer, bool VPer, ref double W, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void HomogeneousD1(double U, double V, int UIndex, int VIndex, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal UKnots, TColStd_Array1OfReal VKnots, TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int UDegree, int VDegree, bool URat, bool VRat, bool UPer, bool VPer, gp_Pnt N, gp_Vec Nu, gp_Vec Nv, ref double D, ref double Du, ref double Dv)
		{
			throw new NotImplementedException();
		}

		public void Reverse(TColStd_Array2OfReal Weights, int Last, bool UDirection)
		{
			throw new NotImplementedException();
		}

		public bool IsRational(TColStd_Array2OfReal Weights, int I1, int I2, int J1, int J2, double Epsilon)
		{
			throw new NotImplementedException();
		}

		public bool IsRational(TColStd_Array2OfReal Weights, int I1, int I2, int J1, int J2)
		{
			throw new NotImplementedException();
		}

		public void SetPoles(TColgp_Array2OfPnt Poles, TColStd_Array1OfReal FP, bool UDirection)
		{
			throw new NotImplementedException();
		}

		public void SetPoles(TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal FP, bool UDirection)
		{
			throw new NotImplementedException();
		}

		public void GetPoles(TColStd_Array1OfReal FP, TColgp_Array2OfPnt Poles, bool UDirection)
		{
			throw new NotImplementedException();
		}

		public void GetPoles(TColStd_Array1OfReal FP, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, bool UDirection)
		{
			throw new NotImplementedException();
		}

		public void MovePoint(double U, double V, gp_Vec D_ispl, int UIndex1, int UIndex2, int VIndex1, int VIndex2, int UDegree, int VDegree, bool Rational, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal UFlatKnots, TColStd_Array1OfReal VFlatKnots, ref int UFirstIndex, ref int ULastIndex, ref int VFirstIndex, ref int VLastIndex, TColgp_Array2OfPnt NewPoles)
		{
			throw new NotImplementedException();
		}

		public void InsertKnots(bool UDirection, int Degree, bool Periodic, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal AddKnots, TColStd_Array1OfInteger AddMults, TColgp_Array2OfPnt NewPoles, TColStd_Array2OfReal NewWeights, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, double Epsilon, bool Add)
		{
			throw new NotImplementedException();
		}

		public void InsertKnots(bool UDirection, int Degree, bool Periodic, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal AddKnots, TColStd_Array1OfInteger AddMults, TColgp_Array2OfPnt NewPoles, TColStd_Array2OfReal NewWeights, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, double Epsilon)
		{
			throw new NotImplementedException();
		}

		public bool RemoveKnot(bool UDirection, int Index, int Mult, int Degree, bool Periodic, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColgp_Array2OfPnt NewPoles, TColStd_Array2OfReal NewWeights, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public void IncreaseDegree(bool UDirection, int Degree, int NewDegree, bool Periodic, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColgp_Array2OfPnt NewPoles, TColStd_Array2OfReal NewWeights, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults)
		{
			throw new NotImplementedException();
		}

		public void Unperiodize(bool UDirection, int Degree, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal Knots, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfInteger NewMults, TColStd_Array1OfReal NewKnots, TColgp_Array2OfPnt NewPoles, TColStd_Array2OfReal NewWeights)
		{
			throw new NotImplementedException();
		}

		public TColStd_Array2OfReal NoWeights()
		{
			throw new NotImplementedException();
		}

		public void BuildCache(double U, double V, double USpanDomain, double VSpanDomain, bool UPeriodicFlag, bool VPeriodicFlag, int UDegree, int VDegree, int UIndex, int VIndex, TColStd_Array1OfReal UFlatKnots, TColStd_Array1OfReal VFlatKnots, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColgp_Array2OfPnt CachePoles, TColStd_Array2OfReal CacheWeights)
		{
			throw new NotImplementedException();
		}

		public void BuildCache(double theU, double theV, double theUSpanDomain, double theVSpanDomain, bool theUPeriodic, bool theVPeriodic, int theUDegree, int theVDegree, int theUIndex, int theVIndex, TColStd_Array1OfReal theUFlatKnots, TColStd_Array1OfReal theVFlatKnots, TColgp_Array2OfPnt thePoles, TColStd_Array2OfReal theWeights, TColStd_Array2OfReal theCacheArray)
		{
			throw new NotImplementedException();
		}

		public void CacheD0(double U, double V, int UDegree, int VDegree, double UCacheParameter, double VCacheParameter, double USpanLenght, double VSpanLength, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, gp_Pnt Point)
		{
			throw new NotImplementedException();
		}

		public void CoefsD0(double U, double V, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, gp_Pnt Point)
		{
			throw new NotImplementedException();
		}

		public void CacheD1(double U, double V, int UDegree, int VDegree, double UCacheParameter, double VCacheParameter, double USpanLenght, double VSpanLength, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, gp_Pnt Point, gp_Vec VecU, gp_Vec VecV)
		{
			throw new NotImplementedException();
		}

		public void CoefsD1(double U, double V, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, gp_Pnt Point, gp_Vec VecU, gp_Vec VecV)
		{
			throw new NotImplementedException();
		}

		public void CacheD2(double U, double V, int UDegree, int VDegree, double UCacheParameter, double VCacheParameter, double USpanLenght, double VSpanLength, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, gp_Pnt Point, gp_Vec VecU, gp_Vec VecV, gp_Vec VecUU, gp_Vec VecUV, gp_Vec VecVV)
		{
			throw new NotImplementedException();
		}

		public void CoefsD2(double U, double V, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, gp_Pnt Point, gp_Vec VecU, gp_Vec VecV, gp_Vec VecUU, gp_Vec VecUV, gp_Vec VecVV)
		{
			throw new NotImplementedException();
		}

		public void PolesCoefficients(TColgp_Array2OfPnt Poles, TColgp_Array2OfPnt CachePoles)
		{
			throw new NotImplementedException();
		}

		public void PolesCoefficients(TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColgp_Array2OfPnt CachePoles, TColStd_Array2OfReal CacheWeights)
		{
			throw new NotImplementedException();
		}

		public void Resolution(TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal UKnots, TColStd_Array1OfReal VKnots, TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int UDegree, int VDegree, bool URat, bool VRat, bool UPer, bool VPer, double Tolerance3D, ref double UTolerance, ref double VTolerance)
		{
			throw new NotImplementedException();
		}

		public void Interpolate(int UDegree, int VDegree, TColStd_Array1OfReal UFlatKnots, TColStd_Array1OfReal VFlatKnots, TColStd_Array1OfReal UParameters, TColStd_Array1OfReal VParameters, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, ref int InversionProblem)
		{
			throw new NotImplementedException();
		}

		public void Interpolate(int UDegree, int VDegree, TColStd_Array1OfReal UFlatKnots, TColStd_Array1OfReal VFlatKnots, TColStd_Array1OfReal UParameters, TColStd_Array1OfReal VParameters, TColgp_Array2OfPnt Poles, ref int InversionProblem)
		{
			throw new NotImplementedException();
		}

		public void FunctionMultiply(BSplSLib_EvaluatorFunction Function, int UBSplineDegree, int VBSplineDegree, TColStd_Array1OfReal UBSplineKnots, TColStd_Array1OfReal VBSplineKnots, TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal UFlatKnots, TColStd_Array1OfReal VFlatKnots, int UNewDegree, int VNewDegree, TColgp_Array2OfPnt NewNumerator, TColStd_Array2OfReal NewDenominator, ref int theStatus)
		{
			throw new NotImplementedException();
		}


	}; // class BSplSLib

}
