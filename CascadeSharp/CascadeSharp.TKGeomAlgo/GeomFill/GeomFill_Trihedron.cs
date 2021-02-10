//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Enum  GeomFill_Trihedron
	//---------------------------------------------------------------------
	public	enum GeomFill_Trihedron
	{
		GeomFill_IsCorrectedFrenet = 0,
		GeomFill_IsFixed = 1,
		GeomFill_IsFrenet = 2,
		GeomFill_IsConstantNormal = 3,
		GeomFill_IsDarboux = 4,
		GeomFill_IsGuideAC = 5,
		GeomFill_IsGuidePlan = 6,
		GeomFill_IsGuideACWithContact = 7,
		GeomFill_IsGuidePlanWithContact = 8,
		GeomFill_IsDiscreteTrihedron = 9
	} // enum  class GeomFill_Trihedron

}
