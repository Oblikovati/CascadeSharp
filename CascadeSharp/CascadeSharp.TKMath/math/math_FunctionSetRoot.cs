//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_FunctionSetRoot
    //---------------------------------------------------------------------
    public sealed class math_FunctionSetRoot
    {
        public math_FunctionSetRoot(math_FunctionSetWithDerivatives F, Vector Tolerance, int NbIterations)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_FunctionSetRoot(math_FunctionSetWithDerivatives F, Vector Tolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_FunctionSetRoot(math_FunctionSetWithDerivatives F, int NbIterations)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_FunctionSetRoot(math_FunctionSetWithDerivatives F)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_FunctionSetRoot(math_FunctionSetRoot parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_FunctionSetRoot()
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(Vector Tolerance)
        {
            throw new NotImplementedException();
        }

        public bool IsSolutionReached(math_FunctionSetWithDerivatives F)
        {
            throw new NotImplementedException();
        }

        public void Perform(math_FunctionSetWithDerivatives theFunction, Vector theStartingPoint,
            bool theStopOnDivergent)
        {
            throw new NotImplementedException();
        }

        public void Perform(math_FunctionSetWithDerivatives theFunction, Vector theStartingPoint)
        {
            throw new NotImplementedException();
        }

        public void Perform(math_FunctionSetWithDerivatives theFunction, Vector theStartingPoint,
            Vector theInfBound, Vector theSupBound, bool theStopOnDivergent)
        {
            throw new NotImplementedException();
        }

        public void Perform(math_FunctionSetWithDerivatives theFunction, Vector theStartingPoint,
            Vector theInfBound, Vector theSupBound)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public int NbIterations()
        {
            throw new NotImplementedException();
        }

        public int StateNumber()
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

        public bool IsDivergent()
        {
            throw new NotImplementedException();
        }
    }; // class math_FunctionSetRoot
}