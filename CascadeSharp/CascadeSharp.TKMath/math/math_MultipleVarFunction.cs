//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_MultipleVarFunction
    //---------------------------------------------------------------------
    public abstract class math_MultipleVarFunction
    {
        public math_MultipleVarFunction(math_MultipleVarFunction parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public math_MultipleVarFunction()
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

        public int GetStateNumber()
        {
            throw new NotImplementedException();
        }
    }; // class math_MultipleVarFunction
}