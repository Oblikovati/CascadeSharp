//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKGeomBase.AppParCurves;

namespace CascadeSharp.TKGeomBase.AppCont
{
    //---------------------------------------------------------------------
    //  Class  AppCont_LeastSquare
    //---------------------------------------------------------------------
    public sealed class AppCont_LeastSquare
    {
        public AppCont_LeastSquare(AppCont_Function SSP, double U0, double U1, AppParCurves_Constraint FirstCons,
            AppParCurves_Constraint LastCons, int Deg, int NbPoints)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppCont_LeastSquare(AppCont_LeastSquare parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AppCont_LeastSquare()
        {
            throw new NotImplementedException();
        }

        public AppParCurves_MultiCurve Value()
        {
            throw new NotImplementedException();
        }

        public void Error(ref double F, ref double MaxE3d, ref double MaxE2d)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }
    }; // class AppCont_LeastSquare
}