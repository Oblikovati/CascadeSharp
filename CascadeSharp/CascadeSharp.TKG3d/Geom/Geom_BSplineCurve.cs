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
    //  Class  Geom_BSplineCurve
    //---------------------------------------------------------------------
    public sealed class Geom_BSplineCurve : Geom_BoundedCurve
    {
        public Geom_BSplineCurve(TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Knots,
            TColStd_Array1OfInteger Multiplicities, int Degree, bool Periodic)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve(TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Knots,
            TColStd_Array1OfInteger Multiplicities, int Degree)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve(TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots,
            TColStd_Array1OfInteger Multiplicities, int Degree, bool Periodic, bool CheckRational)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve(TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots,
            TColStd_Array1OfInteger Multiplicities, int Degree, bool Periodic)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve(TColgp_Array1OfPnt Poles, TColStd_Array1OfReal Weights, TColStd_Array1OfReal Knots,
            TColStd_Array1OfInteger Multiplicities, int Degree)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve(Geom_BSplineCurve parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_BSplineCurve()
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

        public void InsertKnots(TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, double ParametricTolerance,
            bool Add)
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

        public void Segment(double U1, double U2, double theTolerance)
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

        public void SetOrigin(double U, double Tol)
        {
            throw new NotImplementedException();
        }

        public void SetNotPeriodic()
        {
            throw new NotImplementedException();
        }

        public void SetPole(int Index, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void SetPole(int Index, gp_Pnt P, double Weight)
        {
            throw new NotImplementedException();
        }

        public void SetWeight(int Index, double Weight)
        {
            throw new NotImplementedException();
        }

        public void MovePoint(double U, gp_Pnt P, int Index1, int Index2, ref int FirstModifiedPole,
            ref int LastModifiedPole)
        {
            throw new NotImplementedException();
        }

        public void MovePointAndTangent(double U, gp_Pnt P, gp_Vec Tangent, double Tolerance, int StartingCondition,
            int EndingCondition, ref int ErrorStatus)
        {
            throw new NotImplementedException();
        }

        public bool IsCN(int N)
        {
            throw new NotImplementedException();
        }

        public bool IsG1(double theTf, double theTl, double theAngTol)
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

        public GeomAbs_Shape Continuity()
        {
            throw new NotImplementedException();
        }

        public int Degree()
        {
            throw new NotImplementedException();
        }

        public void D0(double U, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, gp_Pnt P, gp_Vec V1)
        {
            throw new NotImplementedException();
        }

        public void D2(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2)
        {
            throw new NotImplementedException();
        }

        public void D3(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2, gp_Vec V3)
        {
            throw new NotImplementedException();
        }

        public gp_Vec DN(double U, int N)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt LocalValue(double U, int FromK1, int ToK2)
        {
            throw new NotImplementedException();
        }

        public void LocalD0(double U, int FromK1, int ToK2, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void LocalD1(double U, int FromK1, int ToK2, gp_Pnt P, gp_Vec V1)
        {
            throw new NotImplementedException();
        }

        public void LocalD2(double U, int FromK1, int ToK2, gp_Pnt P, gp_Vec V1, gp_Vec V2)
        {
            throw new NotImplementedException();
        }

        public void LocalD3(double U, int FromK1, int ToK2, gp_Pnt P, gp_Vec V1, gp_Vec V2, gp_Vec V3)
        {
            throw new NotImplementedException();
        }

        public gp_Vec LocalDN(double U, int FromK1, int ToK2, int N)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt EndPoint()
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

        public TColStd_Array1OfReal Knots()
        {
            throw new NotImplementedException();
        }

        public void KnotSequence(TColStd_Array1OfReal K)
        {
            throw new NotImplementedException();
        }

        public TColStd_Array1OfReal KnotSequence()
        {
            throw new NotImplementedException();
        }

        public GeomAbs_BSplKnotDistribution KnotDistribution()
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

        public TColStd_Array1OfInteger Multiplicities()
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

        public gp_Pnt Pole(int Index)
        {
            throw new NotImplementedException();
        }

        public void Poles(TColgp_Array1OfPnt P)
        {
            throw new NotImplementedException();
        }

        public TColgp_Array1OfPnt Poles()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt StartPoint()
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

        public TColStd_Array1OfReal Weights()
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

        public void Resolution(double Tolerance3D, ref double UTolerance)
        {
            throw new NotImplementedException();
        }

        public Geom_Geometry Copy()
        {
            throw new NotImplementedException();
        }

        public bool IsEqual(Geom_BSplineCurve theOther, double thePreci)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void UpdateKnots()
        {
            throw new NotImplementedException();
        }
    }; // class Geom_BSplineCurve
}