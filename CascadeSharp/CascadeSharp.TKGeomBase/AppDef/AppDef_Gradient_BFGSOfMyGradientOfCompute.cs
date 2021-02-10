//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomBase.AppDef
{
    //---------------------------------------------------------------------
    //  Class  AppDef_Gradient_BFGSOfMyGradientOfCompute
    //---------------------------------------------------------------------
    public sealed class AppDef_Gradient_BFGSOfMyGradientOfCompute : math_BFGS
    {
        public AppDef_Gradient_BFGSOfMyGradientOfCompute(math_MultipleVarFunctionWithGradient F,
            math_Vector StartingPoint, double Tolerance3d, double Tolerance2d, double Eps, int NbIterations)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_Gradient_BFGSOfMyGradientOfCompute(math_MultipleVarFunctionWithGradient F,
            math_Vector StartingPoint, double Tolerance3d, double Tolerance2d, double Eps)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_Gradient_BFGSOfMyGradientOfCompute(AppDef_Gradient_BFGSOfMyGradientOfCompute parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_Gradient_BFGSOfMyGradientOfCompute()
        {
            throw new NotImplementedException();
        }

        public bool IsSolutionReached(math_MultipleVarFunctionWithGradient F)
        {
            throw new NotImplementedException();
        }
    }; // class AppDef_Gradient_BFGSOfMyGradientOfCompute
}