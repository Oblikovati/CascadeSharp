//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Law_BSpline
	//---------------------------------------------------------------------
	public  sealed class Law_BSpline : Standard_Transient
	{

		public Law_BSpline(TColStd_Array1OfReal Poles, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Multiplicities, int Degree, bool Periodic)
			: base()
		{
			throw new NotImplementedException();
		}

		public Law_BSpline(TColStd_Array1OfReal Poles, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Multiplicities, int Degree)
			: base()
		{
			throw new NotImplementedException();
		}

		public Law_BSpline(TColStd_Array1OfReal Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Multiplicities, int Degree, bool Periodic)
			: base()
		{
			throw new NotImplementedException();
		}

		public Law_BSpline(TColStd_Array1OfReal Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Multiplicities, int Degree)
			: base()
		{
			throw new NotImplementedException();
		}

		public Law_BSpline(Law_BSpline parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Law_BSpline()
		{
			throw new NotImplementedException();
		}

		public void IncreaseDegree(int Degree)
		{
			throw new NotImplementedException();
		}

		public void IncreaseMultiplicity(int Index, int M)
		{
			throw new NotImplementedException();
		}

		public void IncreaseMultiplicity(int I1, int I2, int M)
		{
			throw new NotImplementedException();
		}

		public void IncrementMultiplicity(int I1, int I2, int M)
		{
			throw new NotImplementedException();
		}

		public void InsertKnot(double U, int M, double ParametricTolerance, bool Add)
		{
			throw new NotImplementedException();
		}

		public void InsertKnot(double U, int M, double ParametricTolerance)
		{
			throw new NotImplementedException();
		}

		public void InsertKnot(double U, int M)
		{
			throw new NotImplementedException();
		}

		public void InsertKnot(double U)
		{
			throw new NotImplementedException();
		}

		public void InsertKnots(TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, double ParametricTolerance, bool Add)
		{
			throw new NotImplementedException();
		}

		public void InsertKnots(TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, double ParametricTolerance)
		{
			throw new NotImplementedException();
		}

		public void InsertKnots(TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults)
		{
			throw new NotImplementedException();
		}

		public bool RemoveKnot(int Index, int M, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public void Reverse()
		{
			throw new NotImplementedException();
		}

		public double ReversedParameter(double U)
		{
			throw new NotImplementedException();
		}

		public void Segment(double U1, double U2)
		{
			throw new NotImplementedException();
		}

		public void SetKnot(int Index, double K)
		{
			throw new NotImplementedException();
		}

		public void SetKnots(TColStd_Array1OfReal K)
		{
			throw new NotImplementedException();
		}

		public void SetKnot(int Index, double K, int M)
		{
			throw new NotImplementedException();
		}

		public void PeriodicNormalization(ref double U)
		{
			throw new NotImplementedException();
		}

		public void SetPeriodic()
		{
			throw new NotImplementedException();
		}

		public void SetOrigin(int Index)
		{
			throw new NotImplementedException();
		}

		public void SetNotPeriodic()
		{
			throw new NotImplementedException();
		}

		public void SetPole(int Index, double P)
		{
			throw new NotImplementedException();
		}

		public void SetPole(int Index, double P, double Weight)
		{
			throw new NotImplementedException();
		}

		public void SetWeight(int Index, double Weight)
		{
			throw new NotImplementedException();
		}

		public bool IsCN(int N)
		{
			throw new NotImplementedException();
		}

		public bool IsClosed()
		{
			throw new NotImplementedException();
		}

		public bool IsPeriodic()
		{
			throw new NotImplementedException();
		}

		public bool IsRational()
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_Shape Continuity()
		{
			throw new NotImplementedException();
		}

		public int Degree()
		{
			throw new NotImplementedException();
		}

		public double Value(double U)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, ref double P)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, ref double P, ref double V1)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, ref double P, ref double V1, ref double V2)
		{
			throw new NotImplementedException();
		}

		public void D3(double U, ref double P, ref double V1, ref double V2, ref double V3)
		{
			throw new NotImplementedException();
		}

		public double DN(double U, int N)
		{
			throw new NotImplementedException();
		}

		public double LocalValue(double U, int FromK1, int ToK2)
		{
			throw new NotImplementedException();
		}

		public void LocalD0(double U, int FromK1, int ToK2, ref double P)
		{
			throw new NotImplementedException();
		}

		public void LocalD1(double U, int FromK1, int ToK2, ref double P, ref double V1)
		{
			throw new NotImplementedException();
		}

		public void LocalD2(double U, int FromK1, int ToK2, ref double P, ref double V1, ref double V2)
		{
			throw new NotImplementedException();
		}

		public void LocalD3(double U, int FromK1, int ToK2, ref double P, ref double V1, ref double V2, ref double V3)
		{
			throw new NotImplementedException();
		}

		public double LocalDN(double U, int FromK1, int ToK2, int N)
		{
			throw new NotImplementedException();
		}

		public double EndPoint()
		{
			throw new NotImplementedException();
		}

		public int FirstUKnotIndex()
		{
			throw new NotImplementedException();
		}

		public double FirstParameter()
		{
			throw new NotImplementedException();
		}

		public double Knot(int Index)
		{
			throw new NotImplementedException();
		}

		public void Knots(TColStd_Array1OfReal K)
		{
			throw new NotImplementedException();
		}

		public void KnotSequence(TColStd_Array1OfReal K)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.GeomAbs_BSplKnotDistribution KnotDistribution()
		{
			throw new NotImplementedException();
		}

		public int LastUKnotIndex()
		{
			throw new NotImplementedException();
		}

		public double LastParameter()
		{
			throw new NotImplementedException();
		}

		public void LocateU(double U, double ParametricTolerance, ref int I1, ref int I2, bool WithKnotRepetition)
		{
			throw new NotImplementedException();
		}

		public void LocateU(double U, double ParametricTolerance, ref int I1, ref int I2)
		{
			throw new NotImplementedException();
		}

		public int Multiplicity(int Index)
		{
			throw new NotImplementedException();
		}

		public void Multiplicities(TColStd_Array1OfInteger M)
		{
			throw new NotImplementedException();
		}

		public int NbKnots()
		{
			throw new NotImplementedException();
		}

		public int NbPoles()
		{
			throw new NotImplementedException();
		}

		public double Pole(int Index)
		{
			throw new NotImplementedException();
		}

		public void Poles(TColStd_Array1OfReal P)
		{
			throw new NotImplementedException();
		}

		public double StartPoint()
		{
			throw new NotImplementedException();
		}

		public double Weight(int Index)
		{
			throw new NotImplementedException();
		}

		public void Weights(TColStd_Array1OfReal W)
		{
			throw new NotImplementedException();
		}

		public int MaxDegree()
		{
			throw new NotImplementedException();
		}

		public void MovePointAndTangent(double U, double NewValue, double Derivative, double Tolerance, int StartingCondition, int EndingCondition, ref int ErrorStatus)
		{
			throw new NotImplementedException();
		}

		public void Resolution(double Tolerance3D, ref double UTolerance)
		{
			throw new NotImplementedException();
		}

		public Law_BSpline Copy()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool IsCacheValid(double Parameter)
		{
			throw new NotImplementedException();
		}

		public void UpdateKnots()
		{
			throw new NotImplementedException();
		}


	}; // class Law_BSpline

}
