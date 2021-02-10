//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKService.Graphic3d;

namespace CascadeSharp.TKV3d.V3d
{
    //---------------------------------------------------------------------
    //  Class  V3d_PositionLight
    //---------------------------------------------------------------------
    public class V3d_PositionLight : Graphic3d_CLight
    {
        public V3d_PositionLight(Graphic3d_TypeOfLightSource theType)
            : base()
        {
            throw new NotImplementedException();
        }

        public V3d_PositionLight()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class V3d_PositionLight
}