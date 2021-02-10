//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

namespace CascadeSharp.TKGeomAlgo.LocalAnalysis
{
    //---------------------------------------------------------------------
    //  Enum  LocalAnalysis_StatusErrorType
    //---------------------------------------------------------------------
    public enum LocalAnalysis_StatusErrorType
    {
        LocalAnalysis_NullFirstDerivative = 0,
        LocalAnalysis_NullSecondDerivative = 1,
        LocalAnalysis_TangentNotDefined = 2,
        LocalAnalysis_NormalNotDefined = 3,
        LocalAnalysis_CurvatureNotDefined = 4
    } // enum  class LocalAnalysis_StatusErrorType
}