//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;

namespace CascadeSharp.TKMath.Convert
{
    //---------------------------------------------------------------------
    //  Class  Convert_CompPolynomialToPoles
    //---------------------------------------------------------------------
    public sealed class Convert_CompPolynomialToPoles
    {
        public Convert_CompPolynomialToPoles(int NumCurves, int Continuity, int Dimension, int MaxDegree,
            TColStd_HArray1OfInteger NumCoeffPerCurve, TColStd_HArray1OfReal Coefficients,
            TColStd_HArray2OfReal PolynomialIntervals, TColStd_HArray1OfReal TrueIntervals)
            : base()
        {
            throw new NotImplementedException();
        }

        public Convert_CompPolynomialToPoles(int NumCurves, int Dimension, int MaxDegree,
            TColStd_Array1OfInteger Continuity, TColStd_Array1OfInteger NumCoeffPerCurve,
            TColStd_Array1OfReal Coefficients, TColStd_Array2OfReal PolynomialIntervals,
            TColStd_Array1OfReal TrueIntervals)
            : base()
        {
            throw new NotImplementedException();
        }

        public Convert_CompPolynomialToPoles(int Dimension, int MaxDegree, int Degree,
            TColStd_Array1OfReal Coefficients, TColStd_Array1OfReal PolynomialIntervals,
            TColStd_Array1OfReal TrueIntervals)
            : base()
        {
            throw new NotImplementedException();
        }

        public Convert_CompPolynomialToPoles(Convert_CompPolynomialToPoles parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Convert_CompPolynomialToPoles()
        {
            throw new NotImplementedException();
        }

        public int NbPoles()
        {
            throw new NotImplementedException();
        }

        public void Poles(TColStd_HArray2OfReal Poles)
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

        public void Knots(TColStd_HArray1OfReal K)
        {
            throw new NotImplementedException();
        }

        public void Multiplicities(TColStd_HArray1OfInteger M)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public void Perform(int NumCurves, int MaxDegree, int Dimension, TColStd_Array1OfInteger NumCoeffPerCurve,
            TColStd_Array1OfReal Coefficients, TColStd_Array2OfReal PolynomialIntervals,
            TColStd_Array1OfReal TrueIntervals)
        {
            throw new NotImplementedException();
        }
    }; // class Convert_CompPolynomialToPoles
}