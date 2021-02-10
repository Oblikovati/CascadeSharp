//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_BFGS
    //---------------------------------------------------------------------
    public class math_BFGS
    {
        public math_BFGS(int NbVariables, double Tolerance, int NbIterations, double ZEPS)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_BFGS(int NbVariables, double Tolerance, int NbIterations)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_BFGS(int NbVariables, double Tolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_BFGS(int NbVariables)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_BFGS(math_BFGS parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_BFGS()
        {
            throw new NotImplementedException();
        }

        public void SetBoundary(math_Vector theLeftBorder, math_Vector theRightBorder)
        {
            throw new NotImplementedException();
        }

        public void Perform(math_MultipleVarFunctionWithGradient F, math_Vector StartingPoint)
        {
            throw new NotImplementedException();
        }

        public bool IsSolutionReached(math_MultipleVarFunctionWithGradient F)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public math_Vector Location()
        {
            throw new NotImplementedException();
        }

        public void Location(math_Vector Loc)
        {
            throw new NotImplementedException();
        }

        public double Minimum()
        {
            throw new NotImplementedException();
        }

        public math_Vector Gradient()
        {
            throw new NotImplementedException();
        }

        public void Gradient(math_Vector Grad)
        {
            throw new NotImplementedException();
        }

        public int NbIterations()
        {
            throw new NotImplementedException();
        }
    }; // class math_BFGS
}