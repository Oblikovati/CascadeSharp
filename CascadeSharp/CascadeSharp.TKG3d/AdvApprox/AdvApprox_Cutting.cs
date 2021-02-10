//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKG3d.AdvApprox
{
    //---------------------------------------------------------------------
    //  Class  AdvApprox_Cutting
    //---------------------------------------------------------------------
    public abstract class AdvApprox_Cutting
    {
        public AdvApprox_Cutting(AdvApprox_Cutting parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public AdvApprox_Cutting()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public bool Value(double a, double b, ref double cuttingvalue)
        {
            throw new NotImplementedException();
        }
    }; // class AdvApprox_Cutting
}