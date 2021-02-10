//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKGeomBase.AppParCurves;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomBase.AppDef
{
    //---------------------------------------------------------------------
    //  Class  AppDef_BSpParFunctionOfMyBSplGradientOfBSplineCompute
    //---------------------------------------------------------------------
    public sealed class AppDef_BSpParFunctionOfMyBSplGradientOfBSplineCompute : math_MultipleVarFunctionWithGradient
    {
        public AppDef_BSpParFunctionOfMyBSplGradientOfBSplineCompute(AppDef_MultiLine SSP, int FirstPoint,
            int LastPoint, AppParCurves_HArray1OfConstraintCouple TheConstraints, math_Vector Parameters,
            TColStd_Array1OfReal Knots, TColStd_Array1OfInteger Mults, int NbPol)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_BSpParFunctionOfMyBSplGradientOfBSplineCompute(
            AppDef_BSpParFunctionOfMyBSplGradientOfBSplineCompute parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_BSpParFunctionOfMyBSplGradientOfBSplineCompute()
        {
            throw new NotImplementedException();
        }

        public int NbVariables()
        {
            throw new NotImplementedException();
        }

        public bool Value(math_Vector X, ref double F)
        {
            throw new NotImplementedException();
        }

        public bool Gradient(math_Vector X, math_Vector G)
        {
            throw new NotImplementedException();
        }

        public bool Values(math_Vector X, ref double F, math_Vector G)
        {
            throw new NotImplementedException();
        }

        public math_Vector NewParameters()
        {
            throw new NotImplementedException();
        }

        public AppParCurves_MultiBSpCurve CurveValue()
        {
            throw new NotImplementedException();
        }

        public double Error(int IPoint, int CurveIndex)
        {
            throw new NotImplementedException();
        }

        public double MaxError3d()
        {
            throw new NotImplementedException();
        }

        public double MaxError2d()
        {
            throw new NotImplementedException();
        }

        public math_Matrix FunctionMatrix()
        {
            throw new NotImplementedException();
        }

        public math_Matrix DerivativeFunctionMatrix()
        {
            throw new NotImplementedException();
        }

        public math_IntegerVector Index()
        {
            throw new NotImplementedException();
        }

        public AppParCurves_Constraint FirstConstraint(AppParCurves_HArray1OfConstraintCouple TheConstraints,
            int FirstPoint)
        {
            throw new NotImplementedException();
        }

        public AppParCurves_Constraint LastConstraint(AppParCurves_HArray1OfConstraintCouple TheConstraints,
            int LastPoint)
        {
            throw new NotImplementedException();
        }

        public void SetFirstLambda(double l1)
        {
            throw new NotImplementedException();
        }

        public void SetLastLambda(double l2)
        {
            throw new NotImplementedException();
        }

        public void Perform(math_Vector X)
        {
            throw new NotImplementedException();
        }
    }; // class AppDef_BSpParFunctionOfMyBSplGradientOfBSplineCompute
}