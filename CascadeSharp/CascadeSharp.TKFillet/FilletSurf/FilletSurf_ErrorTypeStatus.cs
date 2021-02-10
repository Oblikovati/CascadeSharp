//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Enum  FilletSurf_ErrorTypeStatus
	//---------------------------------------------------------------------
	public	enum FilletSurf_ErrorTypeStatus
	{
		FilletSurf_EmptyList = 0,
		FilletSurf_EdgeNotG1 = 1,
		FilletSurf_FacesNotG1 = 2,
		FilletSurf_EdgeNotOnShape = 3,
		FilletSurf_NotSharpEdge = 4,
		FilletSurf_PbFilletCompute = 5
	} // enum  class FilletSurf_ErrorTypeStatus

}
