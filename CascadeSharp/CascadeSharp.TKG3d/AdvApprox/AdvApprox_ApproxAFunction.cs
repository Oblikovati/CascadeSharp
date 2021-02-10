//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKG3d.AdvApprox
{
    //---------------------------------------------------------------------
    //  Class  AdvApprox_ApproxAFunction
    //---------------------------------------------------------------------
    public sealed class AdvApprox_ApproxAFunction
    {
        public AdvApprox_ApproxAFunction(int Num1DSS, int Num2DSS, int Num3DSS, TColStd_HArray1OfReal OneDTol,
            TColStd_HArray1OfReal TwoDTol, TColStd_HArray1OfReal ThreeDTol, double First, double Last,
            GeomAbs_Shape Continuity, int MaxDeg, int MaxSeg, AdvApprox_EvaluatorFunction Func)
            : base()
        {
            throw new NotImplementedException();
        }

        public AdvApprox_ApproxAFunction(int Num1DSS, int Num2DSS, int Num3DSS, TColStd_HArray1OfReal OneDTol,
            TColStd_HArray1OfReal TwoDTol, TColStd_HArray1OfReal ThreeDTol, double First, double Last,
            GeomAbs_Shape Continuity, int MaxDeg, int MaxSeg, AdvApprox_EvaluatorFunction Func,
            AdvApprox_Cutting CutTool)
            : base()
        {
            throw new NotImplementedException();
        }

        public AdvApprox_ApproxAFunction(AdvApprox_ApproxAFunction parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AdvApprox_ApproxAFunction()
        {
            throw new NotImplementedException();
        }

        public void Approximation(int TotalDimension, int TotalNumSS, TColStd_Array1OfInteger LocalDimension,
            double First, double Last, AdvApprox_EvaluatorFunction Evaluator, AdvApprox_Cutting CutTool,
            int ContinuityOrder, int NumMaxCoeffs, int MaxSegments, TColStd_Array1OfReal TolerancesArray,
            int code_prec_is, ref int NumCurves, TColStd_Array1OfInteger NumCoeffPerCurveArray,
            TColStd_Array1OfReal LocalCoefficientArray, TColStd_Array1OfReal IntervalsArray,
            TColStd_Array1OfReal ErrorMaxArray, TColStd_Array1OfReal AverageErrorArray, ref int ErrorCode)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public bool HasResult()
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray2OfReal Poles1d()
        {
            throw new NotImplementedException();
        }

        public TColgp_HArray2OfPnt2d Poles2d()
        {
            throw new NotImplementedException();
        }

        public TColgp_HArray2OfPnt Poles()
        {
            throw new NotImplementedException();
        }

        public int NbPoles()
        {
            throw new NotImplementedException();
        }

        public void Poles1d(int Index, TColStd_Array1OfReal P)
        {
            throw new NotImplementedException();
        }

        public void Poles2d(int Index, TColgp_Array1OfPnt2d P)
        {
            throw new NotImplementedException();
        }

        public void Poles(int Index, TColgp_Array1OfPnt P)
        {
            throw new NotImplementedException();
        }

        public int Degree()
        {
            throw new NotImplementedException();
        }

        public int NbKnots()
        {
            throw new NotImplementedException();
        }

        public int NumSubSpaces(int Dimension)
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray1OfReal Knots()
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray1OfInteger Multiplicities()
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray1OfReal MaxError(int Dimension)
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray1OfReal AverageError(int Dimension)
        {
            throw new NotImplementedException();
        }

        public double MaxError(int Dimension, int Index)
        {
            throw new NotImplementedException();
        }

        public double AverageError(int Dimension, int Index)
        {
            throw new NotImplementedException();
        }

        public void Perform(int Num1DSS, int Num2DSS, int Num3DSS, AdvApprox_Cutting CutTool)
        {
            throw new NotImplementedException();
        }
    }; // class AdvApprox_ApproxAFunction
}