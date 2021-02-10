//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_NewtonFunctionSetRoot
    //---------------------------------------------------------------------
    public sealed class math_NewtonFunctionSetRoot
    {
        public math_NewtonFunctionSetRoot(math_FunctionSetWithDerivatives theFunction, Vector theXTolerance,
            double theFTolerance, int tehNbIterations)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_NewtonFunctionSetRoot(math_FunctionSetWithDerivatives theFunction, Vector theXTolerance,
            double theFTolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_NewtonFunctionSetRoot(math_FunctionSetWithDerivatives theFunction, double theFTolerance,
            int theNbIterations)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_NewtonFunctionSetRoot(math_FunctionSetWithDerivatives theFunction, double theFTolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_NewtonFunctionSetRoot(math_NewtonFunctionSetRoot parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_NewtonFunctionSetRoot()
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(Vector XTol)
        {
            throw new NotImplementedException();
        }

        public void Perform(math_FunctionSetWithDerivatives theFunction, Vector theStartingPoint)
        {
            throw new NotImplementedException();
        }

        public void Perform(math_FunctionSetWithDerivatives theFunction, Vector theStartingPoint,
            Vector theInfBound, Vector theSupBound)
        {
            throw new NotImplementedException();
        }

        public bool IsSolutionReached(math_FunctionSetWithDerivatives F)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public Vector Root()
        {
            throw new NotImplementedException();
        }

        public void Root(Vector Root)
        {
            throw new NotImplementedException();
        }

        public int StateNumber()
        {
            throw new NotImplementedException();
        }

        public math_Matrix Derivative()
        {
            throw new NotImplementedException();
        }

        public void Derivative(math_Matrix Der)
        {
            throw new NotImplementedException();
        }

        public Vector FunctionSetErrors()
        {
            throw new NotImplementedException();
        }

        public void FunctionSetErrors(Vector Err)
        {
            throw new NotImplementedException();
        }

        public int NbIterations()
        {
            throw new NotImplementedException();
        }
    }; // class math_NewtonFunctionSetRoot
}