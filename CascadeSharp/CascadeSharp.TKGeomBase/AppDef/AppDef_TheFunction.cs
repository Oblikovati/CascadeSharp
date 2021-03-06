//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKGeomBase.AppParCurves;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomBase.AppDef
{
    //---------------------------------------------------------------------
    //  Class  AppDef_TheFunction
    //---------------------------------------------------------------------
    public sealed class AppDef_TheFunction : math_MultipleVarFunctionWithGradient
    {
        public AppDef_TheFunction(AppDef_MultiLine SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints, Vector Parameters, int Deg)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_TheFunction(AppDef_TheFunction parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_TheFunction()
        {
            throw new NotImplementedException();
        }

        public int NbVariables()
        {
            throw new NotImplementedException();
        }

        public bool Value(Vector X, ref double F)
        {
            throw new NotImplementedException();
        }

        public bool Gradient(Vector X, Vector G)
        {
            throw new NotImplementedException();
        }

        public bool Values(Vector X, ref double F, Vector G)
        {
            throw new NotImplementedException();
        }

        public Vector NewParameters()
        {
            throw new NotImplementedException();
        }

        public AppParCurves_MultiCurve CurveValue()
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

        public void Perform(Vector X)
        {
            throw new NotImplementedException();
        }
    }; // class AppDef_TheFunction
}