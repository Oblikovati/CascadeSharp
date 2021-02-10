//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

namespace CascadeSharp.TKFillet.ChFiDS
{
    //---------------------------------------------------------------------
    //  Enum  ChFiDS_State
    //---------------------------------------------------------------------
    public enum ChFiDS_State
    {
        ChFiDS_OnSame = 0,
        ChFiDS_OnDiff = 1,
        ChFiDS_AllSame = 2,
        ChFiDS_BreakPoint = 3,
        ChFiDS_FreeBoundary = 4,
        ChFiDS_Closed = 5,
        ChFiDS_Tangent = 6
    } // enum  class ChFiDS_State
}