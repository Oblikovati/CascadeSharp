//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BSplCLib
	//---------------------------------------------------------------------
	public  sealed class BSplCLib
	{

		public BSplCLib()
			: base()
		{
			throw new NotImplementedException();
		}

		public BSplCLib(BSplCLib parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Hunt(TColStd_Array1OfReal theArray, double theX, ref int theXPos)
		{
			throw new NotImplementedException();
		}

		public int FirstUKnotIndex(int Degree, TColStd_Array1OfInteger Mults)
		{
			throw new NotImplementedException();
		}

		public int LastUKnotIndex(int Degree, TColStd_Array1OfInteger Mults)
		{
			throw new NotImplementedException();
		}

		public int FlatIndex(int Degree, int Index, TColStd_Array1OfInteger Mults, bool Periodic)
		{
			throw new NotImplementedException();
		}

		public void LocateParameter(int Degree, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, double U, bool IsPeriodic, int FromK1, int ToK2, ref int KnotIndex, ref double NewU)
		{
			throw new NotImplementedException();
		}

		public void LocateParameter(int Degree, TColStd_Array1OfReal Knots, double U, bool IsPeriodic, int FromK1, int ToK2, ref int KnotIndex, ref double NewU)
		{
			throw new NotImplementedException();
		}

		public void LocateParameter(int Degree, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, double U, bool Periodic, ref int Index, ref double NewU)
		{
			throw new NotImplementedException();
		}

		public int MaxKnotMult(TColStd_Array1OfInteger Mults, int K1, int K2)
		{
			throw new NotImplementedException();
		}

		public int MinKnotMult(TColStd_Array1OfInteger Mults, int K1, int K2)
		{
			throw new NotImplementedException();
		}

		public int NbPoles(int Degree, bool Periodic, TColStd_Array1OfInteger Mults)
		{
			throw new NotImplementedException();
		}

		public int KnotSequenceLength(TColStd_Array1OfInteger Mults, int Degree, bool Periodic)
		{
			throw new NotImplementedException();
		}

		public void KnotSequence(TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal KnotSeq, bool Periodic)
		{
			throw new NotImplementedException();
		}

		public void KnotSequence(TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal KnotSeq)
		{
			throw new NotImplementedException();
		}

		public void KnotSequence(TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, int Degree, bool Periodic, TColStd_Array1OfReal KnotSeq)
		{
			throw new NotImplementedException();
		}

		public int KnotsLength(TColStd_Array1OfReal KnotSeq, bool Periodic)
		{
			throw new NotImplementedException();
		}

		public int KnotsLength(TColStd_Array1OfReal KnotSeq)
		{
			throw new NotImplementedException();
		}

		public void Knots(TColStd_Array1OfReal KnotSeq, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, bool Periodic)
		{
			throw new NotImplementedException();
		}

		public void Knots(TColStd_Array1OfReal KnotSeq, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.BSplCLib_KnotDistribution KnotForm(TColStd_Array1OfReal Knots, int FromK1, int ToK2)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.BSplCLib_MultDistribution MultForm(TColStd_Array1OfInteger Mults, int FromK1, int ToK2)
		{
			throw new NotImplementedException();
		}

		public void KnotAnalysis(int Degree, bool Periodic, TColStd_Array1OfReal CKnots, TColStd_Array1OfInteger CMults,  ref CascadeSharp.GeomAbs_BSplKnotDistribution KnotForm, ref int MaxKnotMult)
		{
			throw new NotImplementedException();
		}

		public void Reparametrize(double U1, double U2, TColStd_Array1OfReal Knots)
		{
			throw new NotImplementedException();
		}

		public void Reverse(TColStd_Array1OfReal Knots)
		{
			throw new NotImplementedException();
		}

		public void Reverse(TColStd_Array1OfInteger Mults)
		{
			throw new NotImplementedException();
		}

		public void Reverse(TColgp_Array1OfPnt Poles, int Last)
		{
			throw new NotImplementedException();
		}

		public void Reverse(TColgp_Array1OfPnt2d Poles, int Last)
		{
			throw new NotImplementedException();
		}

		public void Reverse(TColStd_Array1OfReal Weights, int Last)
		{
			throw new NotImplementedException();
		}

		public bool IsRational(TColStd_Array1OfReal Weights, int I1, int I2, double Epsilon)
		{
			throw new NotImplementedException();
		}

		public bool IsRational(TColStd_Array1OfReal Weights, int I1, int I2)
		{
			throw new NotImplementedException();
		}

		public int MaxDegree()
		{
			throw new NotImplementedException();
		}

		public void Eval(double U, int Degree, ref double Knots, int Dimension, ref double Poles)
		{
			throw new NotImplementedException();
		}

		public void BoorScheme(double U, int Degree, ref double Knots, int Dimension, ref double Poles, int Depth, int Length)
		{
			throw new NotImplementedException();
		}

		public bool AntiBoorScheme(double U, int Degree, ref double Knots, int Dimension, ref double Poles, int Depth, int Length, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public void Derivative(int Degree, ref double Knots, int Dimension, int Length, int Order, ref double Poles)
		{
			throw new NotImplementedException();
		}

		public void Bohm(double U, int Degree, int N, ref double Knots, int Dimension, ref double Poles)
		{
			throw new NotImplementedException();
		}

		public TColStd_Array1OfReal NoWeights()
		{
			throw new NotImplementedException();
		}

		public TColStd_Array1OfInteger NoMults()
		{
			throw new NotImplementedException();
		}

		public void BuildKnots(int Degree, int Index, bool Periodic, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, ref double LK)
		{
			throw new NotImplementedException();
		}

		public int PoleIndex(int Degree, int Index, bool Periodic, TColStd_Array1OfInteger Mults)
		{
			throw new NotImplementedException();
		}

		public void BuildEval(int Degree, int Index, TColStd_Array1OfReal Poles, TColStd_Array1OfReal Weights, ref double LP)
		{
			throw new NotImplementedException();
		}

		public void BuildEval(int Degree, int Index, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, ref double LP)
		{
			throw new NotImplementedException();
		}

		public void BuildEval(int Degree, int Index, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, ref double LP)
		{
			throw new NotImplementedException();
		}

		public void BuildBoor(int Index, int Length, int Dimension, TColStd_Array1OfReal Poles, ref double LP)
		{
			throw new NotImplementedException();
		}

		public int BoorIndex(int Index, int Length, int Depth)
		{
			throw new NotImplementedException();
		}

		public void GetPole(int Index, int Length, int Depth, int Dimension, ref double LocPoles, ref int Position, TColStd_Array1OfReal Pole)
		{
			throw new NotImplementedException();
		}

		public bool PrepareInsertKnots(int Degree, bool Periodic, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal AddKnots, TColStd_Array1OfInteger AddMults, ref int NbPoles, ref int NbKnots, double Epsilon, bool Add)
		{
			throw new NotImplementedException();
		}

		public bool PrepareInsertKnots(int Degree, bool Periodic, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal AddKnots, TColStd_Array1OfInteger AddMults, ref int NbPoles, ref int NbKnots, double Epsilon)
		{
			throw new NotImplementedException();
		}

		public void InsertKnots(int Degree, bool Periodic, int Dimension, TColStd_Array1OfReal Poles, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal AddKnots, TColStd_Array1OfInteger AddMults, TColStd_Array1OfReal NewPoles, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, double Epsilon, bool Add)
		{
			throw new NotImplementedException();
		}

		public void InsertKnots(int Degree, bool Periodic, int Dimension, TColStd_Array1OfReal Poles, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal AddKnots, TColStd_Array1OfInteger AddMults, TColStd_Array1OfReal NewPoles, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, double Epsilon)
		{
			throw new NotImplementedException();
		}

		public void InsertKnots(int Degree, bool Periodic, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal AddKnots, TColStd_Array1OfInteger AddMults, TColgp_Array1OfPnt NewPoles, TColStd_Array1OfReal NewWeights, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, double Epsilon, bool Add)
		{
			throw new NotImplementedException();
		}

		public void InsertKnots(int Degree, bool Periodic, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal AddKnots, TColStd_Array1OfInteger AddMults, TColgp_Array1OfPnt NewPoles, TColStd_Array1OfReal NewWeights, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, double Epsilon)
		{
			throw new NotImplementedException();
		}

		public void InsertKnots(int Degree, bool Periodic, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal AddKnots, TColStd_Array1OfInteger AddMults, TColgp_Array1OfPnt2d NewPoles, TColStd_Array1OfReal NewWeights, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, double Epsilon, bool Add)
		{
			throw new NotImplementedException();
		}

		public void InsertKnots(int Degree, bool Periodic, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal AddKnots, TColStd_Array1OfInteger AddMults, TColgp_Array1OfPnt2d NewPoles, TColStd_Array1OfReal NewWeights, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, double Epsilon)
		{
			throw new NotImplementedException();
		}

		public void InsertKnot(int UIndex, double U, int UMult, int Degree, bool Periodic, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColgp_Array1OfPnt NewPoles, TColStd_Array1OfReal NewWeights)
		{
			throw new NotImplementedException();
		}

		public void InsertKnot(int UIndex, double U, int UMult, int Degree, bool Periodic, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColgp_Array1OfPnt2d NewPoles, TColStd_Array1OfReal NewWeights)
		{
			throw new NotImplementedException();
		}

		public void RaiseMultiplicity(int KnotIndex, int Mult, int Degree, bool Periodic, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColgp_Array1OfPnt NewPoles, TColStd_Array1OfReal NewWeights)
		{
			throw new NotImplementedException();
		}

		public void RaiseMultiplicity(int KnotIndex, int Mult, int Degree, bool Periodic, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColgp_Array1OfPnt2d NewPoles, TColStd_Array1OfReal NewWeights)
		{
			throw new NotImplementedException();
		}

		public bool RemoveKnot(int Index, int Mult, int Degree, bool Periodic, int Dimension, TColStd_Array1OfReal Poles, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal NewPoles, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public bool RemoveKnot(int Index, int Mult, int Degree, bool Periodic, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColgp_Array1OfPnt NewPoles, TColStd_Array1OfReal NewWeights, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public bool RemoveKnot(int Index, int Mult, int Degree, bool Periodic, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColgp_Array1OfPnt2d NewPoles, TColStd_Array1OfReal NewWeights, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, double Tolerance)
		{
			throw new NotImplementedException();
		}

		public int IncreaseDegreeCountKnots(int Degree, int NewDegree, bool Periodic, TColStd_Array1OfInteger Mults)
		{
			throw new NotImplementedException();
		}

		public void IncreaseDegree(int Degree, int NewDegree, bool Periodic, int Dimension, TColStd_Array1OfReal Poles, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal NewPoles, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults)
		{
			throw new NotImplementedException();
		}

		public void IncreaseDegree(int Degree, int NewDegree, bool Periodic, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColgp_Array1OfPnt NewPoles, TColStd_Array1OfReal NewWeights, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults)
		{
			throw new NotImplementedException();
		}

		public void IncreaseDegree(int Degree, int NewDegree, bool Periodic, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColgp_Array1OfPnt2d NewPoles, TColStd_Array1OfReal NewWeights, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults)
		{
			throw new NotImplementedException();
		}

		public void IncreaseDegree(int NewDegree, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColgp_Array1OfPnt NewPoles, TColStd_Array1OfReal NewWeights)
		{
			throw new NotImplementedException();
		}

		public void IncreaseDegree(int NewDegree, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColgp_Array1OfPnt2d NewPoles, TColStd_Array1OfReal NewWeights)
		{
			throw new NotImplementedException();
		}

		public void PrepareUnperiodize(int Degree, TColStd_Array1OfInteger Mults, ref int NbKnots, ref int NbPoles)
		{
			throw new NotImplementedException();
		}

		public void Unperiodize(int Degree, int Dimension, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal Knots, TColStd_Array1OfReal Poles, TColStd_Array1OfInteger NewMults, TColStd_Array1OfReal NewKnots, TColStd_Array1OfReal NewPoles)
		{
			throw new NotImplementedException();
		}

		public void Unperiodize(int Degree, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal Knots, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfInteger NewMults, TColStd_Array1OfReal NewKnots, TColgp_Array1OfPnt NewPoles, TColStd_Array1OfReal NewWeights)
		{
			throw new NotImplementedException();
		}

		public void Unperiodize(int Degree, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal Knots, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfInteger NewMults, TColStd_Array1OfReal NewKnots, TColgp_Array1OfPnt2d NewPoles, TColStd_Array1OfReal NewWeights)
		{
			throw new NotImplementedException();
		}

		public void PrepareTrimming(int Degree, bool Periodic, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, double U1, double U2, ref int NbKnots, ref int NbPoles)
		{
			throw new NotImplementedException();
		}

		public void Trimming(int Degree, bool Periodic, int Dimension, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColStd_Array1OfReal Poles, double U1, double U2, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, TColStd_Array1OfReal NewPoles)
		{
			throw new NotImplementedException();
		}

		public void Trimming(int Degree, bool Periodic, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, double U1, double U2, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, TColgp_Array1OfPnt NewPoles, TColStd_Array1OfReal NewWeights)
		{
			throw new NotImplementedException();
		}

		public void Trimming(int Degree, bool Periodic, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, double U1, double U2, TColStd_Array1OfReal NewKnots, TColStd_Array1OfInteger NewMults, TColgp_Array1OfPnt2d NewPoles, TColStd_Array1OfReal NewWeights)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, int Index, int Degree, bool Periodic, TColStd_Array1OfReal Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, ref double P)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, int Index, int Degree, bool Periodic, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, int UIndex, int Degree, bool Periodic, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, gp_Pnt2d P)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void D0(double U, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d P)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, int Index, int Degree, bool Periodic, TColStd_Array1OfReal Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, ref double P, ref double V)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, int Index, int Degree, bool Periodic, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, gp_Pnt P, gp_Vec V)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, int UIndex, int Degree, bool Periodic, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, gp_Pnt2d P, gp_Vec2d V)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt P, gp_Vec V)
		{
			throw new NotImplementedException();
		}

		public void D1(double U, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d P, gp_Vec2d V)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, int Index, int Degree, bool Periodic, TColStd_Array1OfReal Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, ref double P, ref double V1, ref double V2)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, int Index, int Degree, bool Periodic, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, gp_Pnt P, gp_Vec V1, gp_Vec V2)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, int UIndex, int Degree, bool Periodic, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt P, gp_Vec V1, gp_Vec V2)
		{
			throw new NotImplementedException();
		}

		public void D2(double U, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2)
		{
			throw new NotImplementedException();
		}

		public void D3(double U, int Index, int Degree, bool Periodic, TColStd_Array1OfReal Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, ref double P, ref double V1, ref double V2, ref double V3)
		{
			throw new NotImplementedException();
		}

		public void D3(double U, int Index, int Degree, bool Periodic, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, gp_Pnt P, gp_Vec V1, gp_Vec V2, gp_Vec V3)
		{
			throw new NotImplementedException();
		}

		public void D3(double U, int UIndex, int Degree, bool Periodic, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, gp_Vec2d V3)
		{
			throw new NotImplementedException();
		}

		public void D3(double U, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt P, gp_Vec V1, gp_Vec V2, gp_Vec V3)
		{
			throw new NotImplementedException();
		}

		public void D3(double U, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, gp_Vec2d V3)
		{
			throw new NotImplementedException();
		}

		public void DN(double U, int N, int Index, int Degree, bool Periodic, TColStd_Array1OfReal Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, ref double VN)
		{
			throw new NotImplementedException();
		}

		public void DN(double U, int N, int Index, int Degree, bool Periodic, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, gp_Vec VN)
		{
			throw new NotImplementedException();
		}

		public void DN(double U, int N, int UIndex, int Degree, bool Periodic, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, gp_Vec2d V)
		{
			throw new NotImplementedException();
		}

		public void DN(double U, int N, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt P, gp_Vec VN)
		{
			throw new NotImplementedException();
		}

		public void DN(double U, int N, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d P, gp_Vec2d VN)
		{
			throw new NotImplementedException();
		}

		public int EvalBsplineBasis(int DerivativeOrder, int Order, TColStd_Array1OfReal FlatKnots, double Parameter, ref int FirstNonZeroBsplineIndex, math_Matrix BsplineBas_is, bool _isPeriodic)
		{
			throw new NotImplementedException();
		}

		public int EvalBsplineBasis(int DerivativeOrder, int Order, TColStd_Array1OfReal FlatKnots, double Parameter, ref int FirstNonZeroBsplineIndex, math_Matrix BsplineBas_is)
		{
			throw new NotImplementedException();
		}

		public int BuildBSpMatrix(TColStd_Array1OfReal Parameters, TColStd_Array1OfInteger OrderArray, TColStd_Array1OfReal FlatKnots, int Degree, math_Matrix Matrix, ref int UpperBandWidth, ref int LowerBandWidth)
		{
			throw new NotImplementedException();
		}

		public int FactorBandedMatrix(math_Matrix Matrix, int UpperBandWidth, int LowerBandWidth, ref int PivotIndexProblem)
		{
			throw new NotImplementedException();
		}

		public int SolveBandedSystem(math_Matrix Matrix, int UpperBandWidth, int LowerBandWidth, int ArrayDimension, ref double Array)
		{
			throw new NotImplementedException();
		}

		public int SolveBandedSystem(math_Matrix Matrix, int UpperBandWidth, int LowerBandWidth, TColgp_Array1OfPnt2d Array)
		{
			throw new NotImplementedException();
		}

		public int SolveBandedSystem(math_Matrix Matrix, int UpperBandWidth, int LowerBandWidth, TColgp_Array1OfPnt Array)
		{
			throw new NotImplementedException();
		}

		public int SolveBandedSystem(math_Matrix Matrix, int UpperBandWidth, int LowerBandWidth, bool HomogenousFlag, int ArrayDimension, ref double Array, ref double Weights)
		{
			throw new NotImplementedException();
		}

		public int SolveBandedSystem(math_Matrix Matrix, int UpperBandWidth, int LowerBandWidth, bool HomogenousFlag, TColgp_Array1OfPnt2d Array, TColStd_Array1OfReal Weights)
		{
			throw new NotImplementedException();
		}

		public int SolveBandedSystem(math_Matrix Matrix, int UpperBandWidth, int LowerBandWidth, bool HomogeneousFlag, TColgp_Array1OfPnt Array, TColStd_Array1OfReal Weights)
		{
			throw new NotImplementedException();
		}

		public void MergeBSplineKnots(double Tolerance, double StartValue, double EndValue, int Degree1, TColStd_Array1OfReal Knots1, TColStd_Array1OfInteger Mults1, int Degree2, TColStd_Array1OfReal Knots2, TColStd_Array1OfInteger Mults2, ref int NumPoles, TColStd_HArray1OfReal NewKnots, TColStd_HArray1OfInteger NewMults)
		{
			throw new NotImplementedException();
		}

		public void FunctionReparameterise(BSplCLib_EvaluatorFunction Function, int BSplineDegree, TColStd_Array1OfReal BSplineFlatKnots, int PolesDimension, ref double Poles, TColStd_Array1OfReal FlatKnots, int NewDegree, ref double NewPoles, ref int theStatus)
		{
			throw new NotImplementedException();
		}

		public void FunctionReparameterise(BSplCLib_EvaluatorFunction Function, int BSplineDegree, TColStd_Array1OfReal BSplineFlatKnots, TColStd_Array1OfReal Poles, TColStd_Array1OfReal FlatKnots, int NewDegree, TColStd_Array1OfReal NewPoles, ref int theStatus)
		{
			throw new NotImplementedException();
		}

		public void FunctionReparameterise(BSplCLib_EvaluatorFunction Function, int BSplineDegree, TColStd_Array1OfReal BSplineFlatKnots, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal FlatKnots, int NewDegree, TColgp_Array1OfPnt NewPoles, ref int theStatus)
		{
			throw new NotImplementedException();
		}

		public void FunctionReparameterise(BSplCLib_EvaluatorFunction Function, int BSplineDegree, TColStd_Array1OfReal BSplineFlatKnots, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal FlatKnots, int NewDegree, TColgp_Array1OfPnt2d NewPoles, ref int theStatus)
		{
			throw new NotImplementedException();
		}

		public void FunctionMultiply(BSplCLib_EvaluatorFunction Function, int BSplineDegree, TColStd_Array1OfReal BSplineFlatKnots, int PolesDimension, ref double Poles, TColStd_Array1OfReal FlatKnots, int NewDegree, ref double NewPoles, ref int theStatus)
		{
			throw new NotImplementedException();
		}

		public void FunctionMultiply(BSplCLib_EvaluatorFunction Function, int BSplineDegree, TColStd_Array1OfReal BSplineFlatKnots, TColStd_Array1OfReal Poles, TColStd_Array1OfReal FlatKnots, int NewDegree, TColStd_Array1OfReal NewPoles, ref int theStatus)
		{
			throw new NotImplementedException();
		}

		public void FunctionMultiply(BSplCLib_EvaluatorFunction Function, int BSplineDegree, TColStd_Array1OfReal BSplineFlatKnots, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal FlatKnots, int NewDegree, TColgp_Array1OfPnt2d NewPoles, ref int theStatus)
		{
			throw new NotImplementedException();
		}

		public void FunctionMultiply(BSplCLib_EvaluatorFunction Function, int BSplineDegree, TColStd_Array1OfReal BSplineFlatKnots, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal FlatKnots, int NewDegree, TColgp_Array1OfPnt NewPoles, ref int theStatus)
		{
			throw new NotImplementedException();
		}

		public void Eval(double U, bool PeriodicFlag, int DerivativeRequest, ref int ExtrapMode, int Degree, TColStd_Array1OfReal FlatKnots, int ArrayDimension, ref double Poles, ref double Result)
		{
			throw new NotImplementedException();
		}

		public void Eval(double U, bool PeriodicFlag, int DerivativeRequest, ref int ExtrapMode, int Degree, TColStd_Array1OfReal FlatKnots, int ArrayDimension, ref double Poles, ref double Weights, ref double PolesResult, ref double WeightsResult)
		{
			throw new NotImplementedException();
		}

		public void Eval(double U, bool PeriodicFlag, bool HomogeneousFlag, ref int ExtrapMode, int Degree, TColStd_Array1OfReal FlatKnots, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt Point, ref double Weight)
		{
			throw new NotImplementedException();
		}

		public void Eval(double U, bool PeriodicFlag, bool HomogeneousFlag, ref int ExtrapMode, int Degree, TColStd_Array1OfReal FlatKnots, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d Point, ref double Weight)
		{
			throw new NotImplementedException();
		}

		public void TangExtendToConstraint(TColStd_Array1OfReal FlatKnots, double C1Coefficient, int NumPoles, ref double Poles, int Dimension, int Degree, TColStd_Array1OfReal ConstraintPoint, int Continuity, bool After, ref int NbPolesResult, ref int NbKnotsRsult, ref double KnotsResult, ref double PolesResult)
		{
			throw new NotImplementedException();
		}

		public void CacheD0(double U, int Degree, double CacheParameter, double SpanLenght, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt Point)
		{
			throw new NotImplementedException();
		}

		public void CacheD0(double U, int Degree, double CacheParameter, double SpanLenght, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d Point)
		{
			throw new NotImplementedException();
		}

		public void CoefsD0(double U, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt Point)
		{
			throw new NotImplementedException();
		}

		public void CoefsD0(double U, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d Point)
		{
			throw new NotImplementedException();
		}

		public void CacheD1(double U, int Degree, double CacheParameter, double SpanLenght, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt Point, gp_Vec Vec)
		{
			throw new NotImplementedException();
		}

		public void CacheD1(double U, int Degree, double CacheParameter, double SpanLenght, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d Point, gp_Vec2d Vec)
		{
			throw new NotImplementedException();
		}

		public void CoefsD1(double U, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt Point, gp_Vec Vec)
		{
			throw new NotImplementedException();
		}

		public void CoefsD1(double U, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d Point, gp_Vec2d Vec)
		{
			throw new NotImplementedException();
		}

		public void CacheD2(double U, int Degree, double CacheParameter, double SpanLenght, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt Point, gp_Vec Vec1, gp_Vec Vec2)
		{
			throw new NotImplementedException();
		}

		public void CacheD2(double U, int Degree, double CacheParameter, double SpanLenght, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d Point, gp_Vec2d Vec1, gp_Vec2d Vec2)
		{
			throw new NotImplementedException();
		}

		public void CoefsD2(double U, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt Point, gp_Vec Vec1, gp_Vec Vec2)
		{
			throw new NotImplementedException();
		}

		public void CoefsD2(double U, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d Point, gp_Vec2d Vec1, gp_Vec2d Vec2)
		{
			throw new NotImplementedException();
		}

		public void CacheD3(double U, int Degree, double CacheParameter, double SpanLenght, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt Point, gp_Vec Vec1, gp_Vec Vec2, gp_Vec Vec3)
		{
			throw new NotImplementedException();
		}

		public void CacheD3(double U, int Degree, double CacheParameter, double SpanLenght, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d Point, gp_Vec2d Vec1, gp_Vec2d Vec2, gp_Vec2d Vec3)
		{
			throw new NotImplementedException();
		}

		public void CoefsD3(double U, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, gp_Pnt Point, gp_Vec Vec1, gp_Vec Vec2, gp_Vec Vec3)
		{
			throw new NotImplementedException();
		}

		public void CoefsD3(double U, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, gp_Pnt2d Point, gp_Vec2d Vec1, gp_Vec2d Vec2, gp_Vec2d Vec3)
		{
			throw new NotImplementedException();
		}

		public void BuildCache(double U, double InverseOfSpanDomain, bool PeriodicFlag, int Degree, TColStd_Array1OfReal FlatKnots, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColgp_Array1OfPnt CachePoles, TColStd_Array1OfReal CacheWeights)
		{
			throw new NotImplementedException();
		}

		public void BuildCache(double U, double InverseOfSpanDomain, bool PeriodicFlag, int Degree, TColStd_Array1OfReal FlatKnots, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColgp_Array1OfPnt2d CachePoles, TColStd_Array1OfReal CacheWeights)
		{
			throw new NotImplementedException();
		}

		public void BuildCache(double theParameter, double theSpanDomain, bool thePeriodicFlag, int theDegree, int theSpanIndex, TColStd_Array1OfReal theFlatKnots, TColgp_Array1OfPnt thePoles, TColStd_Array1OfReal theWeights, TColStd_Array2OfReal theCacheArray)
		{
			throw new NotImplementedException();
		}

		public void BuildCache(double theParameter, double theSpanDomain, bool thePeriodicFlag, int theDegree, int theSpanIndex, TColStd_Array1OfReal theFlatKnots, TColgp_Array1OfPnt2d thePoles, TColStd_Array1OfReal theWeights, TColStd_Array2OfReal theCacheArray)
		{
			throw new NotImplementedException();
		}

		public void PolesCoefficients(TColgp_Array1OfPnt2d Poles, TColgp_Array1OfPnt2d CachePoles)
		{
			throw new NotImplementedException();
		}

		public void PolesCoefficients(TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColgp_Array1OfPnt2d CachePoles, TColStd_Array1OfReal CacheWeights)
		{
			throw new NotImplementedException();
		}

		public void PolesCoefficients(TColgp_Array1OfPnt Poles, TColgp_Array1OfPnt CachePoles)
		{
			throw new NotImplementedException();
		}

		public void PolesCoefficients(TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColgp_Array1OfPnt CachePoles, TColStd_Array1OfReal CacheWeights)
		{
			throw new NotImplementedException();
		}

		public double FlatBezierKnots(int Degree)
		{
			throw new NotImplementedException();
		}

		public void BuildSchoenbergPoints(int Degree, TColStd_Array1OfReal FlatKnots, TColStd_Array1OfReal Parameters)
		{
			throw new NotImplementedException();
		}

		public void Interpolate(int Degree, TColStd_Array1OfReal FlatKnots, TColStd_Array1OfReal Parameters, TColStd_Array1OfInteger ContactOrderArray, TColgp_Array1OfPnt Poles, ref int InversionProblem)
		{
			throw new NotImplementedException();
		}

		public void Interpolate(int Degree, TColStd_Array1OfReal FlatKnots, TColStd_Array1OfReal Parameters, TColStd_Array1OfInteger ContactOrderArray, TColgp_Array1OfPnt2d Poles, ref int InversionProblem)
		{
			throw new NotImplementedException();
		}

		public void Interpolate(int Degree, TColStd_Array1OfReal FlatKnots, TColStd_Array1OfReal Parameters, TColStd_Array1OfInteger ContactOrderArray, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, ref int InversionProblem)
		{
			throw new NotImplementedException();
		}

		public void Interpolate(int Degree, TColStd_Array1OfReal FlatKnots, TColStd_Array1OfReal Parameters, TColStd_Array1OfInteger ContactOrderArray, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, ref int InversionProblem)
		{
			throw new NotImplementedException();
		}

		public void Interpolate(int Degree, TColStd_Array1OfReal FlatKnots, TColStd_Array1OfReal Parameters, TColStd_Array1OfInteger ContactOrderArray, int ArrayDimension, ref double Poles, ref int InversionProblem)
		{
			throw new NotImplementedException();
		}

		public void Interpolate(int Degree, TColStd_Array1OfReal FlatKnots, TColStd_Array1OfReal Parameters, TColStd_Array1OfInteger ContactOrderArray, int ArrayDimension, ref double Poles, ref double Weights, ref int InversionProblem)
		{
			throw new NotImplementedException();
		}

		public void MovePoint(double U, gp_Vec2d D_ispl, int Index1, int Index2, int Degree, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal FlatKnots, ref int FirstIndex, ref int LastIndex, TColgp_Array1OfPnt2d NewPoles)
		{
			throw new NotImplementedException();
		}

		public void MovePoint(double U, gp_Vec D_ispl, int Index1, int Index2, int Degree, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal FlatKnots, ref int FirstIndex, ref int LastIndex, TColgp_Array1OfPnt NewPoles)
		{
			throw new NotImplementedException();
		}

		public void MovePointAndTangent(double U, int ArrayDimension, ref double Delta, ref double DeltaDerivative, double Tolerance, int Degree, int StartingCondition, int EndingCondition, ref double Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal FlatKnots, ref double NewPoles, ref int ErrorStatus)
		{
			throw new NotImplementedException();
		}

		public void MovePointAndTangent(double U, gp_Vec Delta, gp_Vec DeltaDerivative, double Tolerance, int Degree, int StartingCondition, int EndingCondition, TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal FlatKnots, TColgp_Array1OfPnt NewPoles, ref int ErrorStatus)
		{
			throw new NotImplementedException();
		}

		public void MovePointAndTangent(double U, gp_Vec2d Delta, gp_Vec2d DeltaDerivative, double Tolerance, int Degree, int StartingCondition, int EndingCondition, TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal FlatKnots, TColgp_Array1OfPnt2d NewPoles, ref int ErrorStatus)
		{
			throw new NotImplementedException();
		}

		public void Resolution(ref double PolesArray, int ArrayDimension, int NumPoles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal FlatKnots, int Degree, double Tolerance3D, ref double UTolerance)
		{
			throw new NotImplementedException();
		}

		public void Resolution(TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, int NumPoles, TColStd_Array1OfReal FlatKnots, int Degree, double Tolerance3D, ref double UTolerance)
		{
			throw new NotImplementedException();
		}

		public void Resolution(TColgp_Array1OfPnt2d Poles, TColStd_Array1OfReal Weights, int NumPoles, TColStd_Array1OfReal FlatKnots, int Degree, double Tolerance3D, ref double UTolerance)
		{
			throw new NotImplementedException();
		}

		public void LocateParameter(TColStd_Array1OfReal Knots, double U, bool Periodic, int K1, int K2, ref int Index, ref double NewU, double Uf, double Ue)
		{
			throw new NotImplementedException();
		}


	}; // class BSplCLib

}
