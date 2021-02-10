//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKG3d.Geom
{
    //---------------------------------------------------------------------
    //  Class  Geom_BSplineSurface
    //---------------------------------------------------------------------
    public sealed class Geom_BSplineSurface : Geom_BoundedSurface
    {
        public Geom_BSplineSurface(TColgp_Array2OfPnt Poles, TColStd_Array1OfReal UKnots, TColStd_Array1OfReal VKnots,
            TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int UDegree, int VDegree, bool UPeriodic,
            bool VPeriodic)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface(TColgp_Array2OfPnt Poles, TColStd_Array1OfReal UKnots, TColStd_Array1OfReal VKnots,
            TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int UDegree, int VDegree, bool UPeriodic)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface(TColgp_Array2OfPnt Poles, TColStd_Array1OfReal UKnots, TColStd_Array1OfReal VKnots,
            TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int UDegree, int VDegree)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface(TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal UKnots,
            TColStd_Array1OfReal VKnots, TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int UDegree,
            int VDegree, bool UPeriodic, bool VPeriodic)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface(TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal UKnots,
            TColStd_Array1OfReal VKnots, TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int UDegree,
            int VDegree, bool UPeriodic)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface(TColgp_Array2OfPnt Poles, TColStd_Array2OfReal Weights, TColStd_Array1OfReal UKnots,
            TColStd_Array1OfReal VKnots, TColStd_Array1OfInteger UMults, TColStd_Array1OfInteger VMults, int UDegree,
            int VDegree)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface(Geom_BSplineSurface parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineSurface()
        {
            throw new NotImplementedException();
        }

        public void ExchangeUV()
        {
            throw new NotImplementedException();
        }

        public void SetUPeriodic()
        {
            throw new NotImplementedException();
        }

        public void SetVPeriodic()
        {
            throw new NotImplementedException();
        }

        public void PeriodicNormalization(ref double U, ref double V)
        {
            throw new NotImplementedException();
        }

        public void SetUOrigin(int Index)
        {
            throw new NotImplementedException();
        }

        public void SetVOrigin(int Index)
        {
            throw new NotImplementedException();
        }

        public void SetUNotPeriodic()
        {
            throw new NotImplementedException();
        }

        public void SetVNotPeriodic()
        {
            throw new NotImplementedException();
        }

        public void UReverse()
        {
            throw new NotImplementedException();
        }

        public void VReverse()
        {
            throw new NotImplementedException();
        }

        public double UReversedParameter(double U)
        {
            throw new NotImplementedException();
        }

        public double VReversedParameter(double V)
        {
            throw new NotImplementedException();
        }

        public void IncreaseDegree(int UDegree, int VDegree)
        {
            throw new NotImplementedException();
        }

        public void InsertUKnots(TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, double ParametricTolerance,
            bool Add)
        {
            throw new NotImplementedException();
        }

        public void InsertUKnots(TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, double ParametricTolerance)
        {
            throw new NotImplementedException();
        }

        public void InsertUKnots(TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults)
        {
            throw new NotImplementedException();
        }

        public void InsertVKnots(TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, double ParametricTolerance,
            bool Add)
        {
            throw new NotImplementedException();
        }

        public void InsertVKnots(TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, double ParametricTolerance)
        {
            throw new NotImplementedException();
        }

        public void InsertVKnots(TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults)
        {
            throw new NotImplementedException();
        }

        public bool RemoveUKnot(int Index, int M, double Tolerance)
        {
            throw new NotImplementedException();
        }

        public bool RemoveVKnot(int Index, int M, double Tolerance)
        {
            throw new NotImplementedException();
        }

        public void IncreaseUMultiplicity(int UIndex, int M)
        {
            throw new NotImplementedException();
        }

        public void IncreaseUMultiplicity(int FromI1, int ToI2, int M)
        {
            throw new NotImplementedException();
        }

        public void IncrementUMultiplicity(int FromI1, int ToI2, int Step)
        {
            throw new NotImplementedException();
        }

        public void IncreaseVMultiplicity(int VIndex, int M)
        {
            throw new NotImplementedException();
        }

        public void IncreaseVMultiplicity(int FromI1, int ToI2, int M)
        {
            throw new NotImplementedException();
        }

        public void IncrementVMultiplicity(int FromI1, int ToI2, int Step)
        {
            throw new NotImplementedException();
        }

        public void InsertUKnot(double U, int M, double ParametricTolerance, bool Add)
        {
            throw new NotImplementedException();
        }

        public void InsertUKnot(double U, int M, double ParametricTolerance)
        {
            throw new NotImplementedException();
        }

        public void InsertVKnot(double V, int M, double ParametricTolerance, bool Add)
        {
            throw new NotImplementedException();
        }

        public void InsertVKnot(double V, int M, double ParametricTolerance)
        {
            throw new NotImplementedException();
        }

        public void Segment(double U1, double U2, double V1, double V2, double theUTolerance, double theVTolerance)
        {
            throw new NotImplementedException();
        }

        public void Segment(double U1, double U2, double V1, double V2, double theUTolerance)
        {
            throw new NotImplementedException();
        }

        public void Segment(double U1, double U2, double V1, double V2)
        {
            throw new NotImplementedException();
        }

        public void CheckAndSegment(double U1, double U2, double V1, double V2, double theUTolerance,
            double theVTolerance)
        {
            throw new NotImplementedException();
        }

        public void CheckAndSegment(double U1, double U2, double V1, double V2, double theUTolerance)
        {
            throw new NotImplementedException();
        }

        public void CheckAndSegment(double U1, double U2, double V1, double V2)
        {
            throw new NotImplementedException();
        }

        public void SetUKnot(int UIndex, double K)
        {
            throw new NotImplementedException();
        }

        public void SetUKnots(TColStd_Array1OfReal UK)
        {
            throw new NotImplementedException();
        }

        public void SetUKnot(int UIndex, double K, int M)
        {
            throw new NotImplementedException();
        }

        public void SetVKnot(int VIndex, double K)
        {
            throw new NotImplementedException();
        }

        public void SetVKnots(TColStd_Array1OfReal VK)
        {
            throw new NotImplementedException();
        }

        public void SetVKnot(int VIndex, double K, int M)
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

        public void LocateV(double V, double ParametricTolerance, ref int I1, ref int I2, bool WithKnotRepetition)
        {
            throw new NotImplementedException();
        }

        public void LocateV(double V, double ParametricTolerance, ref int I1, ref int I2)
        {
            throw new NotImplementedException();
        }

        public void SetPole(int UIndex, int VIndex, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void SetPole(int UIndex, int VIndex, gp_Pnt P, double Weight)
        {
            throw new NotImplementedException();
        }

        public void SetPoleCol(int VIndex, TColgp_Array1OfPnt CPoles)
        {
            throw new NotImplementedException();
        }

        public void SetPoleCol(int VIndex, TColgp_Array1OfPnt CPoles, TColStd_Array1OfReal CPoleWeights)
        {
            throw new NotImplementedException();
        }

        public void SetPoleRow(int UIndex, TColgp_Array1OfPnt CPoles, TColStd_Array1OfReal CPoleWeights)
        {
            throw new NotImplementedException();
        }

        public void SetPoleRow(int UIndex, TColgp_Array1OfPnt CPoles)
        {
            throw new NotImplementedException();
        }

        public void SetWeight(int UIndex, int VIndex, double Weight)
        {
            throw new NotImplementedException();
        }

        public void SetWeightCol(int VIndex, TColStd_Array1OfReal CPoleWeights)
        {
            throw new NotImplementedException();
        }

        public void SetWeightRow(int UIndex, TColStd_Array1OfReal CPoleWeights)
        {
            throw new NotImplementedException();
        }

        public void MovePoint(double U, double V, gp_Pnt P, int UIndex1, int UIndex2, int VIndex1, int VIndex2,
            ref int UFirstIndex, ref int ULastIndex, ref int VFirstIndex, ref int VLastIndex)
        {
            throw new NotImplementedException();
        }

        public bool IsUClosed()
        {
            throw new NotImplementedException();
        }

        public bool IsVClosed()
        {
            throw new NotImplementedException();
        }

        public bool IsCNu(int N)
        {
            throw new NotImplementedException();
        }

        public bool IsCNv(int N)
        {
            throw new NotImplementedException();
        }

        public bool IsUPeriodic()
        {
            throw new NotImplementedException();
        }

        public bool IsURational()
        {
            throw new NotImplementedException();
        }

        public bool IsVPeriodic()
        {
            throw new NotImplementedException();
        }

        public bool IsVRational()
        {
            throw new NotImplementedException();
        }

        public void Bounds(ref double U1, ref double U2, ref double V1, ref double V2)
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity()
        {
            throw new NotImplementedException();
        }

        public int FirstUKnotIndex()
        {
            throw new NotImplementedException();
        }

        public int FirstVKnotIndex()
        {
            throw new NotImplementedException();
        }

        public int LastUKnotIndex()
        {
            throw new NotImplementedException();
        }

        public int LastVKnotIndex()
        {
            throw new NotImplementedException();
        }

        public int NbUKnots()
        {
            throw new NotImplementedException();
        }

        public int NbUPoles()
        {
            throw new NotImplementedException();
        }

        public int NbVKnots()
        {
            throw new NotImplementedException();
        }

        public int NbVPoles()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Pole(int UIndex, int VIndex)
        {
            throw new NotImplementedException();
        }

        public void Poles(TColgp_Array2OfPnt P)
        {
            throw new NotImplementedException();
        }

        public TColgp_Array2OfPnt Poles()
        {
            throw new NotImplementedException();
        }

        public int UDegree()
        {
            throw new NotImplementedException();
        }

        public double UKnot(int UIndex)
        {
            throw new NotImplementedException();
        }

        public GeomAbs_BSplKnotDistribution UKnotDistribution()
        {
            throw new NotImplementedException();
        }

        public void UKnots(TColStd_Array1OfReal Ku)
        {
            throw new NotImplementedException();
        }

        public TColStd_Array1OfReal UKnots()
        {
            throw new NotImplementedException();
        }

        public void UKnotSequence(TColStd_Array1OfReal Ku)
        {
            throw new NotImplementedException();
        }

        public TColStd_Array1OfReal UKnotSequence()
        {
            throw new NotImplementedException();
        }

        public int UMultiplicity(int UIndex)
        {
            throw new NotImplementedException();
        }

        public void UMultiplicities(TColStd_Array1OfInteger Mu)
        {
            throw new NotImplementedException();
        }

        public TColStd_Array1OfInteger UMultiplicities()
        {
            throw new NotImplementedException();
        }

        public int VDegree()
        {
            throw new NotImplementedException();
        }

        public double VKnot(int VIndex)
        {
            throw new NotImplementedException();
        }

        public GeomAbs_BSplKnotDistribution VKnotDistribution()
        {
            throw new NotImplementedException();
        }

        public void VKnots(TColStd_Array1OfReal Kv)
        {
            throw new NotImplementedException();
        }

        public TColStd_Array1OfReal VKnots()
        {
            throw new NotImplementedException();
        }

        public void VKnotSequence(TColStd_Array1OfReal Kv)
        {
            throw new NotImplementedException();
        }

        public TColStd_Array1OfReal VKnotSequence()
        {
            throw new NotImplementedException();
        }

        public int VMultiplicity(int VIndex)
        {
            throw new NotImplementedException();
        }

        public void VMultiplicities(TColStd_Array1OfInteger Mv)
        {
            throw new NotImplementedException();
        }

        public TColStd_Array1OfInteger VMultiplicities()
        {
            throw new NotImplementedException();
        }

        public double Weight(int UIndex, int VIndex)
        {
            throw new NotImplementedException();
        }

        public void Weights(TColStd_Array2OfReal W)
        {
            throw new NotImplementedException();
        }

        public TColStd_Array2OfReal Weights()
        {
            throw new NotImplementedException();
        }

        public void D0(double U, double V, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, double V, gp_Pnt P, gp_Vec D1U, gp_Vec D1V)
        {
            throw new NotImplementedException();
        }

        public void D2(double U, double V, gp_Pnt P, gp_Vec D1U, gp_Vec D1V, gp_Vec D2U, gp_Vec D2V, gp_Vec D2UV)
        {
            throw new NotImplementedException();
        }

        public void D3(double U, double V, gp_Pnt P, gp_Vec D1U, gp_Vec D1V, gp_Vec D2U, gp_Vec D2V, gp_Vec D2UV,
            gp_Vec D3U, gp_Vec D3V, gp_Vec D3UUV, gp_Vec D3UVV)
        {
            throw new NotImplementedException();
        }

        public gp_Vec DN(double U, double V, int Nu, int Nv)
        {
            throw new NotImplementedException();
        }

        public void LocalD0(double U, double V, int FromUK1, int ToUK2, int FromVK1, int ToVK2, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void LocalD1(double U, double V, int FromUK1, int ToUK2, int FromVK1, int ToVK2, gp_Pnt P, gp_Vec D1U,
            gp_Vec D1V)
        {
            throw new NotImplementedException();
        }

        public void LocalD2(double U, double V, int FromUK1, int ToUK2, int FromVK1, int ToVK2, gp_Pnt P, gp_Vec D1U,
            gp_Vec D1V, gp_Vec D2U, gp_Vec D2V, gp_Vec D2UV)
        {
            throw new NotImplementedException();
        }

        public void LocalD3(double U, double V, int FromUK1, int ToUK2, int FromVK1, int ToVK2, gp_Pnt P, gp_Vec D1U,
            gp_Vec D1V, gp_Vec D2U, gp_Vec D2V, gp_Vec D2UV, gp_Vec D3U, gp_Vec D3V, gp_Vec D3UUV, gp_Vec D3UVV)
        {
            throw new NotImplementedException();
        }

        public gp_Vec LocalDN(double U, double V, int FromUK1, int ToUK2, int FromVK1, int ToVK2, int Nu, int Nv)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt LocalValue(double U, double V, int FromUK1, int ToUK2, int FromVK1, int ToVK2)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve UIso(double U)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve VIso(double V)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve UIso(double U, bool CheckRational)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve VIso(double V, bool CheckRational)
        {
            throw new NotImplementedException();
        }

        public void Transform(gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public int MaxDegree()
        {
            throw new NotImplementedException();
        }

        public void Resolution(double Tolerance3D, ref double UTolerance, ref double VTolerance)
        {
            throw new NotImplementedException();
        }

        public Geom_Geometry Copy()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void segment(double U1, double U2, double V1, double V2, double EpsU, double EpsV, bool SegmentInU,
            bool SegmentInV)
        {
            throw new NotImplementedException();
        }

        public void UpdateUKnots()
        {
            throw new NotImplementedException();
        }

        public void UpdateVKnots()
        {
            throw new NotImplementedException();
        }
    }; // class Geom_BSplineSurface
}