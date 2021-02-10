//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomBase.AppParCurves
{
    //---------------------------------------------------------------------
    //  Class  AppParCurves
    //---------------------------------------------------------------------
    public sealed class AppParCurves
    {
        public AppParCurves()
            : base()
        {
            throw new NotImplementedException();
        }

        public AppParCurves(AppParCurves parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void BernsteinMatrix(int NbPoles, Vector U, math_Matrix A)
        {
            throw new NotImplementedException();
        }

        public void Bernstein(int NbPoles, Vector U, math_Matrix A, math_Matrix DA)
        {
            throw new NotImplementedException();
        }

        public void SecondDerivativeBernstein(double U, Vector DDA)
        {
            throw new NotImplementedException();
        }

        public void SplineFunction(int NbPoles, int Degree, Vector Parameters, Vector FlatKnots,
            math_Matrix A, math_Matrix DA, math_IntegerVector Index)
        {
            throw new NotImplementedException();
        }
    }; // class AppParCurves
}