//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_NewtonMinimum
    //---------------------------------------------------------------------
    public class math_NewtonMinimum
    {
        public math_NewtonMinimum(math_MultipleVarFunctionWithHessian theFunction, double theTolerance,
            int theNbIterations, double theConvexity, bool theWithSingularity)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_NewtonMinimum(math_MultipleVarFunctionWithHessian theFunction, double theTolerance,
            int theNbIterations, double theConvexity)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_NewtonMinimum(math_MultipleVarFunctionWithHessian theFunction, double theTolerance,
            int theNbIterations)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_NewtonMinimum(math_MultipleVarFunctionWithHessian theFunction, double theTolerance)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_NewtonMinimum(math_MultipleVarFunctionWithHessian theFunction)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_NewtonMinimum(math_NewtonMinimum parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public math_NewtonMinimum()
        {
            throw new NotImplementedException();
        }

        public void Perform(math_MultipleVarFunctionWithHessian theFunction, math_Vector theStartingPoint)
        {
            throw new NotImplementedException();
        }

        public bool IsConverged()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public bool IsConvex()
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

        public void SetBoundary(math_Vector theLeftBorder, math_Vector theRightBorder)
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

        public math_Status GetStatus()
        {
            throw new NotImplementedException();
        }
    }; // class math_NewtonMinimum
}