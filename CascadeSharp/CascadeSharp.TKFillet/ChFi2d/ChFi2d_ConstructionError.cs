//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

namespace CascadeSharp.TKFillet.ChFi2d
{
	//---------------------------------------------------------------------
	//  Enum  ChFi2d_ConstructionError
	//---------------------------------------------------------------------
	public	enum ChFi2d_ConstructionError
	{
		ChFi2d_NotPlanar = 0,
		ChFi2d_NoFace = 1,
		ChFi2d_InitialisationError = 2,
		ChFi2d_ParametersError = 3,
		ChFi2d_Ready = 4,
		ChFi2d_IsDone = 5,
		ChFi2d_ComputationError = 6,
		ChFi2d_ConnexionError = 7,
		ChFi2d_TangencyError = 8,
		ChFi2d_FirstEdgeDegenerated = 9,
		ChFi2d_LastEdgeDegenerated = 10,
		ChFi2d_BothEdgesDegenerated = 11,
		ChFi2d_NotAuthorized = 12
	} // enum  class ChFi2d_ConstructionError

}
