//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKV3d.Prs3d;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_GlobalStatus
	//---------------------------------------------------------------------
	public  sealed class AIS_GlobalStatus : Standard_Transient
	{

		public AIS_GlobalStatus()
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_GlobalStatus(AIS_DisplayStatus aStat, int aD_ispMode, int aSelMode, bool _ishilighted, int aLayerIndex)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_GlobalStatus(AIS_DisplayStatus aStat, int aD_ispMode, int aSelMode, bool _ishilighted)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_GlobalStatus(AIS_DisplayStatus aStat, int aD_ispMode, int aSelMode)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_GlobalStatus(AIS_GlobalStatus parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void SetGraphicStatus(AIS_DisplayStatus theStatus)
		{
			throw new NotImplementedException();
		}

		public void AddSelectionMode(int theMode)
		{
			throw new NotImplementedException();
		}

		public void SetDisplayMode(int theMode)
		{
			throw new NotImplementedException();
		}

		public int DisplayMode()
		{
			throw new NotImplementedException();
		}

		public void SetLayerIndex(int theIndex)
		{
			throw new NotImplementedException();
		}

		public void SetHilightStatus(bool theStatus)
		{
			throw new NotImplementedException();
		}

		public void SetHilightStyle(Prs3d_Drawer theStyle)
		{
			throw new NotImplementedException();
		}

		public Prs3d_Drawer HilightStyle()
		{
			throw new NotImplementedException();
		}

		public bool IsSubIntensityOn()
		{
			throw new NotImplementedException();
		}

		public void SubIntensityOn()
		{
			throw new NotImplementedException();
		}

		public void SubIntensityOff()
		{
			throw new NotImplementedException();
		}

		public void RemoveSelectionMode(int aMode)
		{
			throw new NotImplementedException();
		}

		public void ClearSelectionModes()
		{
			throw new NotImplementedException();
		}

		public AIS_DisplayStatus GraphicStatus()
		{
			throw new NotImplementedException();
		}

		public TColStd_ListOfInteger SelectionModes()
		{
			throw new NotImplementedException();
		}

		public bool IsHilighted()
		{
			throw new NotImplementedException();
		}

		public bool IsSModeIn(int aMode)
		{
			throw new NotImplementedException();
		}

		public int GetLayerIndex()
		{
			throw new NotImplementedException();
		}


	}; // class AIS_GlobalStatus

}
