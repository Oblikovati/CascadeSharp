//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Enum  Graphic3d_TypeOfShadingModel
	//---------------------------------------------------------------------
	public	enum Graphic3d_TypeOfShadingModel
	{
		Graphic3d_TOSM_DEFAULT = -1,
		Graphic3d_TOSM_UNLIT = 0,
		Graphic3d_TOSM_FACET = 1,
		Graphic3d_TOSM_VERTEX = 2,
		Graphic3d_TOSM_FRAGMENT = 3,
		Graphic3d_TOSM_PBR = 4,
		Graphic3d_TOSM_PBR_FACET = 5,
		Graphic3d_TOSM_NONE = 0,
		V3d_COLOR = 0,
		V3d_FLAT = 1,
		V3d_GOURAUD = 2,
		V3d_PHONG = 3
	} // enum  class Graphic3d_TypeOfShadingModel

}
