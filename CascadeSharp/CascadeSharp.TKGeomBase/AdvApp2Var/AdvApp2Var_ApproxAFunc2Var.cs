//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.AdvApprox;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKGeomBase.AdvApp2Var
{
    //---------------------------------------------------------------------
    //  Class  AdvApp2Var_ApproxAFunc2Var
    //---------------------------------------------------------------------
    public sealed class AdvApp2Var_ApproxAFunc2Var
    {
        public AdvApp2Var_ApproxAFunc2Var(int Num1DSS, int Num2DSS, int Num3DSS, TColStd_HArray1OfReal OneDTol,
            TColStd_HArray1OfReal TwoDTol, TColStd_HArray1OfReal ThreeDTol, TColStd_HArray2OfReal OneDTolFr,
            TColStd_HArray2OfReal TwoDTolFr, TColStd_HArray2OfReal ThreeDTolFr, double FirstInU, double LastInU,
            double FirstInV, double LastInV, GeomAbs_IsoType FavorIso, GeomAbs_Shape ContInU, GeomAbs_Shape ContInV,
            int Prec_isCode, int MaxDegInU, int MaxDegInV, int MaxPatch, AdvApp2Var_EvaluatorFunc2Var Func,
            AdvApprox_Cutting UChoice, AdvApprox_Cutting VChoice)
            : base()
        {
            throw new NotImplementedException();
        }

        public AdvApp2Var_ApproxAFunc2Var(int Num1DSS, int Num2DSS, int Num3DSS, TColStd_HArray1OfReal OneDTol,
            TColStd_HArray1OfReal TwoDTol, TColStd_HArray1OfReal ThreeDTol, TColStd_HArray2OfReal OneDTolFr,
            TColStd_HArray2OfReal TwoDTolFr, TColStd_HArray2OfReal ThreeDTolFr, double FirstInU, double LastInU,
            double FirstInV, double LastInV, GeomAbs_IsoType FavorIso, GeomAbs_Shape ContInU, GeomAbs_Shape ContInV,
            int Prec_isCode, int MaxDegInU, int MaxDegInV, int MaxPatch, AdvApp2Var_EvaluatorFunc2Var Func,
            AdvApp2Var_Criterion Crit, AdvApprox_Cutting UChoice, AdvApprox_Cutting VChoice)
            : base()
        {
            throw new NotImplementedException();
        }

        public AdvApp2Var_ApproxAFunc2Var(AdvApp2Var_ApproxAFunc2Var parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AdvApp2Var_ApproxAFunc2Var()
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

        public Geom_BSplineSurface Surface(int Index)
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

        public int NumSubSpaces(int Dimension)
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

        public TColStd_HArray1OfReal UFrontError(int Dimension)
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray1OfReal VFrontError(int Dimension)
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

        public double UFrontError(int Dimension, int Index)
        {
            throw new NotImplementedException();
        }

        public double VFrontError(int Dimension, int Index)
        {
            throw new NotImplementedException();
        }

        public double CritError(int Dimension, int Index)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public void InitGrid(int NbInt)
        {
            throw new NotImplementedException();
        }

        public void Perform(AdvApprox_Cutting UChoice, AdvApprox_Cutting VChoice, AdvApp2Var_EvaluatorFunc2Var Func)
        {
            throw new NotImplementedException();
        }

        public void Perform(AdvApprox_Cutting UChoice, AdvApprox_Cutting VChoice, AdvApp2Var_EvaluatorFunc2Var Func,
            AdvApp2Var_Criterion Crit)
        {
            throw new NotImplementedException();
        }

        public void ComputePatches(AdvApprox_Cutting UChoice, AdvApprox_Cutting VChoice,
            AdvApp2Var_EvaluatorFunc2Var Func)
        {
            throw new NotImplementedException();
        }

        public void ComputePatches(AdvApprox_Cutting UChoice, AdvApprox_Cutting VChoice,
            AdvApp2Var_EvaluatorFunc2Var Func, AdvApp2Var_Criterion Crit)
        {
            throw new NotImplementedException();
        }

        public void ComputeConstraints(AdvApprox_Cutting UChoice, AdvApprox_Cutting VChoice,
            AdvApp2Var_EvaluatorFunc2Var Func)
        {
            throw new NotImplementedException();
        }

        public void ComputeConstraints(AdvApprox_Cutting UChoice, AdvApprox_Cutting VChoice,
            AdvApp2Var_EvaluatorFunc2Var Func, AdvApp2Var_Criterion Crit)
        {
            throw new NotImplementedException();
        }

        public void Compute3DErrors()
        {
            throw new NotImplementedException();
        }

        public void ComputeCritError()
        {
            throw new NotImplementedException();
        }

        public void ConvertBS()
        {
            throw new NotImplementedException();
        }
    }; // class AdvApp2Var_ApproxAFunc2Var
}