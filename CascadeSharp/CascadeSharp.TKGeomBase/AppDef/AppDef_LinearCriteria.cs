//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKGeomBase.FEmTool;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomBase.AppDef
{
    //---------------------------------------------------------------------
    //  Class  AppDef_LinearCriteria
    //---------------------------------------------------------------------
    public sealed class AppDef_LinearCriteria : AppDef_SmoothCriterion
    {
        public AppDef_LinearCriteria(AppDef_MultiLine SSP, int FirstPoint, int LastPoint)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_LinearCriteria(AppDef_LinearCriteria parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_LinearCriteria()
        {
            throw new NotImplementedException();
        }

        public void SetParameters(TColStd_HArray1OfReal Parameters)
        {
            throw new NotImplementedException();
        }

        public void SetCurve(FEmTool_Curve C)
        {
            throw new NotImplementedException();
        }

        public void GetCurve(FEmTool_Curve C)
        {
            throw new NotImplementedException();
        }

        public void SetEstimation(double E1, double E2, double E3)
        {
            throw new NotImplementedException();
        }

        public double EstLength()
        {
            throw new NotImplementedException();
        }

        public void GetEstimation(ref double E1, ref double E2, ref double E3)
        {
            throw new NotImplementedException();
        }

        public FEmTool_HAssemblyTable AssemblyTable()
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray2OfInteger DependenceTable()
        {
            throw new NotImplementedException();
        }

        public int QualityValues(double J1min, double J2min, double J3min, ref double J1, ref double J2, ref double J3)
        {
            throw new NotImplementedException();
        }

        public void ErrorValues(ref double MaxError, ref double QuadraticError, ref double AverageError)
        {
            throw new NotImplementedException();
        }

        public void Hessian(int Element, int Dimension1, int Dimension2, math_Matrix H)
        {
            throw new NotImplementedException();
        }

        public void Gradient(int Element, int Dimension, Vector G)
        {
            throw new NotImplementedException();
        }

        public void InputVector(Vector X, FEmTool_HAssemblyTable AssTable)
        {
            throw new NotImplementedException();
        }

        public void SetWeight(double QuadraticWeight, double QualityWeight, double percentJ1, double percentJ2,
            double percentJ3)
        {
            throw new NotImplementedException();
        }

        public void GetWeight(ref double QuadraticWeight, ref double QualityWeight)
        {
            throw new NotImplementedException();
        }

        public void SetWeight(TColStd_Array1OfReal Weight)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void BuildCache(int E)
        {
            throw new NotImplementedException();
        }
    }; // class AppDef_LinearCriteria
}