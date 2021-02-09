//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Enum  gp_TrsfForm
	//---------------------------------------------------------------------
	public	enum gp_TrsfForm
	{
		gp_Identity = 0,
		gp_Rotation = 1,
		gp_Translation = 2,
		gp_PntMirror = 3,
		gp_Ax1Mirror = 4,
		gp_Ax2Mirror = 5,
		gp_Scale = 6,
		gp_CompoundTrsf = 7,
		gp_Other = 8
	} // enum  class gp_TrsfForm

}
