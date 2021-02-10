//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.GeomAbs;

namespace CascadeSharp.TKMath.PLib
{
    //---------------------------------------------------------------------
    //  Class  PLib_JacobiPolynomial
    //---------------------------------------------------------------------
    public sealed class PLib_JacobiPolynomial : PLib_Base
    {
        public PLib_JacobiPolynomial(int WorkDegree, GeomAbs_Shape ConstraintOrder)
            : base()
        {
            throw new NotImplementedException();
        }

        public PLib_JacobiPolynomial(PLib_JacobiPolynomial parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public PLib_JacobiPolynomial()
        {
            throw new NotImplementedException();
        }

        public void Points(int NbGaussPoints, TColStd_Array1OfReal TabPoints)
        {
            throw new NotImplementedException();
        }

        public void Weights(int NbGaussPoints, TColStd_Array2OfReal TabWeights)
        {
            throw new NotImplementedException();
        }

        public void MaxValue(TColStd_Array1OfReal TabMax)
        {
            throw new NotImplementedException();
        }

        public double MaxError(int Dimension, ref double JacCoeff, int NewDegree)
        {
            throw new NotImplementedException();
        }

        public void ReduceDegree(int Dimension, int MaxDegree, double Tol, ref double JacCoeff, ref int NewDegree,
            ref double MaxError)
        {
            throw new NotImplementedException();
        }

        public double AverageError(int Dimension, ref double JacCoeff, int NewDegree)
        {
            throw new NotImplementedException();
        }

        public void ToCoefficients(int Dimension, int Degree, TColStd_Array1OfReal JacCoeff,
            TColStd_Array1OfReal Coefficients)
        {
            throw new NotImplementedException();
        }

        public void D0(double U, TColStd_Array1OfReal Bas_isValue)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, TColStd_Array1OfReal Bas_isValue, TColStd_Array1OfReal Bas_isD1)
        {
            throw new NotImplementedException();
        }

        public void D2(double U, TColStd_Array1OfReal Bas_isValue, TColStd_Array1OfReal Bas_isD1,
            TColStd_Array1OfReal Bas_isD2)
        {
            throw new NotImplementedException();
        }

        public void D3(double U, TColStd_Array1OfReal Bas_isValue, TColStd_Array1OfReal Bas_isD1,
            TColStd_Array1OfReal Bas_isD2, TColStd_Array1OfReal Bas_isD3)
        {
            throw new NotImplementedException();
        }

        public int WorkDegree()
        {
            throw new NotImplementedException();
        }

        public int NivConstr()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void D0123(int NDerive, double U, TColStd_Array1OfReal Bas_isValue, TColStd_Array1OfReal Bas_isD1,
            TColStd_Array1OfReal Bas_isD2, TColStd_Array1OfReal Bas_isD3)
        {
            throw new NotImplementedException();
        }
    }; // class PLib_JacobiPolynomial
}