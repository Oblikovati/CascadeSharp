//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_MultipleVarFunctionWithHessian
    //---------------------------------------------------------------------
    public abstract class math_MultipleVarFunctionWithHessian : math_MultipleVarFunctionWithGradient
    {
        public math_MultipleVarFunctionWithHessian()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public math_MultipleVarFunctionWithHessian(math_MultipleVarFunctionWithHessian parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public int NbVariables()
        {
            throw new NotImplementedException();
        }

        public bool Value(Vector X, ref double F)
        {
            throw new NotImplementedException();
        }

        public bool Gradient(Vector X, Vector G)
        {
            throw new NotImplementedException();
        }

        public bool Values(Vector X, ref double F, Vector G)
        {
            throw new NotImplementedException();
        }

        public bool Values(Vector X, ref double F, Vector G, math_Matrix H)
        {
            throw new NotImplementedException();
        }
    }; // class math_MultipleVarFunctionWithHessian
}