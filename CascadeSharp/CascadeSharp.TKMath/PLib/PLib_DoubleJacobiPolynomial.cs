//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;

namespace CascadeSharp.TKMath.PLib
{
    //---------------------------------------------------------------------
    //  Class  PLib_DoubleJacobiPolynomial
    //---------------------------------------------------------------------
    public sealed class PLib_DoubleJacobiPolynomial
    {
        public PLib_DoubleJacobiPolynomial()
            : base()
        {
            throw new NotImplementedException();
        }

        public PLib_DoubleJacobiPolynomial(PLib_JacobiPolynomial JacPolU, PLib_JacobiPolynomial JacPolV)
            : base()
        {
            throw new NotImplementedException();
        }

        public PLib_DoubleJacobiPolynomial(PLib_DoubleJacobiPolynomial parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public double MaxErrorU(int Dimension, int DegreeU, int DegreeV, int dJacCoeff, TColStd_Array1OfReal JacCoeff)
        {
            throw new NotImplementedException();
        }

        public double MaxErrorV(int Dimension, int DegreeU, int DegreeV, int dJacCoeff, TColStd_Array1OfReal JacCoeff)
        {
            throw new NotImplementedException();
        }

        public double MaxError(int Dimension, int MinDegreeU, int MaxDegreeU, int MinDegreeV, int MaxDegreeV,
            int dJacCoeff, TColStd_Array1OfReal JacCoeff, double Error)
        {
            throw new NotImplementedException();
        }

        public void ReduceDegree(int Dimension, int MinDegreeU, int MaxDegreeU, int MinDegreeV, int MaxDegreeV,
            int dJacCoeff, TColStd_Array1OfReal JacCoeff, double EpmsCut, ref double MaxError, ref int NewDegreeU,
            ref int NewDegreeV)
        {
            throw new NotImplementedException();
        }

        public double AverageError(int Dimension, int DegreeU, int DegreeV, int dJacCoeff,
            TColStd_Array1OfReal JacCoeff)
        {
            throw new NotImplementedException();
        }

        public void WDoubleJacobiToCoefficients(int Dimension, int DegreeU, int DegreeV, TColStd_Array1OfReal JacCoeff,
            TColStd_Array1OfReal Coefficients)
        {
            throw new NotImplementedException();
        }

        public PLib_JacobiPolynomial U()
        {
            throw new NotImplementedException();
        }

        public PLib_JacobiPolynomial V()
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray1OfReal TabMaxU()
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray1OfReal TabMaxV()
        {
            throw new NotImplementedException();
        }
    }; // class PLib_DoubleJacobiPolynomial
}