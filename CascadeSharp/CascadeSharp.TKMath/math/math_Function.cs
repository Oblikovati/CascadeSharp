//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.math
{
    //---------------------------------------------------------------------
    //  Class  math_Function
    //---------------------------------------------------------------------
    public abstract class math_Function
    {
        public math_Function(math_Function parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public math_Function()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public bool Value(double X, ref double F)
        {
            throw new NotImplementedException();
        }

        public int GetStateNumber()
        {
            throw new NotImplementedException();
        }
    }; // class math_Function
}