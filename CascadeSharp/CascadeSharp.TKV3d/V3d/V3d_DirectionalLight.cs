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
    //  Class  V3d_DirectionalLight
    //---------------------------------------------------------------------
    public sealed class V3d_DirectionalLight : V3d_PositionLight
    {
        public V3d_DirectionalLight(V3d_TypeOfOrientation theDirection, Quantity_Color theColor, bool theIsHeadlight)
            : base()
        {
            throw new NotImplementedException();
        }

        public V3d_DirectionalLight(V3d_TypeOfOrientation theDirection, Quantity_Color theColor)
            : base()
        {
            throw new NotImplementedException();
        }

        public V3d_DirectionalLight(V3d_TypeOfOrientation theDirection)
            : base()
        {
            throw new NotImplementedException();
        }

        public V3d_DirectionalLight(gp_Dir theDirection, Quantity_Color theColor, bool theIsHeadlight)
            : base()
        {
            throw new NotImplementedException();
        }

        public V3d_DirectionalLight(gp_Dir theDirection, Quantity_Color theColor)
            : base()
        {
            throw new NotImplementedException();
        }

        public V3d_DirectionalLight(gp_Dir theDirection)
            : base()
        {
            throw new NotImplementedException();
        }

        public V3d_DirectionalLight()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void SetDirection(V3d_TypeOfOrientation theDirection)
        {
            throw new NotImplementedException();
        }
    }; // class V3d_DirectionalLight
}