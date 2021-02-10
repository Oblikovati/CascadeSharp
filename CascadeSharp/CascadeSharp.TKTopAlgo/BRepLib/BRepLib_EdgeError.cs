//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

namespace CascadeSharp.TKTopAlgo.BRepLib
{
    //---------------------------------------------------------------------
    //  Enum  BRepLib_EdgeError
    //---------------------------------------------------------------------
    public enum BRepLib_EdgeError
    {
        BRepLib_EdgeDone = 0,
        BRepLib_PointProjectionFailed = 1,
        BRepLib_ParameterOutOfRange = 2,
        BRepLib_DifferentPointsOnClosedCurve = 3,
        BRepLib_PointWithInfiniteParameter = 4,
        BRepLib_DifferentsPointAndParameter = 5,
        BRepLib_LineThroughIdenticPoints = 6
    } // enum  class BRepLib_EdgeError
}