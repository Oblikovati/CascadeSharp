//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

namespace CascadeSharp.TKFillet.Blend
{
    //---------------------------------------------------------------------
    //  Enum  Blend_Status
    //---------------------------------------------------------------------
    public enum Blend_Status
    {
        Blend_StepTooLarge = 0,
        Blend_StepTooSmall = 1,
        Blend_Backward = 2,
        Blend_SamePoints = 3,
        Blend_OnRst1 = 4,
        Blend_OnRst2 = 5,
        Blend_OnRst12 = 6,
        Blend_OK = 7
    } // enum  class Blend_Status
}