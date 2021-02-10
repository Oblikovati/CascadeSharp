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
    //  Class  AppDef_TheGradient
    //---------------------------------------------------------------------
    public sealed class AppDef_TheGradient
    {
        public AppDef_TheGradient(AppDef_MultiLine SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints, Vector Parameters, int Deg, double Tol3d,
            double Tol2d, int NbIterations)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_TheGradient(AppDef_MultiLine SSP, int FirstPoint, int LastPoint,
            AppParCurves_HArray1OfConstraintCouple TheConstraints, Vector Parameters, int Deg, double Tol3d,
            double Tol2d)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_TheGradient(AppDef_TheGradient parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppDef_TheGradient()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public AppParCurves_MultiCurve Value()
        {
            throw new NotImplementedException();
        }

        public double Error(int Index)
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

        public double AverageError()
        {
            throw new NotImplementedException();
        }
    }; // class AppDef_TheGradient
}