//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.SelectMgr;
using CascadeSharp.TKV3d.V3d;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_ViewCubeOwner
	//---------------------------------------------------------------------
	public  sealed class AIS_ViewCubeOwner : SelectMgr_EntityOwner
	{

		public AIS_ViewCubeOwner(AIS_ViewCube theObject, V3d_TypeOfOrientation theOrient, int thePriority)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_ViewCubeOwner(AIS_ViewCube theObject, V3d_TypeOfOrientation theOrient)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_ViewCubeOwner(AIS_ViewCubeOwner parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_ViewCubeOwner()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool IsForcedHilight()
		{
			throw new NotImplementedException();
		}

		public V3d_TypeOfOrientation MainOrientation()
		{
			throw new NotImplementedException();
		}

		public bool HandleMouseClick(Graphic3d_Vec2i thePoint, uint theButton, uint theModifiers, bool theIsDoubleClick)
		{
			throw new NotImplementedException();
		}


	}; // class AIS_ViewCubeOwner

}
