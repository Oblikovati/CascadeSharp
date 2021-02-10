//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_FRPR
    //---------------------------------------------------------------------
    public sealed class math_FRPR
    {
        public math_FRPR(math_MultipleVarFunctionWithGradient theFunction, double theTolerance, int theNbIterations,
            double theZEPS)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_FRPR(math_MultipleVarFunctionWithGradient theFunction, double theTolerance, int theNbIterations)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_FRPR(math_MultipleVarFunctionWithGradient theFunction, double theTolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_FRPR(math_FRPR parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_FRPR()
        {
            throw new NotImplementedException();
        }

        public void Perform(math_MultipleVarFunctionWithGradient theFunction, Vector theStartingPoint)
        {
            throw new NotImplementedException();
        }

        public bool IsSolutionReached(math_MultipleVarFunctionWithGradient theFunction)
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
    }; // class math_FRPR
}