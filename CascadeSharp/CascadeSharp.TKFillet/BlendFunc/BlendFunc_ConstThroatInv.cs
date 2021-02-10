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
    //  Class  BlendFunc_ConstThroatInv
    //---------------------------------------------------------------------
    public class BlendFunc_ConstThroatInv : BlendFunc_GenChamfInv
    {
        public BlendFunc_ConstThroatInv(Adaptor3d_HSurface S1, Adaptor3d_HSurface S2, Adaptor3d_HCurve C)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_ConstThroatInv(BlendFunc_ConstThroatInv parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BlendFunc_ConstThroatInv()
        {
            throw new NotImplementedException();
        }

        public bool IsSolution(math_Vector Sol, double Tol)
        {
            throw new NotImplementedException();
        }

        public bool Value(math_Vector X, math_Vector F)
        {
            throw new NotImplementedException();
        }

        public bool Derivatives(math_Vector X, math_Matrix D)
        {
            throw new NotImplementedException();
        }

        public void Set(double theThroat, double parameter1, int Choix)
        {
            throw new NotImplementedException();
        }
    }; // class BlendFunc_ConstThroatInv
}