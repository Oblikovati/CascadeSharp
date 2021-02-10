//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_FunctionSet
    //---------------------------------------------------------------------
    public abstract class math_FunctionSet
    {
        public math_FunctionSet(math_FunctionSet parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public math_FunctionSet()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public int NbVariables()
        {
            throw new NotImplementedException();
        }

        public int NbEquations()
        {
            throw new NotImplementedException();
        }

        public bool Value(Vector X, Vector F)
        {
            throw new NotImplementedException();
        }

        public int GetStateNumber()
        {
            throw new NotImplementedException();
        }
    }; // class math_FunctionSet
}