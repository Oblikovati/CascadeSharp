//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_MultipleVarFunctionWithGradient
    //---------------------------------------------------------------------
    public abstract class math_MultipleVarFunctionWithGradient : math_MultipleVarFunction
    {
        public math_MultipleVarFunctionWithGradient(math_MultipleVarFunctionWithGradient parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public math_MultipleVarFunctionWithGradient()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public int NbVariables()
        {
            throw new NotImplementedException();
        }

        public bool Value(math_Vector X, ref double F)
        {
            throw new NotImplementedException();
        }

        public bool Gradient(math_Vector X, math_Vector G)
        {
            throw new NotImplementedException();
        }

        public bool Values(math_Vector X, ref double F, math_Vector G)
        {
            throw new NotImplementedException();
        }
    }; // class math_MultipleVarFunctionWithGradient
}