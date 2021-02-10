//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKV3d.V3d
{
    //---------------------------------------------------------------------
    //  Class  V3d_PositionalLight
    //---------------------------------------------------------------------
    public sealed class V3d_PositionalLight : V3d_PositionLight
    {
        public V3d_PositionalLight(gp_Pnt thePos, Quantity_Color theColor)
            : base()
        {
            throw new NotImplementedException();
        }

        public V3d_PositionalLight(gp_Pnt thePos)
            : base()
        {
            throw new NotImplementedException();
        }

        public V3d_PositionalLight()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class V3d_PositionalLight
}