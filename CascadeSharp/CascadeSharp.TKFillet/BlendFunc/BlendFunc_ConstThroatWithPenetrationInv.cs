//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKFillet.BlendFunc
{
    //---------------------------------------------------------------------
    //  Class  BlendFunc_ConstThroatWithPenetrationInv
    //---------------------------------------------------------------------
    public sealed class BlendFunc_ConstThroatWithPenetrationInv : BlendFunc_ConstThroatInv
    {
        public BlendFunc_ConstThroatWithPenetrationInv(Adaptor3d_HSurface S1, Adaptor3d_HSurface S2, Adaptor3d_HCurve C)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_ConstThroatWithPenetrationInv(BlendFunc_ConstThroatWithPenetrationInv parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_ConstThroatWithPenetrationInv()
        {
            throw new NotImplementedException();
        }

        public bool IsSolution(Vector Sol, double Tol)
        {
            throw new NotImplementedException();
        }

        public bool Value(Vector X, Vector F)
        {
            throw new NotImplementedException();
        }

        public bool Derivatives(Vector X, math_Matrix D)
        {
            throw new NotImplementedException();
        }
    }; // class BlendFunc_ConstThroatWithPenetrationInv
}