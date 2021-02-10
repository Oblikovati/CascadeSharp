//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKService.Graphic3d;

namespace CascadeSharp.TKV3d.V3d
{
	//---------------------------------------------------------------------
	//  Class  V3d_AmbientLight
	//---------------------------------------------------------------------
	public  sealed class V3d_AmbientLight : Graphic3d_CLight
	{

		public V3d_AmbientLight(Quantity_Color theColor)
			: base()
		{
			throw new NotImplementedException();
		}

		public V3d_AmbientLight()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class V3d_AmbientLight

}
