//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

namespace CascadeSharp.TKService.Graphic3d
{
    //---------------------------------------------------------------------
    //  Enum  Graphic3d_TypeOfShaderObject
    //---------------------------------------------------------------------
    public enum Graphic3d_TypeOfShaderObject
    {
        Graphic3d_TOS_VERTEX = 1,
        Graphic3d_TOS_TESS_CONTROL = 2,
        Graphic3d_TOS_TESS_EVALUATION = 4,
        Graphic3d_TOS_GEOMETRY = 8,
        Graphic3d_TOS_FRAGMENT = 16,
        Graphic3d_TOS_COMPUTE = 32
    } // enum  class Graphic3d_TypeOfShaderObject
}