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

        public void SetBoundary(Vector theLeftBorder, Vector theRightBorder)
        {
            throw new NotImplementedException();
        }

        public void Perform(math_MultipleVarFunctionWithGradient F, Vector StartingPoint)
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

        public Vector Location()
        {
            throw new NotImplementedException();
        }

        public void Location(Vector Loc)
        {
            throw new NotImplementedException();
        }

        public double Minimum()
        {
            throw new NotImplementedException();
        }

        public Vector Gradient()
        {
            throw new NotImplementedException();
        }

        public void Gradient(Vector Grad)
        {
            throw new NotImplementedException();
        }

        public int NbIterations()
        {
            throw new NotImplementedException();
        }
    }; // class math_BFGS
}